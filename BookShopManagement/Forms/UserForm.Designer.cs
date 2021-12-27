namespace BookShopManagement.Forms
{
    partial class UserForm
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.GRID_USER = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colرقمالمستخدم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنوعالمستخدم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإسمالمستخدم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colكلمةالمرور = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإسمالموظف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COMBO_EMP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_NAME = new System.Windows.Forms.TextBox();
            this.TXT_CONFIQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.COMBO_TYPE = new System.Windows.Forms.ComboBox();
            this.TXT_ID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_PASS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BT_NEW = new System.Windows.Forms.Button();
            this.BT_SAVE = new System.Windows.Forms.Button();
            this.BT_DEL = new System.Windows.Forms.Button();
            this.BT_EXIT = new System.Windows.Forms.Button();
            this.BT_EDIT = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_USER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 469);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(846, 10);
            this.panel5.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 469);
            this.panel2.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(856, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 469);
            this.panel4.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(866, 10);
            this.panel3.TabIndex = 43;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(17, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(832, 55);
            this.panel6.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("PT Bold Heading", 14F);
            this.label12.Location = new System.Drawing.Point(316, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 34);
            this.label12.TabIndex = 16;
            this.label12.Text = "نافذة إدارة المستخدمين ";
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.Controls.Add(this.panel7);
            this.groupControl1.Controls.Add(this.COMBO_EMP);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.TXT_NAME);
            this.groupControl1.Controls.Add(this.TXT_CONFIQ);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.COMBO_TYPE);
            this.groupControl1.Controls.Add(this.TXT_ID);
            this.groupControl1.Controls.Add(this.label14);
            this.groupControl1.Controls.Add(this.label13);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.TXT_PASS);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(17, 77);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(832, 305);
            this.groupControl1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.GRID_USER);
            this.panel7.Location = new System.Drawing.Point(9, 22);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(461, 278);
            this.panel7.TabIndex = 77;
            // 
            // GRID_USER
            // 
            this.GRID_USER.DataMember = "Query";
            this.GRID_USER.DataSource = this.sqlDataSource1;
            this.GRID_USER.Font = new System.Drawing.Font("PT Bold Heading", 8F);
            this.GRID_USER.Location = new System.Drawing.Point(2, 3);
            this.GRID_USER.MainView = this.gridView1;
            this.GRID_USER.Name = "GRID_USER";
            this.GRID_USER.Size = new System.Drawing.Size(454, 270);
            this.GRID_USER.TabIndex = 1;
            this.GRID_USER.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GRID_USER.Click += new System.EventHandler(this.GRID_USER_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Aim-Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("PT Bold Heading", 8F);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("PT Bold Heading", 8F);
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("PT Bold Heading", 8F);
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("PT Bold Heading", 8F);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("PT Bold Heading", 8F);
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("PT Bold Heading", 8F);
            this.gridView1.Appearance.RowSeparator.ForeColor = System.Drawing.Color.Blue;
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.Options.UseForeColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colرقمالمستخدم,
            this.colنوعالمستخدم,
            this.colإسمالمستخدم,
            this.colكلمةالمرور,
            this.colإسمالموظف});
            this.gridView1.GridControl = this.GRID_USER;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowColumnResizing = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsCustomization.AllowRowSizing = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.ClearFindOnClose = false;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.FindNullPrompt = "بــحــــث";
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsLayout.Columns.AddNewColumns = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colرقمالمستخدم
            // 
            this.colرقمالمستخدم.FieldName = "رقم المستخدم";
            this.colرقمالمستخدم.Name = "colرقمالمستخدم";
            this.colرقمالمستخدم.Visible = true;
            this.colرقمالمستخدم.VisibleIndex = 0;
            // 
            // colنوعالمستخدم
            // 
            this.colنوعالمستخدم.FieldName = "نوع المستخدم";
            this.colنوعالمستخدم.Name = "colنوعالمستخدم";
            this.colنوعالمستخدم.Visible = true;
            this.colنوعالمستخدم.VisibleIndex = 1;
            // 
            // colإسمالمستخدم
            // 
            this.colإسمالمستخدم.FieldName = "إسم المستخدم";
            this.colإسمالمستخدم.Name = "colإسمالمستخدم";
            this.colإسمالمستخدم.Visible = true;
            this.colإسمالمستخدم.VisibleIndex = 2;
            // 
            // colكلمةالمرور
            // 
            this.colكلمةالمرور.FieldName = "كلمة المرور";
            this.colكلمةالمرور.Name = "colكلمةالمرور";
            this.colكلمةالمرور.Visible = true;
            this.colكلمةالمرور.VisibleIndex = 3;
            // 
            // colإسمالموظف
            // 
            this.colإسمالموظف.FieldName = "إسم الموظف";
            this.colإسمالموظف.Name = "colإسمالموظف";
            this.colإسمالموظف.Visible = true;
            this.colإسمالموظف.VisibleIndex = 4;
            // 
            // COMBO_EMP
            // 
            this.COMBO_EMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_EMP.Font = new System.Drawing.Font("Simplified Arabic", 9F);
            this.COMBO_EMP.FormattingEnabled = true;
            this.COMBO_EMP.Location = new System.Drawing.Point(481, 99);
            this.COMBO_EMP.Name = "COMBO_EMP";
            this.COMBO_EMP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.COMBO_EMP.Size = new System.Drawing.Size(223, 30);
            this.COMBO_EMP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(703, 100);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 75;
            this.label1.Text = "إسم الموظف :";
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Font = new System.Drawing.Font("Simplified Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_NAME.Location = new System.Drawing.Point(481, 138);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_NAME.Size = new System.Drawing.Size(223, 27);
            this.TXT_NAME.TabIndex = 2;
            // 
            // TXT_CONFIQ
            // 
            this.TXT_CONFIQ.Font = new System.Drawing.Font("Simplified Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CONFIQ.Location = new System.Drawing.Point(481, 252);
            this.TXT_CONFIQ.Name = "TXT_CONFIQ";
            this.TXT_CONFIQ.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_CONFIQ.Size = new System.Drawing.Size(223, 27);
            this.TXT_CONFIQ.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(703, 252);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 71;
            this.label5.Text = "تأكيد كلمة المرور :";
            // 
            // COMBO_TYPE
            // 
            this.COMBO_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_TYPE.Font = new System.Drawing.Font("Simplified Arabic", 9F);
            this.COMBO_TYPE.FormattingEnabled = true;
            this.COMBO_TYPE.Items.AddRange(new object[] {
            "مدير النظام",
            "الموظف"});
            this.COMBO_TYPE.Location = new System.Drawing.Point(481, 173);
            this.COMBO_TYPE.Name = "COMBO_TYPE";
            this.COMBO_TYPE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.COMBO_TYPE.Size = new System.Drawing.Size(223, 30);
            this.COMBO_TYPE.TabIndex = 3;
            // 
            // TXT_ID
            // 
            this.TXT_ID.BackColor = System.Drawing.Color.White;
            this.TXT_ID.Font = new System.Drawing.Font("Simplified Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_ID.Location = new System.Drawing.Point(620, 61);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.ReadOnly = true;
            this.TXT_ID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_ID.Size = new System.Drawing.Size(84, 27);
            this.TXT_ID.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(704, 61);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(87, 25);
            this.label14.TabIndex = 54;
            this.label14.Text = "رقم المستخدم :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(700, 173);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(83, 25);
            this.label13.TabIndex = 56;
            this.label13.Text = "نوع المسخدم : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(702, 136);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 57;
            this.label6.Text = "إسم المستخدم :";
            // 
            // TXT_PASS
            // 
            this.TXT_PASS.Font = new System.Drawing.Font("Simplified Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PASS.Location = new System.Drawing.Point(481, 212);
            this.TXT_PASS.Name = "TXT_PASS";
            this.TXT_PASS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_PASS.Size = new System.Drawing.Size(223, 27);
            this.TXT_PASS.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(703, 212);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "كلمة المرور :";
            // 
            // groupControl3
            // 
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl3.Controls.Add(this.BT_NEW);
            this.groupControl3.Controls.Add(this.BT_SAVE);
            this.groupControl3.Controls.Add(this.BT_DEL);
            this.groupControl3.Controls.Add(this.BT_EXIT);
            this.groupControl3.Controls.Add(this.BT_EDIT);
            this.groupControl3.Location = new System.Drawing.Point(17, 388);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(832, 73);
            this.groupControl3.TabIndex = 1;
            // 
            // BT_NEW
            // 
            this.BT_NEW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_NEW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BT_NEW.FlatAppearance.BorderSize = 0;
            this.BT_NEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_NEW.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.BT_NEW.ForeColor = System.Drawing.Color.White;
            this.BT_NEW.Image = ((System.Drawing.Image)(resources.GetObject("BT_NEW.Image")));
            this.BT_NEW.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_NEW.Location = new System.Drawing.Point(654, 27);
            this.BT_NEW.Name = "BT_NEW";
            this.BT_NEW.Size = new System.Drawing.Size(110, 38);
            this.BT_NEW.TabIndex = 0;
            this.BT_NEW.Text = "جديد      ";
            this.BT_NEW.UseVisualStyleBackColor = false;
            this.BT_NEW.Click += new System.EventHandler(this.BT_NEW_Click);
            // 
            // BT_SAVE
            // 
            this.BT_SAVE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_SAVE.BackColor = System.Drawing.Color.SeaGreen;
            this.BT_SAVE.FlatAppearance.BorderSize = 0;
            this.BT_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SAVE.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.BT_SAVE.ForeColor = System.Drawing.Color.White;
            this.BT_SAVE.Image = ((System.Drawing.Image)(resources.GetObject("BT_SAVE.Image")));
            this.BT_SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_SAVE.Location = new System.Drawing.Point(505, 27);
            this.BT_SAVE.Name = "BT_SAVE";
            this.BT_SAVE.Size = new System.Drawing.Size(110, 38);
            this.BT_SAVE.TabIndex = 1;
            this.BT_SAVE.Text = "حفظ       ";
            this.BT_SAVE.UseVisualStyleBackColor = false;
            this.BT_SAVE.Click += new System.EventHandler(this.BT_SAVE_Click);
            // 
            // BT_DEL
            // 
            this.BT_DEL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_DEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BT_DEL.FlatAppearance.BorderSize = 0;
            this.BT_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_DEL.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.BT_DEL.ForeColor = System.Drawing.Color.White;
            this.BT_DEL.Image = ((System.Drawing.Image)(resources.GetObject("BT_DEL.Image")));
            this.BT_DEL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_DEL.Location = new System.Drawing.Point(212, 27);
            this.BT_DEL.Name = "BT_DEL";
            this.BT_DEL.Size = new System.Drawing.Size(110, 38);
            this.BT_DEL.TabIndex = 3;
            this.BT_DEL.Text = "حذف      ";
            this.BT_DEL.UseVisualStyleBackColor = false;
            this.BT_DEL.Click += new System.EventHandler(this.BT_DEL_Click);
            // 
            // BT_EXIT
            // 
            this.BT_EXIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_EXIT.BackColor = System.Drawing.Color.Red;
            this.BT_EXIT.FlatAppearance.BorderSize = 0;
            this.BT_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_EXIT.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.BT_EXIT.ForeColor = System.Drawing.Color.White;
            this.BT_EXIT.Image = ((System.Drawing.Image)(resources.GetObject("BT_EXIT.Image")));
            this.BT_EXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_EXIT.Location = new System.Drawing.Point(65, 27);
            this.BT_EXIT.Name = "BT_EXIT";
            this.BT_EXIT.Size = new System.Drawing.Size(105, 38);
            this.BT_EXIT.TabIndex = 4;
            this.BT_EXIT.Text = "إلغاء       ";
            this.BT_EXIT.UseVisualStyleBackColor = false;
            this.BT_EXIT.Click += new System.EventHandler(this.BT_EXIT_Click);
            // 
            // BT_EDIT
            // 
            this.BT_EDIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_EDIT.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BT_EDIT.FlatAppearance.BorderSize = 0;
            this.BT_EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_EDIT.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.BT_EDIT.ForeColor = System.Drawing.Color.White;
            this.BT_EDIT.Image = ((System.Drawing.Image)(resources.GetObject("BT_EDIT.Image")));
            this.BT_EDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_EDIT.Location = new System.Drawing.Point(360, 27);
            this.BT_EDIT.Name = "BT_EDIT";
            this.BT_EDIT.Size = new System.Drawing.Size(110, 38);
            this.BT_EDIT.TabIndex = 2;
            this.BT_EDIT.Text = "تعديل       ";
            this.BT_EDIT.UseVisualStyleBackColor = false;
            this.BT_EDIT.Click += new System.EventHandler(this.BT_EDIT_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 479);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_USER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox TXT_CONFIQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_PASS;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Button BT_NEW;
        private System.Windows.Forms.Button BT_SAVE;
        private System.Windows.Forms.Button BT_DEL;
        private System.Windows.Forms.Button BT_EXIT;
        private System.Windows.Forms.Button BT_EDIT;
        private System.Windows.Forms.TextBox TXT_NAME;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TXT_ID;
        private System.Windows.Forms.Panel panel7;
        public DevExpress.XtraGrid.GridControl GRID_USER;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colرقمالمستخدم;
        private DevExpress.XtraGrid.Columns.GridColumn colنوعالمستخدم;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالمستخدم;
        private DevExpress.XtraGrid.Columns.GridColumn colكلمةالمرور;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالموظف;
        public System.Windows.Forms.ComboBox COMBO_TYPE;
        public System.Windows.Forms.ComboBox COMBO_EMP;
    }
}