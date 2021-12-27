namespace BookShopManagement.Forms
{
    partial class Form_FinishOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FinishOrder));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DATE_BILL = new DevExpress.XtraEditors.DateEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.TXT_NOTE = new System.Windows.Forms.TextBox();
            this.TXT_EMBLOYEE = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_REPORT = new System.Windows.Forms.Button();
            this.BT_EXIT = new System.Windows.Forms.Button();
            this.BT_CANCEL = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LBL_DATE = new System.Windows.Forms.Label();
            this.LBL_BILL_NO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_BILL_PRICE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_TOTAL_PRICE = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.BT_PRINT = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_DEL = new System.Windows.Forms.Button();
            this.BT_PAY = new System.Windows.Forms.Button();
            this.TXT_BILLS_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_BARCODE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_BRD_QUAN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TXT_TOTAL_PRICE = new System.Windows.Forms.TextBox();
            this.TXT_NEED_QUAN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TXT_PRD_NAME = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.TXT_SELLING_PRICE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.COMBO_CUST = new System.Windows.Forms.ComboBox();
            this.TXT_NAME = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.RAD_NAME = new System.Windows.Forms.RadioButton();
            this.RAD_CUST = new System.Windows.Forms.RadioButton();
            this.COMBO_SALE_TYPE = new System.Windows.Forms.ComboBox();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sEARCHPRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEARCH_PRODUCTTableAdapter = new ShopInvetoryManagement.Lang_DataBaseDataSetTableAdapters.SEARCH_PRODUCTTableAdapter();
            this.COMBO_SEARCH = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATE_BILL.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATE_BILL.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHPRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMBO_SEARCH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Controls.Add(this.panel12);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 391);
            this.panel5.Name = "panel5";
            this.panel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel5.Size = new System.Drawing.Size(1088, 229);
            this.panel5.TabIndex = 6;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DATE_BILL);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.TXT_NOTE);
            this.panel2.Controls.Add(this.TXT_EMBLOYEE);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(405, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 155);
            this.panel2.TabIndex = 17;
            // 
            // DATE_BILL
            // 
            this.DATE_BILL.EditValue = null;
            this.DATE_BILL.Location = new System.Drawing.Point(17, 98);
            this.DATE_BILL.Name = "DATE_BILL";
            this.DATE_BILL.Properties.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 12F);
            this.DATE_BILL.Properties.Appearance.Options.UseFont = true;
            this.DATE_BILL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DATE_BILL.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DATE_BILL.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.DATE_BILL.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.DATE_BILL.Size = new System.Drawing.Size(189, 34);
            this.DATE_BILL.TabIndex = 96;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(578, 8);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(51, 17);
            this.label15.TabIndex = 69;
            this.label15.Text = "الوصف :";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // TXT_NOTE
            // 
            this.TXT_NOTE.Font = new System.Drawing.Font("Simplified Arabic", 12F);
            this.TXT_NOTE.Location = new System.Drawing.Point(17, 9);
            this.TXT_NOTE.Multiline = true;
            this.TXT_NOTE.Name = "TXT_NOTE";
            this.TXT_NOTE.ReadOnly = true;
            this.TXT_NOTE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_NOTE.Size = new System.Drawing.Size(561, 62);
            this.TXT_NOTE.TabIndex = 68;
            // 
            // TXT_EMBLOYEE
            // 
            this.TXT_EMBLOYEE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_EMBLOYEE.Font = new System.Drawing.Font("Simplified Arabic", 12F);
            this.TXT_EMBLOYEE.Location = new System.Drawing.Point(389, 100);
            this.TXT_EMBLOYEE.Name = "TXT_EMBLOYEE";
            this.TXT_EMBLOYEE.ReadOnly = true;
            this.TXT_EMBLOYEE.Size = new System.Drawing.Size(189, 34);
            this.TXT_EMBLOYEE.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(204, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "تاريخ الفاتورة :";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(581, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "إسم الموظف :";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(1078, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 219);
            this.panel11.TabIndex = 38;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(399, 219);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(689, 10);
            this.panel12.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BT_REPORT);
            this.panel1.Controls.Add(this.BT_EXIT);
            this.panel1.Controls.Add(this.BT_CANCEL);
            this.panel1.Location = new System.Drawing.Point(405, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 54);
            this.panel1.TabIndex = 16;
            // 
            // BT_REPORT
            // 
            this.BT_REPORT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_REPORT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BT_REPORT.Enabled = false;
            this.BT_REPORT.FlatAppearance.BorderSize = 0;
            this.BT_REPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_REPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BT_REPORT.ForeColor = System.Drawing.Color.White;
            this.BT_REPORT.Image = ((System.Drawing.Image)(resources.GetObject("BT_REPORT.Image")));
            this.BT_REPORT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_REPORT.Location = new System.Drawing.Point(273, 7);
            this.BT_REPORT.Name = "BT_REPORT";
            this.BT_REPORT.Size = new System.Drawing.Size(128, 38);
            this.BT_REPORT.TabIndex = 41;
            this.BT_REPORT.Text = "فاتورة كبيرة";
            this.BT_REPORT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_REPORT.UseVisualStyleBackColor = false;
            this.BT_REPORT.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BT_EXIT
            // 
            this.BT_EXIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_EXIT.BackColor = System.Drawing.Color.Red;
            this.BT_EXIT.FlatAppearance.BorderSize = 0;
            this.BT_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BT_EXIT.ForeColor = System.Drawing.Color.White;
            this.BT_EXIT.Image = ((System.Drawing.Image)(resources.GetObject("BT_EXIT.Image")));
            this.BT_EXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_EXIT.Location = new System.Drawing.Point(123, 8);
            this.BT_EXIT.Name = "BT_EXIT";
            this.BT_EXIT.Size = new System.Drawing.Size(129, 37);
            this.BT_EXIT.TabIndex = 36;
            this.BT_EXIT.Text = "خروج";
            this.BT_EXIT.UseVisualStyleBackColor = false;
            this.BT_EXIT.Click += new System.EventHandler(this.BT_EXIT_Click);
            // 
            // BT_CANCEL
            // 
            this.BT_CANCEL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_CANCEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BT_CANCEL.Enabled = false;
            this.BT_CANCEL.FlatAppearance.BorderSize = 0;
            this.BT_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BT_CANCEL.ForeColor = System.Drawing.Color.White;
            this.BT_CANCEL.Image = ((System.Drawing.Image)(resources.GetObject("BT_CANCEL.Image")));
            this.BT_CANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_CANCEL.Location = new System.Drawing.Point(422, 7);
            this.BT_CANCEL.Name = "BT_CANCEL";
            this.BT_CANCEL.Size = new System.Drawing.Size(126, 37);
            this.BT_CANCEL.TabIndex = 37;
            this.BT_CANCEL.Text = "الغاء الفاتورة";
            this.BT_CANCEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_CANCEL.UseVisualStyleBackColor = false;
            this.BT_CANCEL.Click += new System.EventHandler(this.BT_CANCEL_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.LBL_DATE);
            this.panel7.Controls.Add(this.LBL_BILL_NO);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.LBL_BILL_PRICE);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.LBL_TOTAL_PRICE);
            this.panel7.Controls.Add(this.label22);
            this.panel7.Controls.Add(this.BT_PRINT);
            this.panel7.Controls.Add(this.panel20);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.BT_DEL);
            this.panel7.Controls.Add(this.BT_PAY);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(399, 229);
            this.panel7.TabIndex = 4;
            // 
            // LBL_DATE
            // 
            this.LBL_DATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_DATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LBL_DATE.ForeColor = System.Drawing.Color.Black;
            this.LBL_DATE.Location = new System.Drawing.Point(17, 189);
            this.LBL_DATE.Name = "LBL_DATE";
            this.LBL_DATE.Size = new System.Drawing.Size(113, 25);
            this.LBL_DATE.TabIndex = 48;
            this.LBL_DATE.Text = "ج \\س";
            this.LBL_DATE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_BILL_NO
            // 
            this.LBL_BILL_NO.BackColor = System.Drawing.Color.DarkGray;
            this.LBL_BILL_NO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_BILL_NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LBL_BILL_NO.ForeColor = System.Drawing.Color.Black;
            this.LBL_BILL_NO.Location = new System.Drawing.Point(119, 123);
            this.LBL_BILL_NO.Name = "LBL_BILL_NO";
            this.LBL_BILL_NO.Size = new System.Drawing.Size(144, 25);
            this.LBL_BILL_NO.TabIndex = 47;
            this.LBL_BILL_NO.Text = "0.00";
            this.LBL_BILL_NO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(72, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "ج \\س";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_BILL_PRICE
            // 
            this.LBL_BILL_PRICE.BackColor = System.Drawing.Color.Yellow;
            this.LBL_BILL_PRICE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_BILL_PRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LBL_BILL_PRICE.ForeColor = System.Drawing.Color.Black;
            this.LBL_BILL_PRICE.Location = new System.Drawing.Point(119, 151);
            this.LBL_BILL_PRICE.Name = "LBL_BILL_PRICE";
            this.LBL_BILL_PRICE.Size = new System.Drawing.Size(144, 25);
            this.LBL_BILL_PRICE.TabIndex = 45;
            this.LBL_BILL_PRICE.Text = "0.00";
            this.LBL_BILL_PRICE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(136, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "التاريخ :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_TOTAL_PRICE
            // 
            this.LBL_TOTAL_PRICE.BackColor = System.Drawing.Color.DarkKhaki;
            this.LBL_TOTAL_PRICE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_TOTAL_PRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LBL_TOTAL_PRICE.ForeColor = System.Drawing.Color.Black;
            this.LBL_TOTAL_PRICE.Location = new System.Drawing.Point(0, 17);
            this.LBL_TOTAL_PRICE.Name = "LBL_TOTAL_PRICE";
            this.LBL_TOTAL_PRICE.Size = new System.Drawing.Size(90, 31);
            this.LBL_TOTAL_PRICE.TabIndex = 41;
            this.LBL_TOTAL_PRICE.Text = "0.00";
            this.LBL_TOTAL_PRICE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_TOTAL_PRICE.Click += new System.EventHandler(this.LBL_TOTAL_PRICE_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(311, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 25);
            this.label22.TabIndex = 42;
            this.label22.Text = "الإجمالي :";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BT_PRINT
            // 
            this.BT_PRINT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_PRINT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BT_PRINT.Enabled = false;
            this.BT_PRINT.FlatAppearance.BorderSize = 0;
            this.BT_PRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_PRINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BT_PRINT.ForeColor = System.Drawing.Color.White;
            this.BT_PRINT.Image = ((System.Drawing.Image)(resources.GetObject("BT_PRINT.Image")));
            this.BT_PRINT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_PRINT.Location = new System.Drawing.Point(136, 68);
            this.BT_PRINT.Name = "BT_PRINT";
            this.BT_PRINT.Size = new System.Drawing.Size(128, 31);
            this.BT_PRINT.TabIndex = 40;
            this.BT_PRINT.Text = " طباعة الفاتورة";
            this.BT_PRINT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_PRINT.UseVisualStyleBackColor = false;
            this.BT_PRINT.Click += new System.EventHandler(this.BT_PRINT_Click);
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel20.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel20.Location = new System.Drawing.Point(0, 217);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(397, 10);
            this.panel20.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(269, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "قيمة الفاتورة :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(269, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "رقم الفاتورة :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BT_DEL
            // 
            this.BT_DEL.BackColor = System.Drawing.Color.OrangeRed;
            this.BT_DEL.Enabled = false;
            this.BT_DEL.FlatAppearance.BorderSize = 0;
            this.BT_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_DEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BT_DEL.ForeColor = System.Drawing.Color.White;
            this.BT_DEL.Image = ((System.Drawing.Image)(resources.GetObject("BT_DEL.Image")));
            this.BT_DEL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_DEL.Location = new System.Drawing.Point(3, 67);
            this.BT_DEL.Name = "BT_DEL";
            this.BT_DEL.Size = new System.Drawing.Size(128, 31);
            this.BT_DEL.TabIndex = 2;
            this.BT_DEL.Text = " حذف المنتج";
            this.BT_DEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_DEL.UseVisualStyleBackColor = false;
            this.BT_DEL.Click += new System.EventHandler(this.BT_DEL_Click);
            // 
            // BT_PAY
            // 
            this.BT_PAY.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_PAY.Enabled = false;
            this.BT_PAY.FlatAppearance.BorderSize = 0;
            this.BT_PAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_PAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BT_PAY.ForeColor = System.Drawing.Color.White;
            this.BT_PAY.Image = ((System.Drawing.Image)(resources.GetObject("BT_PAY.Image")));
            this.BT_PAY.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_PAY.Location = new System.Drawing.Point(269, 69);
            this.BT_PAY.Name = "BT_PAY";
            this.BT_PAY.Size = new System.Drawing.Size(119, 31);
            this.BT_PAY.TabIndex = 2;
            this.BT_PAY.Text = "شراء";
            this.BT_PAY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_PAY.UseVisualStyleBackColor = false;
            this.BT_PAY.Click += new System.EventHandler(this.BT_PAY_Click);
            // 
            // TXT_BILLS_ID
            // 
            this.TXT_BILLS_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_BILLS_ID.Font = new System.Drawing.Font("Simplified Arabic", 9F);
            this.TXT_BILLS_ID.Location = new System.Drawing.Point(107, 185);
            this.TXT_BILLS_ID.Name = "TXT_BILLS_ID";
            this.TXT_BILLS_ID.ReadOnly = true;
            this.TXT_BILLS_ID.Size = new System.Drawing.Size(99, 27);
            this.TXT_BILLS_ID.TabIndex = 9;
            this.TXT_BILLS_ID.Text = "0";
            this.TXT_BILLS_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(28, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "رقم الفاتورة :";
            // 
            // TXT_BARCODE
            // 
            this.TXT_BARCODE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_BARCODE.Font = new System.Drawing.Font("Simplified Arabic", 12F);
            this.TXT_BARCODE.Location = new System.Drawing.Point(476, 185);
            this.TXT_BARCODE.Name = "TXT_BARCODE";
            this.TXT_BARCODE.ReadOnly = true;
            this.TXT_BARCODE.Size = new System.Drawing.Size(189, 34);
            this.TXT_BARCODE.TabIndex = 11;
            this.TXT_BARCODE.TextChanged += new System.EventHandler(this.TXT_BARCODE_TextChanged);
            this.TXT_BARCODE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_BARCODE_KeyDown);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(390, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "بار كود المنتج :";
            // 
            // TXT_BRD_QUAN
            // 
            this.TXT_BRD_QUAN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_BRD_QUAN.Font = new System.Drawing.Font("Simplified Arabic", 12F);
            this.TXT_BRD_QUAN.Location = new System.Drawing.Point(107, 236);
            this.TXT_BRD_QUAN.Name = "TXT_BRD_QUAN";
            this.TXT_BRD_QUAN.ReadOnly = true;
            this.TXT_BRD_QUAN.Size = new System.Drawing.Size(190, 34);
            this.TXT_BRD_QUAN.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(28, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "كمية المخزن :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TXT_TOTAL_PRICE
            // 
            this.TXT_TOTAL_PRICE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_TOTAL_PRICE.Font = new System.Drawing.Font("Simplified Arabic", 12F);
            this.TXT_TOTAL_PRICE.Location = new System.Drawing.Point(478, 333);
            this.TXT_TOTAL_PRICE.Name = "TXT_TOTAL_PRICE";
            this.TXT_TOTAL_PRICE.ReadOnly = true;
            this.TXT_TOTAL_PRICE.Size = new System.Drawing.Size(189, 34);
            this.TXT_TOTAL_PRICE.TabIndex = 15;
            // 
            // TXT_NEED_QUAN
            // 
            this.TXT_NEED_QUAN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_NEED_QUAN.Font = new System.Drawing.Font("Simplified Arabic", 12F);
            this.TXT_NEED_QUAN.Location = new System.Drawing.Point(478, 286);
            this.TXT_NEED_QUAN.Name = "TXT_NEED_QUAN";
            this.TXT_NEED_QUAN.Size = new System.Drawing.Size(189, 34);
            this.TXT_NEED_QUAN.TabIndex = 17;
            this.TXT_NEED_QUAN.TextChanged += new System.EventHandler(this.TXT_NEED_QUAN_TextChanged);
            this.TXT_NEED_QUAN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_NEED_QUAN_KeyDown);
            this.TXT_NEED_QUAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_NEED_QUAN_KeyPress);
            this.TXT_NEED_QUAN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_NEED_QUAN_KeyUp);
            this.TXT_NEED_QUAN.Leave += new System.EventHandler(this.TXT_NEED_QUAN_Leave);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(384, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "الكمية المطلوبة :";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(397, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "إجمالي المبلغ :";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(37, 286);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 17);
            this.label16.TabIndex = 20;
            this.label16.Text = "نوع البيع :";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label17);
            this.panel6.Location = new System.Drawing.Point(16, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(677, 27);
            this.panel6.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(255, -8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 24);
            this.label17.TabIndex = 16;
            this.label17.Text = "نافذة بيع المنتجات ";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 10);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(10, 381);
            this.panel14.TabIndex = 41;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1088, 10);
            this.panel17.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(689, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 594);
            this.panel3.TabIndex = 45;
            // 
            // TXT_PRD_NAME
            // 
            this.TXT_PRD_NAME.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_PRD_NAME.Font = new System.Drawing.Font("Simplified Arabic", 12F);
            this.TXT_PRD_NAME.Location = new System.Drawing.Point(478, 236);
            this.TXT_PRD_NAME.Name = "TXT_PRD_NAME";
            this.TXT_PRD_NAME.ReadOnly = true;
            this.TXT_PRD_NAME.Size = new System.Drawing.Size(189, 34);
            this.TXT_PRD_NAME.TabIndex = 48;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(405, 240);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 17);
            this.label25.TabIndex = 47;
            this.label25.Text = "إسم المنتج :";
            // 
            // TXT_SELLING_PRICE
            // 
            this.TXT_SELLING_PRICE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_SELLING_PRICE.Font = new System.Drawing.Font("Simplified Arabic", 12F);
            this.TXT_SELLING_PRICE.Location = new System.Drawing.Point(106, 334);
            this.TXT_SELLING_PRICE.Name = "TXT_SELLING_PRICE";
            this.TXT_SELLING_PRICE.ReadOnly = true;
            this.TXT_SELLING_PRICE.Size = new System.Drawing.Size(190, 34);
            this.TXT_SELLING_PRICE.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(33, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "سعر البيع :";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(28, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 17);
            this.label18.TabIndex = 32;
            this.label18.Text = "على حسابــــــ ";
            // 
            // COMBO_CUST
            // 
            this.COMBO_CUST.Font = new System.Drawing.Font("Simplified Arabic", 12F);
            this.COMBO_CUST.FormattingEnabled = true;
            this.COMBO_CUST.Location = new System.Drawing.Point(478, 49);
            this.COMBO_CUST.Name = "COMBO_CUST";
            this.COMBO_CUST.Size = new System.Drawing.Size(189, 36);
            this.COMBO_CUST.TabIndex = 35;
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_NAME.Font = new System.Drawing.Font("Simplified Arabic", 12F);
            this.TXT_NAME.Location = new System.Drawing.Point(195, 50);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.Size = new System.Drawing.Size(189, 34);
            this.TXT_NAME.TabIndex = 42;
            this.TXT_NAME.TextChanged += new System.EventHandler(this.TXT_NAME_TextChanged);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(248, 103);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 17);
            this.label19.TabIndex = 43;
            // 
            // RAD_NAME
            // 
            this.RAD_NAME.AutoSize = true;
            this.RAD_NAME.ForeColor = System.Drawing.Color.Black;
            this.RAD_NAME.Location = new System.Drawing.Point(121, 49);
            this.RAD_NAME.Name = "RAD_NAME";
            this.RAD_NAME.Size = new System.Drawing.Size(58, 21);
            this.RAD_NAME.TabIndex = 49;
            this.RAD_NAME.TabStop = true;
            this.RAD_NAME.Text = "الإسم :";
            this.RAD_NAME.UseVisualStyleBackColor = true;
            this.RAD_NAME.CheckedChanged += new System.EventHandler(this.RAD_NAME_CheckedChanged);
            // 
            // RAD_CUST
            // 
            this.RAD_CUST.AutoSize = true;
            this.RAD_CUST.ForeColor = System.Drawing.Color.Black;
            this.RAD_CUST.Location = new System.Drawing.Point(404, 51);
            this.RAD_CUST.Name = "RAD_CUST";
            this.RAD_CUST.Size = new System.Drawing.Size(60, 21);
            this.RAD_CUST.TabIndex = 50;
            this.RAD_CUST.TabStop = true;
            this.RAD_CUST.Text = "العميل :";
            this.RAD_CUST.UseVisualStyleBackColor = true;
            this.RAD_CUST.CheckedChanged += new System.EventHandler(this.RAD_CUST_CheckedChanged);
            // 
            // COMBO_SALE_TYPE
            // 
            this.COMBO_SALE_TYPE.Font = new System.Drawing.Font("Simplified Arabic", 12F);
            this.COMBO_SALE_TYPE.FormattingEnabled = true;
            this.COMBO_SALE_TYPE.Items.AddRange(new object[] {
            "بيع جملة",
            "بيع قطاعي"});
            this.COMBO_SALE_TYPE.Location = new System.Drawing.Point(107, 286);
            this.COMBO_SALE_TYPE.Name = "COMBO_SALE_TYPE";
            this.COMBO_SALE_TYPE.Size = new System.Drawing.Size(190, 36);
            this.COMBO_SALE_TYPE.TabIndex = 53;
            this.COMBO_SALE_TYPE.SelectedIndexChanged += new System.EventHandler(this.COMBO_SALE_TYPE_SelectedIndexChanged);
            // 
            // ListView1
            // 
            this.ListView1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader20,
            this.ColumnHeader15,
            this.columnHeader1,
            this.ColumnHeader18,
            this.columnHeader2});
            this.ListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ListView1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.Location = new System.Drawing.Point(700, 16);
            this.ListView1.Name = "ListView1";
            this.ListView1.RightToLeftLayout = true;
            this.ListView1.Size = new System.Drawing.Size(388, 393);
            this.ListView1.TabIndex = 54;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.Click += new System.EventHandler(this.ListView1_Click);
            // 
            // ColumnHeader20
            // 
            this.ColumnHeader20.Text = "إسم المنتج";
            this.ColumnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader20.Width = 135;
            // 
            // ColumnHeader15
            // 
            this.ColumnHeader15.Text = "الكمية";
            this.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader15.Width = 75;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "السعر";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 85;
            // 
            // ColumnHeader18
            // 
            this.ColumnHeader18.Text = "الإجمالي";
            this.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader18.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "باركود المنتج";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(140, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "بحث عن منتج :";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Aim-Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "PRD_NAME";
            table1.Name = "TBL_PRODUCTS";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "PRD_NO";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Distinct = true;
            selectQuery1.FilterString = "[TBL_PRODUCTS.PRD_NAME] Like [TBL_PRODUCTS.PRD_NAME]";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "TBL_PRODUCTS";
            queryParameter1.Name = "Parameter1";
            queryParameter1.Type = typeof(string);
            selectQuery1.Parameters.Add(queryParameter1);
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlRCTF9QUk9EVUNUUyI+PEZpZ" +
    "WxkIE5hbWU9IlBSRF9OQU1FIiBUeXBlPSJTdHJpbmciIC8+PEZpZWxkIE5hbWU9IlBSRF9OTyIgVHlwZ" +
    "T0iSW50MzIiIC8+PC9WaWV3PjwvRGF0YVNldD4=";
            // 
            // sEARCHPRODUCTBindingSource
            // 
            this.sEARCHPRODUCTBindingSource.CurrentChanged += new System.EventHandler(this.sEARCHPRODUCTBindingSource_CurrentChanged);
            // 
            // sEARCH_PRODUCTTableAdapter
            // 
            this.sEARCH_PRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // COMBO_SEARCH
            // 
            this.COMBO_SEARCH.Location = new System.Drawing.Point(220, 115);
            this.COMBO_SEARCH.Name = "COMBO_SEARCH";
            this.COMBO_SEARCH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.COMBO_SEARCH.Properties.DataSource = this.sqlDataSource1;
            this.COMBO_SEARCH.Properties.DisplayMember = "TBL_PRODUCTS.PRD_NAME";
            this.COMBO_SEARCH.Properties.NullText = "";
            this.COMBO_SEARCH.Properties.PopupSizeable = false;
            this.COMBO_SEARCH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.COMBO_SEARCH.Properties.ValueMember = "TBL_PRODUCTS.PRD_NO";
            this.COMBO_SEARCH.Properties.View = this.searchLookUpEdit1View;
            this.COMBO_SEARCH.Size = new System.Drawing.Size(321, 20);
            this.COMBO_SEARCH.TabIndex = 57;
            this.COMBO_SEARCH.EditValueChanged += new System.EventHandler(this.COMBO_SEARCH_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Form_FinishOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 620);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.COMBO_SALE_TYPE);
            this.Controls.Add(this.TXT_SELLING_PRICE);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RAD_CUST);
            this.Controls.Add(this.RAD_NAME);
            this.Controls.Add(this.TXT_PRD_NAME);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TXT_NAME);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.COMBO_CUST);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TXT_NEED_QUAN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TXT_TOTAL_PRICE);
            this.Controls.Add(this.TXT_BRD_QUAN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TXT_BARCODE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXT_BILLS_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.COMBO_SEARCH);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_FinishOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_FinishOrder";
            this.Load += new System.EventHandler(this.Form_FinishOrder_Load);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATE_BILL.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATE_BILL.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHPRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMBO_SEARCH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Button BT_DEL;
        public System.Windows.Forms.Button BT_PAY;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TXT_BILLS_ID;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox TXT_BARCODE;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox TXT_BRD_QUAN;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TXT_TOTAL_PRICE;
        public System.Windows.Forms.TextBox TXT_NEED_QUAN;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox TXT_EMBLOYEE;
        public System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_EXIT;
        private System.Windows.Forms.Button BT_CANCEL;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TXT_NOTE;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BT_PRINT;
        public System.Windows.Forms.Label LBL_TOTAL_PRICE;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LBL_BILL_NO;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label LBL_BILL_PRICE;
        public System.Windows.Forms.Label LBL_DATE;
        public System.Windows.Forms.TextBox TXT_PRD_NAME;
        public System.Windows.Forms.Label label25;
        public System.Windows.Forms.TextBox TXT_SELLING_PRICE;
        public System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.DateEdit DATE_BILL;
        public System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox COMBO_CUST;
        public System.Windows.Forms.TextBox TXT_NAME;
        public System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton RAD_NAME;
        private System.Windows.Forms.RadioButton RAD_CUST;
        private System.Windows.Forms.ComboBox COMBO_SALE_TYPE;
        internal System.Windows.Forms.ColumnHeader ColumnHeader15;
        internal System.Windows.Forms.ColumnHeader ColumnHeader20;
        internal System.Windows.Forms.ColumnHeader ColumnHeader18;
        private System.Windows.Forms.Button BT_REPORT;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.Label label4;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource sEARCHPRODUCTBindingSource;
        private ShopInvetoryManagement.Lang_DataBaseDataSetTableAdapters.SEARCH_PRODUCTTableAdapter sEARCH_PRODUCTTableAdapter;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ListView ListView1;
        private DevExpress.XtraEditors.SearchLookUpEdit COMBO_SEARCH;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    }
}