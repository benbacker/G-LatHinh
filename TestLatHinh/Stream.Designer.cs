namespace TestLatHinh
{
    partial class Stream
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
            this.components = new System.ComponentModel.Container();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.textBoxStreamingUrl = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarBuffer = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelBuffered = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPlay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSavePL = new System.Windows.Forms.Button();
            this.trackWave = new System.Windows.Forms.TrackBar();
            this.btnDeleteall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWave)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(19, 145);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(100, 28);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Start";
            this.buttonPlay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // textBoxStreamingUrl
            // 
            this.textBoxStreamingUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStreamingUrl.Location = new System.Drawing.Point(129, 15);
            this.textBoxStreamingUrl.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStreamingUrl.Name = "textBoxStreamingUrl";
            this.textBoxStreamingUrl.Size = new System.Drawing.Size(451, 22);
            this.textBoxStreamingUrl.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Bài";
            // 
            // progressBarBuffer
            // 
            this.progressBarBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarBuffer.Location = new System.Drawing.Point(129, 48);
            this.progressBarBuffer.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarBuffer.Name = "progressBarBuffer";
            this.progressBarBuffer.Size = new System.Drawing.Size(757, 28);
            this.progressBarBuffer.TabIndex = 3;
            this.progressBarBuffer.Click += new System.EventHandler(this.progressBarBuffer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buffered:";
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(128, 145);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(100, 28);
            this.buttonPause.TabIndex = 5;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(238, 145);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(100, 28);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelBuffered
            // 
            this.labelBuffered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBuffered.AutoSize = true;
            this.labelBuffered.Location = new System.Drawing.Point(895, 55);
            this.labelBuffered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBuffered.Name = "labelBuffered";
            this.labelBuffered.Size = new System.Drawing.Size(35, 17);
            this.labelBuffered.TabIndex = 7;
            this.labelBuffered.Text = "0.0s";
            this.labelBuffered.Click += new System.EventHandler(this.labelBuffered_Click);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(16, 90);
            this.labelVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(71, 17);
            this.labelVolume.TabIndex = 8;
            this.labelVolume.Text = "Âm lượng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colLink});
            this.dataGridView1.Location = new System.Drawing.Point(16, 204);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(727, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên Bài";
            this.colName.Name = "colName";
            // 
            // colLink
            // 
            this.colLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLink.HeaderText = "Link";
            this.colLink.Name = "colLink";
            this.colLink.Visible = false;
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvSearch.Location = new System.Drawing.Point(127, 48);
            this.dgvSearch.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.Size = new System.Drawing.Size(452, 150);
            this.dgvSearch.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Bài";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Link";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(605, 12);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(117, 28);
            this.btnPlay.TabIndex = 13;
            this.btnPlay.Text = "Tìm trên NCT";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thêm vào Playlist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSavePL
            // 
            this.btnSavePL.FlatAppearance.BorderSize = 0;
            this.btnSavePL.Location = new System.Drawing.Point(751, 204);
            this.btnSavePL.Margin = new System.Windows.Forms.Padding(4);
            this.btnSavePL.Name = "btnSavePL";
            this.btnSavePL.Size = new System.Drawing.Size(136, 28);
            this.btnSavePL.TabIndex = 14;
            this.btnSavePL.Text = "Lưu PlayList";
            this.btnSavePL.UseVisualStyleBackColor = true;
            this.btnSavePL.Click += new System.EventHandler(this.btnSavePL_Click);
            // 
            // trackWave
            // 
            this.trackWave.Location = new System.Drawing.Point(129, 82);
            this.trackWave.Name = "trackWave";
            this.trackWave.Size = new System.Drawing.Size(268, 56);
            this.trackWave.TabIndex = 15;
            this.trackWave.Value = 5;
            this.trackWave.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnDeleteall
            // 
            this.btnDeleteall.Location = new System.Drawing.Point(751, 237);
            this.btnDeleteall.Name = "btnDeleteall";
            this.btnDeleteall.Size = new System.Drawing.Size(136, 28);
            this.btnDeleteall.TabIndex = 16;
            this.btnDeleteall.Text = "Xoá toàn bộ PlayList";
            this.btnDeleteall.UseVisualStyleBackColor = true;
            this.btnDeleteall.Click += new System.EventHandler(this.btnDeleteall_Click);
            // 
            // Stream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 404);
            this.Controls.Add(this.btnDeleteall);
            this.Controls.Add(this.trackWave);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.btnSavePL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelBuffered);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarBuffer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStreamingUrl);
            this.Controls.Add(this.buttonPlay);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stream";
            this.Text = "Nghe nhạc Online";
            this.Load += new System.EventHandler(this.Stream_Load);
            this.Click += new System.EventHandler(this.Stream_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TextBox textBoxStreamingUrl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarBuffer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelBuffered;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSavePL;
        private System.Windows.Forms.TrackBar trackWave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnDeleteall;
    }
}