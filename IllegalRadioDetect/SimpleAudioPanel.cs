using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using AsrLibrary;
using AsrLibrary.Entity;
using System.Media;

namespace SDRSharp.IllegalRadioDetect
{
    public partial class SimpleAudioPanel : UserControl
    {
        private IAsr _asr;
        private DataTable dtWav = new DataTable();

        private bool _isBusy = false;
        public bool IsBusy
        {
            get { return _isBusy; }
        }


        public SimpleAudioPanel()
        {
            InitializeComponent();

            _progressBar1.Visible = false;
            _asr = AsrLibrary.AsrFun.GetAsr();
            _asr.OnInitialized += _asr_OnInitialized;
            _asr.Initialize();

            dtWav.Columns.Add("FileName", typeof(string));
            dtWav.Columns.Add("Frequency", typeof(string));
            dtWav.Columns.Add("RecordTime", typeof(DateTime));
            dtWav.Columns.Add("AsrResult", typeof(string));
            dtWav.Columns.Add("Illegal", typeof(string));
            dataGridView1.DataSource = dtWav;

            txtPath.Text = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void _asr_OnInitialized(object sender, EventArgs e)
        {

        }

        // 选择路径音频样本路径
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.ShowNewFolderButton = false;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = dlg.SelectedPath;
                }
            }
        }

        // 语音识别
        private void btnAsr_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text.Trim();
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("请先选择音频文件路径！");
                return;
            }

            if (!Directory.Exists(path))
            {
                MessageBox.Show("指定的路径不存在！");
                return;
            }

            dtWav.Rows.Clear();   // 开始前清理数据
            Asr(path);
        }

        // 入库
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;

            var row = dataGridView1.SelectedRows[0];
            var name = row.Cells["FileName"].Value.ToString();
            if(File.Exists(name))
            {
                SoundPlayer player = new SoundPlayer(name);
                player.Play();
            }
        }

        private void Asr(string path)
        {
            var wavfiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".wav"));
            if (wavfiles == null || wavfiles.Count() <= 0)
            {
                MessageBox.Show("没有找到需要处理的音频文件！");
                return;
            }

            _progressBar1.Maximum = wavfiles.Count();
            _progressBar1.Minimum = 0;
            _progressBar1.Value = 0;
            _progressBar1.Visible = true;

            var list = wavfiles.ToList();
            _isBusy = true;

            ThreadPool.QueueUserWorkItem(o => { Asr(list); });
        }

        private void Asr(List<string> wavList)
        {
            for (int i = 0; i < wavList.Count; i++)
            {
                string wavFileName = wavList[i];
                string pcmFileName = wavFileName.Replace(".wav", ".pcm");
                if (!File.Exists(pcmFileName))
                    continue;

                byte[] data = File.ReadAllBytes(pcmFileName);
                LanguageType languageType = LanguageType.Mandarin;
                string result = string.Empty;
                bool ret = _asr.AudioRecog(data, languageType, out result);
                if (ret)
                {
                    AddNewData(wavFileName, result);
                }

                UpdateProcessBar(i + 1);
            }

            UpdateProcessBar(_progressBar1.Maximum);
            MessageBox.Show("音频文件识别完成！");
            _isBusy = false;
        }

        private void AddNewData(string fileName, string recogResult)
        {
            // ASR_20190703114458_105500000_30.wav
            FileInfo fi = new FileInfo(fileName);
            string name = fi.Name;
            string[] arr = name.Split('_');

            DataRow row = dtWav.NewRow();
            row["FileName"] = fileName;
            row["Frequency"] = arr[2];
            row["RecordTime"] = DateTime.ParseExact(arr[1],"yyyyMMddHHmmss", System.Globalization.CultureInfo.CurrentCulture);
            row["AsrResult"] = recogResult;

            dtWav.Rows.Add(row);
        }

        private void UpdateProcessBar(int value)
        {
            if (_progressBar1.InvokeRequired)
            {
                _progressBar1.Invoke(new Action(() => UpdateProcessBar(value)));
            }
            else
            {
                _progressBar1.Value = value;
            }
        }

    }
}
