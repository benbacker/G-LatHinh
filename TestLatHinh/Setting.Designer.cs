namespace TestLatHinh
{
    partial class Setting
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
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMBoff = new System.Windows.Forms.RadioButton();
            this.rbMBon = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSoff = new System.Windows.Forms.RadioButton();
            this.rbSon = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(132, 69);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Setting";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMBoff);
            this.groupBox2.Controls.Add(this.rbMBon);
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 34);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Music Background";
            // 
            // rbMBoff
            // 
            this.rbMBoff.AutoSize = true;
            this.rbMBoff.Location = new System.Drawing.Point(74, 11);
            this.rbMBoff.Name = "rbMBoff";
            this.rbMBoff.Size = new System.Drawing.Size(45, 17);
            this.rbMBoff.TabIndex = 0;
            this.rbMBoff.TabStop = true;
            this.rbMBoff.Text = "OFF";
            this.rbMBoff.UseVisualStyleBackColor = true;
            // 
            // rbMBon
            // 
            this.rbMBon.AutoSize = true;
            this.rbMBon.Location = new System.Drawing.Point(7, 11);
            this.rbMBon.Name = "rbMBon";
            this.rbMBon.Size = new System.Drawing.Size(41, 17);
            this.rbMBon.TabIndex = 0;
            this.rbMBon.TabStop = true;
            this.rbMBon.Text = "ON";
            this.rbMBon.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSoff);
            this.groupBox1.Controls.Add(this.rbSon);
            this.groupBox1.Location = new System.Drawing.Point(206, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 34);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sound";
            // 
            // rbSoff
            // 
            this.rbSoff.AutoSize = true;
            this.rbSoff.Location = new System.Drawing.Point(79, 11);
            this.rbSoff.Name = "rbSoff";
            this.rbSoff.Size = new System.Drawing.Size(45, 17);
            this.rbSoff.TabIndex = 0;
            this.rbSoff.TabStop = true;
            this.rbSoff.Text = "OFF";
            this.rbSoff.UseVisualStyleBackColor = true;
            // 
            // rbSon
            // 
            this.rbSon.AutoSize = true;
            this.rbSon.Location = new System.Drawing.Point(7, 11);
            this.rbSon.Name = "rbSon";
            this.rbSon.Size = new System.Drawing.Size(41, 17);
            this.rbSon.TabIndex = 0;
            this.rbSon.TabStop = true;
            this.rbSon.Text = "ON";
            this.rbSon.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 127);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Name = "Setting";
            this.Text = "Setting";
            this.Shown += new System.EventHandler(this.Setting_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMBoff;
        private System.Windows.Forms.RadioButton rbMBon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSoff;
        private System.Windows.Forms.RadioButton rbSon;
    }
}