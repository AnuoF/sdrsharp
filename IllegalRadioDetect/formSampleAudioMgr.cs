using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDRSharp.IllegalRadioDetect
{
    public partial class formSampleAudioMgr : Form
    {
        private SimpleAudioPanel _simpleAudio;

        public formSampleAudioMgr()
        {
            InitializeComponent();

            _simpleAudio = new SimpleAudioPanel() { Dock = DockStyle.Fill };
            this.Controls.Add(_simpleAudio);
        }

        private void formSampleAudioMgr_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_simpleAudio.IsBusy)
            {
                MessageBox.Show("提示", "当前正在执行任务，请勿关闭窗口", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }



    }
}
