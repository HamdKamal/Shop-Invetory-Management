namespace ShopInvetoryManagement.Forms
{
    partial class LOG_FORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOG_FORM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_NAME = new System.Windows.Forms.TextBox();
            this.TXT_PASS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CMBO_TYPE = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BT_OK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 57);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 76;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PT Bold Heading", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(131, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "أعـمال لنـــــج التـــجـــارية المـــحــــدودة";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(249, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "إسم المستخدم ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PT Bold Heading", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(128, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "الرجاء تسجيل الدخول ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(265, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "كلمة المرور ";
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_NAME.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.TXT_NAME.Location = new System.Drawing.Point(16, 101);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_NAME.Size = new System.Drawing.Size(313, 31);
            this.TXT_NAME.TabIndex = 1;
            // 
            // TXT_PASS
            // 
            this.TXT_PASS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_PASS.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.TXT_PASS.Location = new System.Drawing.Point(16, 165);
            this.TXT_PASS.Name = "TXT_PASS";
            this.TXT_PASS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_PASS.Size = new System.Drawing.Size(313, 31);
            this.TXT_PASS.TabIndex = 2;
            this.TXT_PASS.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(33, 669);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(385, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "&Copyrights © 2019. All rights Reserved By Aim Tech";
            // 
            // CMBO_TYPE
            // 
            this.CMBO_TYPE.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.CMBO_TYPE.FormattingEnabled = true;
            this.CMBO_TYPE.Items.AddRange(new object[] {
            "مدير النظام",
            "الموظف"});
            this.CMBO_TYPE.Location = new System.Drawing.Point(16, 37);
            this.CMBO_TYPE.Name = "CMBO_TYPE";
            this.CMBO_TYPE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CMBO_TYPE.Size = new System.Drawing.Size(313, 31);
            this.CMBO_TYPE.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(249, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "نوع  المستخدم ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CMBO_TYPE);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TXT_NAME);
            this.panel2.Controls.Add(this.TXT_PASS);
            this.panel2.Location = new System.Drawing.Point(47, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 212);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(117, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // BT_OK
            // 
            this.BT_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_OK.BackColor = System.Drawing.Color.Orange;
            this.BT_OK.FlatAppearance.BorderSize = 0;
            this.BT_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_OK.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.BT_OK.ForeColor = System.Drawing.Color.Black;
            this.BT_OK.Image = ((System.Drawing.Image)(resources.GetObject("BT_OK.Image")));
            this.BT_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_OK.Location = new System.Drawing.Point(141, 541);
            this.BT_OK.Name = "BT_OK";
            this.BT_OK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BT_OK.Size = new System.Drawing.Size(141, 39);
            this.BT_OK.TabIndex = 9;
            this.BT_OK.Text = "تسجيل الدخول ";
            this.BT_OK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_OK.UseVisualStyleBackColor = false;
            this.BT_OK.Click += new System.EventHandler(this.BT_OK_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(36, 597);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(360, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "&Copyrights © 2019. All rights Reserved By Aim Tech";
            // 
            // LOG_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 618);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BT_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOG_FORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG_FORM";
            this.Load += new System.EventHandler(this.LOG_FORM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_NAME;
        private System.Windows.Forms.TextBox TXT_PASS;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox CMBO_TYPE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BT_OK;
        private System.Windows.Forms.Label label7;
    }
}