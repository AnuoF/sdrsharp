﻿namespace SDRSharp.IllegalRadioDetect
{
    partial class formSampleAudioMgr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // formSampleAudioMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 456);
            this.MinimizeBox = false;
            this.Name = "formSampleAudioMgr";
            this.Text = "音频文件管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formSampleAudioMgr_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
    }
}