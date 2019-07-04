using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SDRSharp.Common;

namespace SDRSharp.IllegalRadioDetect
{
    public partial class IllegalRadioDetectPanel : UserControl
    {
        private readonly ISharpControl _control;
        private readonly RecordingAudioProcessor _audioProcessor = new RecordingAudioProcessor();
        private readonly SimpleRecorder _audioRecorder;
        private bool _isFormShow = false;


        public IllegalRadioDetectPanel(ISharpControl control)
        {
            InitializeComponent();

            _control = control;
            _audioProcessor.Bypass = true;

            _control.RegisterStreamHook(_audioProcessor);

            _audioRecorder = new SimpleRecorder(_audioProcessor);

            _control.PropertyChanged += PropertyChanged;

            InitializeGUI();
            ConfigureGUI();
        }

        #region INotifyPropertyChanged Handler

        private void PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "StartRadio":
                    ConfigureGUI();
                    break;
                case "StopRadio":

                    ConfigureGUI();
                    break;
            }
        }
        #endregion

        #region GUI Configuration

        private void InitializeGUI()
        {

        }

        private void ConfigureGUI()
        {
            if (_control.IsPlaying)
            {
                cbAudioRecord.Enabled = true;
                nudSeconds.Enabled = _audioRecorder.IsRecording ? false : true;
                cbAudioRecord.Checked = _audioRecorder.IsRecording ? true : false;
            }
            else
            {
                cbAudioRecord.Enabled = false;
                nudSeconds.Enabled = true;
                cbAudioRecord.Checked = false;

            }
        }

        #endregion

        #region Control Handlers
        private void cbAudioRecord_CheckedChanged(object sender, EventArgs e)
        {
            if (!_audioRecorder.IsRecording)
            {
                PrepareRecorder();

                try
                {
                    if (cbAudioRecord.Checked)
                    {
                        _audioRecorder.StartRecording();
                    }
                }
                catch
                {
                    _audioRecorder.StopRecording();
                    MessageBox.Show("Unable to start recording", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }
            else
            {
                if (_audioRecorder.IsRecording)
                {
                    _audioRecorder.StopRecording();
                }
            }

            ConfigureGUI();
        }

        private void btnAudioMgr_Click(object sender, EventArgs e)
        {
            if (_isFormShow) return;
            formSampleAudioMgr f = new formSampleAudioMgr();
            f.Disposed += F_Disposed;
            f.Show();
            _isFormShow = true;
        }

        private void F_Disposed(object sender, EventArgs e)
        {
            _isFormShow = false;
        }
        #endregion

        private void PrepareRecorder()
        {
            _audioRecorder.Frequency = _control.Frequency;
            _audioRecorder.Seconds = (int)nudSeconds.Value;
            _audioRecorder.SampleRate = _audioProcessor.SampleRate;
            _audioRecorder.Format = WavSampleFormat.PCM16;    // 语音识别的音频格式：PCM16 采样率16k 单音 
        }

        public void Close()
        {
            if (_audioRecorder.IsRecording)
            {
                _audioRecorder.StopRecording();
            }
        }

    }
}
