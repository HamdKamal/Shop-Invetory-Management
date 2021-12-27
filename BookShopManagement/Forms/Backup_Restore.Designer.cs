namespace BookShopManagement.Forms
{
    partial class Backup_Restore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup_Restore));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_GET = new System.Windows.Forms.Button();
            this.BT_BAC = new System.Windows.Forms.Button();
            this.TXT_PATH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BT_SET = new System.Windows.Forms.Button();
            this.BT_RES = new System.Windows.Forms.Button();
            this.TXT_PATH1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 526);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(784, 10);
            this.panel5.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 526);
            this.panel2.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 516);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(794, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 526);
            this.panel4.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 10);
            this.panel3.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.BT_GET);
            this.groupBox1.Controls.Add(this.BT_BAC);
            this.groupBox1.Controls.Add(this.TXT_PATH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.groupBox1.Location = new System.Drawing.Point(15, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 217);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نسخ قاعدة البيانات";
            // 
            // BT_GET
            // 
            this.BT_GET.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_GET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_GET.Font = new System.Drawing.Font("PT Bold Heading", 11F);
            this.BT_GET.ForeColor = System.Drawing.Color.Black;
            this.BT_GET.Location = new System.Drawing.Point(66, 84);
            this.BT_GET.Name = "BT_GET";
            this.BT_GET.Size = new System.Drawing.Size(46, 31);
            this.BT_GET.TabIndex = 77;
            this.BT_GET.Text = "...";
            this.BT_GET.UseVisualStyleBackColor = false;
            this.BT_GET.Click += new System.EventHandler(this.BT_GET_Click);
            // 
            // BT_BAC
            // 
            this.BT_BAC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_BAC.BackColor = System.Drawing.Color.SeaGreen;
            this.BT_BAC.FlatAppearance.BorderSize = 0;
            this.BT_BAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_BAC.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.BT_BAC.ForeColor = System.Drawing.Color.White;
            this.BT_BAC.Image = ((System.Drawing.Image)(resources.GetObject("BT_BAC.Image")));
            this.BT_BAC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_BAC.Location = new System.Drawing.Point(66, 157);
            this.BT_BAC.Name = "BT_BAC";
            this.BT_BAC.Size = new System.Drawing.Size(141, 38);
            this.BT_BAC.TabIndex = 76;
            this.BT_BAC.Text = "عمل النسخة";
            this.BT_BAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_BAC.UseVisualStyleBackColor = false;
            this.BT_BAC.Click += new System.EventHandler(this.BT_BAC_Click);
            // 
            // TXT_PATH
            // 
            this.TXT_PATH.Location = new System.Drawing.Point(118, 84);
            this.TXT_PATH.Name = "TXT_PATH";
            this.TXT_PATH.ReadOnly = true;
            this.TXT_PATH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_PATH.Size = new System.Drawing.Size(546, 31);
            this.TXT_PATH.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label8.Location = new System.Drawing.Point(508, 47);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(239, 25);
            this.label8.TabIndex = 74;
            this.label8.Text = "الرجاء تحديد المسار لتخزين قاعدة البيانات ...";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(15, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(774, 55);
            this.panel6.TabIndex = 48;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("PT Bold Heading", 14F);
            this.label12.Location = new System.Drawing.Point(294, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 34);
            this.label12.TabIndex = 16;
            this.label12.Text = "إدارة قاعدة البيانات ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.BT_SET);
            this.groupBox2.Controls.Add(this.BT_RES);
            this.groupBox2.Controls.Add(this.TXT_PATH1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.groupBox2.Location = new System.Drawing.Point(15, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 221);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "إسترجاع  قاعدة البيانات";
            // 
            // BT_SET
            // 
            this.BT_SET.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_SET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SET.Font = new System.Drawing.Font("PT Bold Heading", 11F);
            this.BT_SET.ForeColor = System.Drawing.Color.Black;
            this.BT_SET.Location = new System.Drawing.Point(66, 84);
            this.BT_SET.Name = "BT_SET";
            this.BT_SET.Size = new System.Drawing.Size(46, 31);
            this.BT_SET.TabIndex = 77;
            this.BT_SET.Text = "...";
            this.BT_SET.UseVisualStyleBackColor = false;
            this.BT_SET.Click += new System.EventHandler(this.BT_SET_Click);
            // 
            // BT_RES
            // 
            this.BT_RES.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_RES.BackColor = System.Drawing.Color.SeaGreen;
            this.BT_RES.FlatAppearance.BorderSize = 0;
            this.BT_RES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_RES.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.BT_RES.ForeColor = System.Drawing.Color.White;
            this.BT_RES.Image = ((System.Drawing.Image)(resources.GetObject("BT_RES.Image")));
            this.BT_RES.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_RES.Location = new System.Drawing.Point(66, 159);
            this.BT_RES.Name = "BT_RES";
            this.BT_RES.Size = new System.Drawing.Size(141, 38);
            this.BT_RES.TabIndex = 76;
            this.BT_RES.Text = "إسترجاع النسخة";
            this.BT_RES.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_RES.UseVisualStyleBackColor = false;
            this.BT_RES.Click += new System.EventHandler(this.BT_RES_Click);
            // 
            // TXT_PATH1
            // 
            this.TXT_PATH1.Location = new System.Drawing.Point(118, 84);
            this.TXT_PATH1.Name = "TXT_PATH1";
            this.TXT_PATH1.ReadOnly = true;
            this.TXT_PATH1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_PATH1.Size = new System.Drawing.Size(546, 31);
            this.TXT_PATH1.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label1.Location = new System.Drawing.Point(457, 46);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "الرجاء إختيار المسار الذي يحتوي على قاعدة البيانات ...";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Backup_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Backup_Restore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup_Restore";
            this.Load += new System.EventHandler(this.Backup_Restore_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button BT_GET;
        private System.Windows.Forms.Button BT_BAC;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button BT_SET;
        private System.Windows.Forms.Button BT_RES;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TXT_PATH;
        public System.Windows.Forms.TextBox TXT_PATH1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.PictureBox pictureBox2;
    }
}