namespace SDRSharp.IllegalRadioDetect
{
    partial class SimpleAudioPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleAudioPanel));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPath = new System.Windows.Forms.ToolStripTextBox();
            this.btnSelectPath = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAsr = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsrResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Illegal = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtPath,
            this.btnSelectPath,
            this.toolStripSeparator1,
            this.btnAsr,
            this.toolStripSeparator2,
            this.btnSave,
            this.toolStripSeparator3,
            this.btnPlay});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(761, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "音频文件";
            // 
            // txtPath
            // 
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(200, 25);
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSelectPath.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectPath.Image")));
            this.btnSelectPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(36, 22);
            this.btnSelectPath.Text = "选择";
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAsr
            // 
            this.btnAsr.Image = ((System.Drawing.Image)(resources.GetObject("btnAsr.Image")));
            this.btnAsr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAsr.Name = "btnAsr";
            this.btnAsr.Size = new System.Drawing.Size(76, 22);
            this.btnAsr.Text = "批量识别";
            this.btnAsr.Click += new System.EventHandler(this.btnAsr_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 22);
            this.btnSave.Text = "批量入库";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Frequency,
            this.RecordTime,
            this.AsrResult,
            this.Illegal});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(761, 339);
            this.dataGridView1.TabIndex = 1;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "音频文件";
            this.FileName.Name = "FileName";
            // 
            // Frequency
            // 
            this.Frequency.DataPropertyName = "Frequency";
            this.Frequency.HeaderText = "中心频率";
            this.Frequency.Name = "Frequency";
            // 
            // RecordTime
            // 
            this.RecordTime.DataPropertyName = "RecordTime";
            this.RecordTime.HeaderText = "采集时间";
            this.RecordTime.Name = "RecordTime";
            // 
            // AsrResult
            // 
            this.AsrResult.DataPropertyName = "AsrResult";
            this.AsrResult.HeaderText = "识别内容";
            this.AsrResult.Name = "AsrResult";
            // 
            // Illegal
            // 
            this.Illegal.DataPropertyName = "Illegal";
            this.Illegal.HeaderText = "合法性";
            this.Illegal.Items.AddRange(new object[] {
            "合法",
            "非法"});
            this.Illegal.Name = "Illegal";
            // 
            // _progressBar1
            // 
            this._progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._progressBar1.Location = new System.Drawing.Point(0, 364);
            this._progressBar1.Name = "_progressBar1";
            this._progressBar1.Size = new System.Drawing.Size(761, 23);
            this._progressBar1.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(36, 22);
            this.btnPlay.Text = "播放";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // SimpleAudioPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this._progressBar1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SimpleAudioPanel";
            this.Size = new System.Drawing.Size(761, 387);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtPath;
        private System.Windows.Forms.ToolStripButton btnSelectPath;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAsr;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ProgressBar _progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsrResult;
        private System.Windows.Forms.DataGridViewComboBoxColumn Illegal;
        private System.Windows.Forms.ToolStripButton btnPlay;
    }
}
