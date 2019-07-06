namespace SDRSharp2
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.playStopButton = new System.Windows.Forms.Button();
            this.configureSourceButton = new System.Windows.Forms.Button();
            this.iqSourceComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panSplitContainer = new System.Windows.Forms.SplitContainer();
            this.spectrumAnalyzer = new SDRSharp.PanView.SpectrumAnalyzer();
            this.waterfall = new SDRSharp.PanView.Waterfall();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panSplitContainer)).BeginInit();
            this.panSplitContainer.Panel1.SuspendLayout();
            this.panSplitContainer.Panel2.SuspendLayout();
            this.panSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.playStopButton);
            this.panel1.Controls.Add(this.configureSourceButton);
            this.panel1.Controls.Add(this.iqSourceComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 44);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 36;
            this.label2.Text = "VFO";
            // 
            // playStopButton
            // 
            this.playStopButton.Location = new System.Drawing.Point(6, 10);
            this.playStopButton.Name = "playStopButton";
            this.playStopButton.Size = new System.Drawing.Size(60, 27);
            this.playStopButton.TabIndex = 32;
            this.playStopButton.Text = "Play";
            // 
            // configureSourceButton
            // 
            this.configureSourceButton.FlatAppearance.BorderSize = 0;
            this.configureSourceButton.Location = new System.Drawing.Point(299, 10);
            this.configureSourceButton.Name = "configureSourceButton";
            this.configureSourceButton.Size = new System.Drawing.Size(84, 27);
            this.configureSourceButton.TabIndex = 34;
            this.configureSourceButton.Text = "Configure";
            this.configureSourceButton.UseVisualStyleBackColor = true;
            // 
            // iqSourceComboBox
            // 
            this.iqSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iqSourceComboBox.DropDownWidth = 135;
            this.iqSourceComboBox.FormattingEnabled = true;
            this.iqSourceComboBox.Location = new System.Drawing.Point(74, 12);
            this.iqSourceComboBox.Name = "iqSourceComboBox";
            this.iqSourceComboBox.Size = new System.Drawing.Size(218, 20);
            this.iqSourceComboBox.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panSplitContainer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 726);
            this.panel2.TabIndex = 1;
            // 
            // panSplitContainer
            // 
            this.panSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.panSplitContainer.Name = "panSplitContainer";
            this.panSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // panSplitContainer.Panel1
            // 
            this.panSplitContainer.Panel1.Controls.Add(this.spectrumAnalyzer);
            this.panSplitContainer.Panel1MinSize = 10;
            // 
            // panSplitContainer.Panel2
            // 
            this.panSplitContainer.Panel2.Controls.Add(this.waterfall);
            this.panSplitContainer.Panel2MinSize = 10;
            this.panSplitContainer.Size = new System.Drawing.Size(474, 726);
            this.panSplitContainer.SplitterDistance = 231;
            this.panSplitContainer.TabIndex = 14;
            // 
            // spectrumAnalyzer
            // 
            this.spectrumAnalyzer.Attack = 0.9D;
            this.spectrumAnalyzer.AutoSize = true;
            this.spectrumAnalyzer.BandType = SDRSharp.PanView.BandType.Center;
            this.spectrumAnalyzer.CenterFrequency = ((long)(0));
            this.spectrumAnalyzer.Decay = 0.3D;
            this.spectrumAnalyzer.DisplayOffset = 0;
            this.spectrumAnalyzer.DisplayRange = 130;
            this.spectrumAnalyzer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spectrumAnalyzer.EnableFilter = true;
            this.spectrumAnalyzer.FilterBandwidth = 10000;
            this.spectrumAnalyzer.FilterOffset = 100;
            this.spectrumAnalyzer.Frequency = ((long)(0));
            this.spectrumAnalyzer.Location = new System.Drawing.Point(0, 0);
            this.spectrumAnalyzer.MarkPeaks = false;
            this.spectrumAnalyzer.Name = "spectrumAnalyzer";
            this.spectrumAnalyzer.ShowMaxLine = false;
            this.spectrumAnalyzer.Size = new System.Drawing.Size(474, 231);
            this.spectrumAnalyzer.SpectrumWidth = 48000;
            this.spectrumAnalyzer.StatusText = null;
            this.spectrumAnalyzer.StepSize = 1000;
            this.spectrumAnalyzer.TabIndex = 0;
            this.spectrumAnalyzer.UseSmoothing = true;
            this.spectrumAnalyzer.UseSnap = false;
            this.spectrumAnalyzer.Zoom = 0;
            // 
            // waterfall
            // 
            this.waterfall.Attack = 0.9D;
            this.waterfall.AutoSize = true;
            this.waterfall.BandType = SDRSharp.PanView.BandType.Center;
            this.waterfall.CenterFrequency = ((long)(0));
            this.waterfall.Contrast = 0;
            this.waterfall.Decay = 0.5D;
            this.waterfall.DisplayOffset = 0;
            this.waterfall.DisplayRange = 130;
            this.waterfall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterfall.FilterBandwidth = 10000;
            this.waterfall.FilterOffset = 0;
            this.waterfall.Frequency = ((long)(0));
            this.waterfall.Location = new System.Drawing.Point(0, 0);
            this.waterfall.Name = "waterfall";
            this.waterfall.Size = new System.Drawing.Size(474, 491);
            this.waterfall.SpectrumWidth = 48000;
            this.waterfall.StepSize = 0;
            this.waterfall.TabIndex = 0;
            this.waterfall.TimestampInterval = 100;
            this.waterfall.UseSmoothing = true;
            this.waterfall.UseSnap = false;
            this.waterfall.UseTimestamps = false;
            this.waterfall.Zoom = 0;
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 770);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panSplitContainer.Panel1.ResumeLayout(false);
            this.panSplitContainer.Panel1.PerformLayout();
            this.panSplitContainer.Panel2.ResumeLayout(false);
            this.panSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panSplitContainer)).EndInit();
            this.panSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button playStopButton;
        private System.Windows.Forms.Button configureSourceButton;
        private System.Windows.Forms.ComboBox iqSourceComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer panSplitContainer;
        private SDRSharp.PanView.SpectrumAnalyzer spectrumAnalyzer;
        private SDRSharp.PanView.Waterfall waterfall;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}