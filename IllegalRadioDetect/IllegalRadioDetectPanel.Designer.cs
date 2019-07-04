namespace SDRSharp.IllegalRadioDetect
{
    partial class IllegalRadioDetectPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbAudioRecord = new System.Windows.Forms.CheckBox();
            this.btnAudioMgr = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAudioRecord
            // 
            this.cbAudioRecord.AutoSize = true;
            this.cbAudioRecord.Location = new System.Drawing.Point(8, 45);
            this.cbAudioRecord.Name = "cbAudioRecord";
            this.cbAudioRecord.Size = new System.Drawing.Size(96, 16);
            this.cbAudioRecord.TabIndex = 0;
            this.cbAudioRecord.Text = "采集音频样本";
            this.cbAudioRecord.UseVisualStyleBackColor = true;
            this.cbAudioRecord.CheckedChanged += new System.EventHandler(this.cbAudioRecord_CheckedChanged);
            // 
            // btnAudioMgr
            // 
            this.btnAudioMgr.Location = new System.Drawing.Point(110, 38);
            this.btnAudioMgr.Name = "btnAudioMgr";
            this.btnAudioMgr.Size = new System.Drawing.Size(101, 23);
            this.btnAudioMgr.TabIndex = 1;
            this.btnAudioMgr.Text = "样本数据管理";
            this.btnAudioMgr.UseVisualStyleBackColor = true;
            this.btnAudioMgr.Click += new System.EventHandler(this.btnAudioMgr_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "检测";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(41, 18);
            this.nudSeconds.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.nudSeconds.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(45, 21);
            this.nudSeconds.TabIndex = 2;
            this.nudSeconds.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "时长";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "秒";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAudioRecord);
            this.groupBox1.Controls.Add(this.btnAudioMgr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudSeconds);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 66);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "音频采集";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 252);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "黑广播检测";
            // 
            // IllegalRadioDetectPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IllegalRadioDetectPanel";
            this.Size = new System.Drawing.Size(362, 318);
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAudioMgr;
        private System.Windows.Forms.CheckBox cbAudioRecord;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
