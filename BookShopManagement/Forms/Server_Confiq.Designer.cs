namespace BookShopManagement.Forms
{
    partial class Server_Confiq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server_Confiq));
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_conn = new System.Windows.Forms.Button();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.rbt_win = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_base = new System.Windows.Forms.TextBox();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(16, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(586, 47);
            this.panel6.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("PT Bold Heading", 14F);
            this.label12.Location = new System.Drawing.Point(202, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 34);
            this.label12.TabIndex = 16;
            this.label12.Text = "إعداد الإتصال بالسيرفر ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 347);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(598, 10);
            this.panel5.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 347);
            this.panel2.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(608, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 347);
            this.panel4.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 10);
            this.panel3.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.bt_conn);
            this.groupBox1.Controls.Add(this.pictureEdit1);
            this.groupBox1.Controls.Add(this.rbt_win);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_base);
            this.groupBox1.Controls.Add(this.txt_server);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_key);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.groupBox1.Location = new System.Drawing.Point(16, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 269);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات النظام ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_conn
            // 
            this.bt_conn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_conn.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_conn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_conn.FlatAppearance.BorderSize = 0;
            this.bt_conn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_conn.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.bt_conn.ForeColor = System.Drawing.Color.White;
            this.bt_conn.Image = ((System.Drawing.Image)(resources.GetObject("bt_conn.Image")));
            this.bt_conn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_conn.Location = new System.Drawing.Point(235, 225);
            this.bt_conn.Name = "bt_conn";
            this.bt_conn.Size = new System.Drawing.Size(162, 34);
            this.bt_conn.TabIndex = 75;
            this.bt_conn.Text = "تفعيل الإتصال";
            this.bt_conn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_conn.UseVisualStyleBackColor = false;
            this.bt_conn.Click += new System.EventHandler(this.bt_conn_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(22, 44);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(194, 215);
            this.pictureEdit1.TabIndex = 74;
            // 
            // rbt_win
            // 
            this.rbt_win.AutoSize = true;
            this.rbt_win.Checked = true;
            this.rbt_win.Location = new System.Drawing.Point(336, 133);
            this.rbt_win.Name = "rbt_win";
            this.rbt_win.Size = new System.Drawing.Size(140, 29);
            this.rbt_win.TabIndex = 73;
            this.rbt_win.TabStop = true;
            this.rbt_win.Text = "عبر خصائص الويندوز ";
            this.rbt_win.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label1.Location = new System.Drawing.Point(479, 133);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "نوع الإتصال :";
            // 
            // txt_base
            // 
            this.txt_base.BackColor = System.Drawing.Color.White;
            this.txt_base.Location = new System.Drawing.Point(235, 94);
            this.txt_base.Name = "txt_base";
            this.txt_base.ReadOnly = true;
            this.txt_base.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_base.Size = new System.Drawing.Size(241, 31);
            this.txt_base.TabIndex = 71;
            // 
            // txt_server
            // 
            this.txt_server.BackColor = System.Drawing.Color.White;
            this.txt_server.Location = new System.Drawing.Point(235, 44);
            this.txt_server.Name = "txt_server";
            this.txt_server.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_server.Size = new System.Drawing.Size(241, 31);
            this.txt_server.TabIndex = 70;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label14.Location = new System.Drawing.Point(481, 46);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(82, 25);
            this.label14.TabIndex = 68;
            this.label14.Text = "إسم السيرفر :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label6.Location = new System.Drawing.Point(479, 94);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 69;
            this.label6.Text = "قاعدة البيانات :";
            // 
            // txt_key
            // 
            this.txt_key.Font = new System.Drawing.Font("PT Bold Heading", 8F);
            this.txt_key.Location = new System.Drawing.Point(235, 172);
            this.txt_key.Name = "txt_key";
            this.txt_key.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_key.Size = new System.Drawing.Size(241, 26);
            this.txt_key.TabIndex = 67;
            this.txt_key.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label2.Location = new System.Drawing.Point(478, 171);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 66;
            this.label2.Text = "مفتاح التفعيل :";
            this.label2.Visible = false;
            // 
            // Server_Confiq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Server_Confiq";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server_Confiq";
            this.Load += new System.EventHandler(this.Server_Confiq_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_base;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.RadioButton rbt_win;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_conn;
        public System.Windows.Forms.TextBox txt_server;
    }
}