namespace ShopInvetoryManagement.Forms
{
    partial class User_Permiastion
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Permiastion));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.GRID_PERMISITION = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colإسمالمستخدم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنوعالمستخدم = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colقاعدةالبيانات = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالمصروفات = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإضافةالعملاء = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colدفعاتالعملاء = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالديون = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإضافةالموظفين = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالأصناف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالمنتجات = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإدارةالمخزن = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإضافةالبنوك = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colمعاملاتالبنك = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإضافةالخزنة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colمعاملاتالخزنة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالشيكات = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنافذةالبيع = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colصلاحياتالمستخدمين = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.C_DIEON = new System.Windows.Forms.CheckBox();
            this.C_BAC_RES = new System.Windows.Forms.CheckBox();
            this.C_POS = new System.Windows.Forms.CheckBox();
            this.C_PERM = new System.Windows.Forms.CheckBox();
            this.C_STG_OPE = new System.Windows.Forms.CheckBox();
            this.C_STORAGE = new System.Windows.Forms.CheckBox();
            this.C_SHECK = new System.Windows.Forms.CheckBox();
            this.C_BANK_OPE = new System.Windows.Forms.CheckBox();
            this.C_BANK = new System.Windows.Forms.CheckBox();
            this.C_STOCK = new System.Windows.Forms.CheckBox();
            this.C_PRD = new System.Windows.Forms.CheckBox();
            this.C_CATE = new System.Windows.Forms.CheckBox();
            this.C_EMP = new System.Windows.Forms.CheckBox();
            this.C_CUS_PAY = new System.Windows.Forms.CheckBox();
            this.C_CUST = new System.Windows.Forms.CheckBox();
            this.C_BILLS = new System.Windows.Forms.CheckBox();
            this.COMBO_NAME = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.bt_new = new System.Windows.Forms.Button();
            this.BT_DEL = new System.Windows.Forms.Button();
            this.BT_EDITE = new System.Windows.Forms.Button();
            this.BT_BACK = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_PERMISITION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 653);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1285, 10);
            this.panel5.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 653);
            this.panel2.TabIndex = 53;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 643);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1295, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 653);
            this.panel4.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1305, 10);
            this.panel3.TabIndex = 51;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(18, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1271, 35);
            this.panel6.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("PT Bold Heading", 14F);
            this.label12.Location = new System.Drawing.Point(538, -4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 34);
            this.label12.TabIndex = 16;
            this.label12.Text = "إدارة  صلاحيات المستخدمين ";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.GRID_PERMISITION);
            this.panel7.Controls.Add(this.groupBox1);
            this.panel7.Controls.Add(this.COMBO_NAME);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(18, 58);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1271, 526);
            this.panel7.TabIndex = 56;
            // 
            // GRID_PERMISITION
            // 
            this.GRID_PERMISITION.DataMember = "Query";
            this.GRID_PERMISITION.DataSource = this.sqlDataSource1;
            this.GRID_PERMISITION.Font = new System.Drawing.Font("PT Bold Heading", 8F);
            this.GRID_PERMISITION.Location = new System.Drawing.Point(7, 198);
            this.GRID_PERMISITION.MainView = this.gridView1;
            this.GRID_PERMISITION.Name = "GRID_PERMISITION";
            this.GRID_PERMISITION.Size = new System.Drawing.Size(1254, 317);
            this.GRID_PERMISITION.TabIndex = 125;
            this.GRID_PERMISITION.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GRID_PERMISITION.Click += new System.EventHandler(this.GRID_PERMISITION_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Aim-Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
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
            this.colإسمالمستخدم,
            this.colنوعالمستخدم,
            this.colقاعدةالبيانات,
            this.colالمصروفات,
            this.colإضافةالعملاء,
            this.colدفعاتالعملاء,
            this.colالديون,
            this.colإضافةالموظفين,
            this.colالأصناف,
            this.colالمنتجات,
            this.colإدارةالمخزن,
            this.colإضافةالبنوك,
            this.colمعاملاتالبنك,
            this.colإضافةالخزنة,
            this.colمعاملاتالخزنة,
            this.colالشيكات,
            this.colنافذةالبيع,
            this.colصلاحياتالمستخدمين});
            this.gridView1.GridControl = this.GRID_PERMISITION;
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
            this.gridView1.OptionsFind.AllowFindPanel = false;
            this.gridView1.OptionsFind.ClearFindOnClose = false;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.FindClick;
            this.gridView1.OptionsFind.FindNullPrompt = "أكتب إسم الموظف ...";
            this.gridView1.OptionsFind.HighlightFindResults = false;
            this.gridView1.OptionsFind.ShowClearButton = false;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsLayout.Columns.AddNewColumns = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colإسمالمستخدم
            // 
            this.colإسمالمستخدم.FieldName = "إسم المستخدم";
            this.colإسمالمستخدم.Name = "colإسمالمستخدم";
            this.colإسمالمستخدم.Visible = true;
            this.colإسمالمستخدم.VisibleIndex = 0;
            // 
            // colنوعالمستخدم
            // 
            this.colنوعالمستخدم.FieldName = "نوع المستخدم";
            this.colنوعالمستخدم.Name = "colنوعالمستخدم";
            this.colنوعالمستخدم.Visible = true;
            this.colنوعالمستخدم.VisibleIndex = 1;
            // 
            // colقاعدةالبيانات
            // 
            this.colقاعدةالبيانات.FieldName = "قاعدة البيانات";
            this.colقاعدةالبيانات.Name = "colقاعدةالبيانات";
            this.colقاعدةالبيانات.Visible = true;
            this.colقاعدةالبيانات.VisibleIndex = 2;
            // 
            // colالمصروفات
            // 
            this.colالمصروفات.FieldName = "المصروفات";
            this.colالمصروفات.Name = "colالمصروفات";
            this.colالمصروفات.Visible = true;
            this.colالمصروفات.VisibleIndex = 3;
            // 
            // colإضافةالعملاء
            // 
            this.colإضافةالعملاء.FieldName = "إضافة العملاء";
            this.colإضافةالعملاء.Name = "colإضافةالعملاء";
            this.colإضافةالعملاء.Visible = true;
            this.colإضافةالعملاء.VisibleIndex = 4;
            // 
            // colدفعاتالعملاء
            // 
            this.colدفعاتالعملاء.FieldName = "دفعات العملاء";
            this.colدفعاتالعملاء.Name = "colدفعاتالعملاء";
            this.colدفعاتالعملاء.Visible = true;
            this.colدفعاتالعملاء.VisibleIndex = 5;
            // 
            // colالديون
            // 
            this.colالديون.FieldName = "الديون";
            this.colالديون.Name = "colالديون";
            this.colالديون.Visible = true;
            this.colالديون.VisibleIndex = 6;
            // 
            // colإضافةالموظفين
            // 
            this.colإضافةالموظفين.FieldName = "إضافة الموظفين";
            this.colإضافةالموظفين.Name = "colإضافةالموظفين";
            this.colإضافةالموظفين.Visible = true;
            this.colإضافةالموظفين.VisibleIndex = 7;
            // 
            // colالأصناف
            // 
            this.colالأصناف.FieldName = "الأصناف";
            this.colالأصناف.Name = "colالأصناف";
            this.colالأصناف.Visible = true;
            this.colالأصناف.VisibleIndex = 8;
            // 
            // colالمنتجات
            // 
            this.colالمنتجات.FieldName = "المنتجات";
            this.colالمنتجات.Name = "colالمنتجات";
            this.colالمنتجات.Visible = true;
            this.colالمنتجات.VisibleIndex = 9;
            // 
            // colإدارةالمخزن
            // 
            this.colإدارةالمخزن.FieldName = "إدارة المخزن";
            this.colإدارةالمخزن.Name = "colإدارةالمخزن";
            this.colإدارةالمخزن.Visible = true;
            this.colإدارةالمخزن.VisibleIndex = 10;
            // 
            // colإضافةالبنوك
            // 
            this.colإضافةالبنوك.FieldName = "إضافة البنوك";
            this.colإضافةالبنوك.Name = "colإضافةالبنوك";
            this.colإضافةالبنوك.Visible = true;
            this.colإضافةالبنوك.VisibleIndex = 11;
            // 
            // colمعاملاتالبنك
            // 
            this.colمعاملاتالبنك.FieldName = "معاملات البنك";
            this.colمعاملاتالبنك.Name = "colمعاملاتالبنك";
            this.colمعاملاتالبنك.Visible = true;
            this.colمعاملاتالبنك.VisibleIndex = 12;
            // 
            // colإضافةالخزنة
            // 
            this.colإضافةالخزنة.FieldName = "إضافة الخزنة";
            this.colإضافةالخزنة.Name = "colإضافةالخزنة";
            this.colإضافةالخزنة.Visible = true;
            this.colإضافةالخزنة.VisibleIndex = 13;
            // 
            // colمعاملاتالخزنة
            // 
            this.colمعاملاتالخزنة.FieldName = "معاملات الخزنة";
            this.colمعاملاتالخزنة.Name = "colمعاملاتالخزنة";
            this.colمعاملاتالخزنة.Visible = true;
            this.colمعاملاتالخزنة.VisibleIndex = 14;
            // 
            // colالشيكات
            // 
            this.colالشيكات.FieldName = "الشيكات";
            this.colالشيكات.Name = "colالشيكات";
            this.colالشيكات.Visible = true;
            this.colالشيكات.VisibleIndex = 15;
            // 
            // colنافذةالبيع
            // 
            this.colنافذةالبيع.FieldName = "نافذة البيع";
            this.colنافذةالبيع.Name = "colنافذةالبيع";
            this.colنافذةالبيع.Visible = true;
            this.colنافذةالبيع.VisibleIndex = 16;
            // 
            // colصلاحياتالمستخدمين
            // 
            this.colصلاحياتالمستخدمين.FieldName = "صلاحيات المستخدمين";
            this.colصلاحياتالمستخدمين.Name = "colصلاحياتالمستخدمين";
            this.colصلاحياتالمستخدمين.Visible = true;
            this.colصلاحياتالمستخدمين.VisibleIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.C_DIEON);
            this.groupBox1.Controls.Add(this.C_BAC_RES);
            this.groupBox1.Controls.Add(this.C_POS);
            this.groupBox1.Controls.Add(this.C_PERM);
            this.groupBox1.Controls.Add(this.C_STG_OPE);
            this.groupBox1.Controls.Add(this.C_STORAGE);
            this.groupBox1.Controls.Add(this.C_SHECK);
            this.groupBox1.Controls.Add(this.C_BANK_OPE);
            this.groupBox1.Controls.Add(this.C_BANK);
            this.groupBox1.Controls.Add(this.C_STOCK);
            this.groupBox1.Controls.Add(this.C_PRD);
            this.groupBox1.Controls.Add(this.C_CATE);
            this.groupBox1.Controls.Add(this.C_EMP);
            this.groupBox1.Controls.Add(this.C_CUS_PAY);
            this.groupBox1.Controls.Add(this.C_CUST);
            this.groupBox1.Controls.Add(this.C_BILLS);
            this.groupBox1.Enabled = false;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("PT Bold Heading", 8F);
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 183);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "صلاحيات المستخدمين";
            // 
            // C_DIEON
            // 
            this.C_DIEON.AutoSize = true;
            this.C_DIEON.Font = new System.Drawing.Font("PT Bold Heading", 9F);
            this.C_DIEON.ForeColor = System.Drawing.Color.DarkRed;
            this.C_DIEON.Location = new System.Drawing.Point(53, 35);
            this.C_DIEON.Name = "C_DIEON";
            this.C_DIEON.Size = new System.Drawing.Size(86, 26);
            this.C_DIEON.TabIndex = 15;
            this.C_DIEON.Text = "نافذة الديون";
            this.C_DIEON.UseVisualStyleBackColor = true;
            // 
            // C_BAC_RES
            // 
            this.C_BAC_RES.AutoSize = true;
            this.C_BAC_RES.Font = new System.Drawing.Font("PT Bold Heading", 9F);
            this.C_BAC_RES.ForeColor = System.Drawing.Color.DarkRed;
            this.C_BAC_RES.Location = new System.Drawing.Point(20, 144);
            this.C_BAC_RES.Name = "C_BAC_RES";
            this.C_BAC_RES.Size = new System.Drawing.Size(119, 26);
            this.C_BAC_RES.TabIndex = 14;
            this.C_BAC_RES.Text = "إدارة قاعدة البيانات";
            this.C_BAC_RES.UseVisualStyleBackColor = true;
            // 
            // C_POS
            // 
            this.C_POS.AutoSize = true;
            this.C_POS.Font = new System.Drawing.Font("PT Bold Heading", 9F);
            this.C_POS.ForeColor = System.Drawing.Color.DarkRed;
            this.C_POS.Location = new System.Drawing.Point(59, 106);
            this.C_POS.Name = "C_POS";
            this.C_POS.Size = new System.Drawing.Size(80, 26);
            this.C_POS.TabIndex = 13;
            this.C_POS.Text = "نافذة البيع";
            this.C_POS.UseVisualStyleBackColor = true;
            // 
            // C_PERM
            // 
            this.C_PERM.AutoSize = true;
            this.C_PERM.Font = new System.Drawing.Font("PT Bold Heading", 9F);
            this.C_PERM.ForeColor = System.Drawing.Color.DarkRed;
            this.C_PERM.Location = new System.Drawing.Point(37, 69);
            this.C_PERM.Name = "C_PERM";
            this.C_PERM.Size = new System.Drawing.Size(102, 26);
            this.C_PERM.TabIndex = 12;
            this.C_PERM.Text = "إدارة الصلاحيات";
            this.C_PERM.UseVisualStyleBackColor = true;
            // 
            // C_STG_OPE
            // 
            this.C_STG_OPE.AutoSize = true;
            this.C_STG_OPE.Font = new System.Drawing.Font("PT Bold Heading", 9F);
            this.C_STG_OPE.ForeColor = System.Drawing.Color.DarkRed;
            this.C_STG_OPE.Location = new System.Drawing.Point(298, 143);
            this.C_STG_OPE.Name = "C_STG_OPE";
            this.C_STG_OPE.Size = new System.Drawing.Size(100, 26);
            this.C_STG_OPE.TabIndex = 11;
            this.C_STG_OPE.Text = "معاملات الخزنة";
            this.C_STG_OPE.UseVisualStyleBackColor = true;
            // 
            // C_STORAGE
            // 
            this.C_STORAGE.AutoSize = true;
            this.C_STORAGE.Font = new System.Drawing.Font("PT Bold Heading", 9F);
            this.C_STORAGE.ForeColor = System.Drawing.Color.DarkRed;
            this.C_STORAGE.Location = new System.Drawing.Point(313, 107);
            this.C_STORAGE.Name = "C_STORAGE";
            this.C_STORAGE.Size = new System.Drawing.Size(85, 26);
            this.C_STORAGE.TabIndex = 10;
            this.C_STORAGE.Text = "إضافة الخزنة";
            this.C_STORAGE.UseVisualStyleBackColor = true;
            // 
            // C_SHECK
            // 
            this.C_SHECK.AutoSize = true;
            this.C_SHECK.Font = new System.Drawing.Font("PT Bold Heading", 9F);
            this.C_SHECK.ForeColor = System.Drawing.Color.DarkRed;
            this.C_SHECK.Location = new System.Drawing.Point(332, 69);
            this.C_SHECK.Name = "C_SHECK";
            this.C_SHECK.Size = new System.Drawing.Size(66, 26);
            this.C_SHECK.TabIndex = 9;
            this.C_SHECK.Text = "الشيكات";
            this.C_SHECK.UseVisualStyleBackColor = true;
            // 
            // C_BANK_OPE
            // 
            this.C_BANK_OPE.AutoSize = true;
            this.C_BANK_OPE.Font = new System.Drawing.Font("PT Bold Heading", 9F);
            this.C_BANK_OPE.ForeColor = System.Drawing.Color.DarkRed;
            this.C_BANK_OPE.Location = new System.Drawing.Point(301, 32);
            this.C_BANK_OPE.Name = "C_BANK_OPE";
            this.C_BANK_OPE.Size = new System.Drawing.Size(97, 26);
            this.C_BANK_OPE.TabIndex = 8;
            this.C_BANK_OPE.Text = "معاملات البنك";
            this.C_BANK_OPE.UseVisualStyleBackColor = true;
            // 
            // C_BANK
            // 
            this.C_BANK.AutoSize = true;
            this.C_BANK.Font = new System.Drawing.Font("PT Bold Heading", 9F);
            this.C_BANK.ForeColor = System.Drawing.Color.DarkRed;
            this.C_BANK.Location = new System.Drawing.Point(546, 143);
            this.C_BANK.Name = "C_BANK";
            this.C_BANK.Size = new System.Drawing.Size(82, 26);
            this.C_BANK.TabIndex = 7;
            this.C_BANK.Text = "إضافة البنك";
            this.C_BANK.UseVisualStyleBackColor = true;
            // 
            // C_STOCK
            // 
            this.C_STOCK.AutoSize = true;
            this.C_STOCK.Font = new System.Drawing.Font("PT Bold Heading", 9F);
            this.C_STOCK.ForeColor = System.Drawing.Color.DarkRed;
            this.C_STOCK.Location = new System.Drawing.Point(547, 107);
            this.C_STOCK.Name = "C_STOCK";
            this.C_STOCK.Size = new System.Drawing.Size(81, 26);
            this.C_STOCK.TabIndex = 6;
            this.C_STOCK.Text = "إدارة المخزن";
            this.C_STOCK.UseVisualStyleBackColor = true;
            // 
            // C_PRD
            // 
            this.C_PRD.AutoSize = true;
            this.C_PRD.Font = new System.Drawing.Font("PT Bold Heading", 9F);
            this.C_PRD.ForeColor = System.Drawing.Color.DarkRed;
            this.C_PRD.Location = new System.Drawing.Point(535, 69);
            this.C_PRD.Name = "C_PRD";
            this.C_PRD.Size = new System.Drawing.Size(93, 26);
            this.C_PRD.TabIndex = 5;
            this.C_PRD.Text = "إضافة المنتجات";
            this.C_PRD.UseVisualStyleBackColor = true;
            // 
            // C_CATE
            // 
            this.C_CATE.AutoSize = true;
            this.C_CATE.Font = new System.Drawing.Font("PT Bold Heading", 9F);
            this.C_CATE.ForeColor = System.Drawing.Color.DarkRed;
            this.C_CATE.Location = new System.Drawing.Point(535, 32);
            this.C_CATE.Name = "C_CATE";
            this.C_CATE.Size = new System.Drawing.Size(93, 26);
            this.C_CATE.TabIndex = 4;
            this.C_CATE.Text = "إضافة الأصناف";
            this.C_CATE.UseVisualStyleBackColor = true;
            // 
            // C_EMP
            // 
            this.C_EMP.AutoSize = true;
            this.C_EMP.Font = new System.Drawing.Font("PT Bold Heading", 9F);
            this.C_EMP.ForeColor = System.Drawing.Color.DarkRed;
            this.C_EMP.Location = new System.Drawing.Point(808, 146);
            this.C_EMP.Name = "C_EMP";
            this.C_EMP.Size = new System.Drawing.Size(93, 26);
            this.C_EMP.TabIndex = 3;
            this.C_EMP.Text = "إضافة الموظفين";
            this.C_EMP.UseVisualStyleBackColor = true;
            // 
            // C_CUS_PAY
            // 
            this.C_CUS_PAY.AutoSize = true;
            this.C_CUS_PAY.Font = new System.Drawing.Font("PT Bold Heading", 9F);
            this.C_CUS_PAY.ForeColor = System.Drawing.Color.DarkRed;
            this.C_CUS_PAY.Location = new System.Drawing.Point(810, 109);
            this.C_CUS_PAY.Name = "C_CUS_PAY";
            this.C_CUS_PAY.Size = new System.Drawing.Size(91, 26);
            this.C_CUS_PAY.TabIndex = 2;
            this.C_CUS_PAY.Text = "دفعات العملاء";
            this.C_CUS_PAY.UseVisualStyleBackColor = true;
            // 
            // C_CUST
            // 
            this.C_CUST.AutoSize = true;
            this.C_CUST.Font = new System.Drawing.Font("PT Bold Heading", 9F);
            this.C_CUST.ForeColor = System.Drawing.Color.DarkRed;
            this.C_CUST.Location = new System.Drawing.Point(814, 72);
            this.C_CUST.Name = "C_CUST";
            this.C_CUST.Size = new System.Drawing.Size(87, 26);
            this.C_CUST.TabIndex = 1;
            this.C_CUST.Text = "إضافة العملاء";
            this.C_CUST.UseVisualStyleBackColor = true;
            // 
            // C_BILLS
            // 
            this.C_BILLS.AutoSize = true;
            this.C_BILLS.Font = new System.Drawing.Font("PT Bold Heading", 9F);
            this.C_BILLS.ForeColor = System.Drawing.Color.DarkRed;
            this.C_BILLS.Location = new System.Drawing.Point(801, 35);
            this.C_BILLS.Name = "C_BILLS";
            this.C_BILLS.Size = new System.Drawing.Size(100, 26);
            this.C_BILLS.TabIndex = 0;
            this.C_BILLS.Text = "نافذة المصروفات";
            this.C_BILLS.UseVisualStyleBackColor = true;
            // 
            // COMBO_NAME
            // 
            this.COMBO_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_NAME.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.COMBO_NAME.FormattingEnabled = true;
            this.COMBO_NAME.Items.AddRange(new object[] {
            "..."});
            this.COMBO_NAME.Location = new System.Drawing.Point(956, 44);
            this.COMBO_NAME.Name = "COMBO_NAME";
            this.COMBO_NAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.COMBO_NAME.Size = new System.Drawing.Size(294, 31);
            this.COMBO_NAME.TabIndex = 123;
            this.COMBO_NAME.SelectedIndexChanged += new System.EventHandler(this.COMBO_NAME_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label1.Location = new System.Drawing.Point(1166, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 122;
            this.label1.Text = "إسم المستخدم :";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.bt_new);
            this.panel8.Controls.Add(this.BT_DEL);
            this.panel8.Controls.Add(this.BT_EDITE);
            this.panel8.Controls.Add(this.BT_BACK);
            this.panel8.Location = new System.Drawing.Point(275, 590);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(734, 57);
            this.panel8.TabIndex = 124;
            // 
            // bt_new
            // 
            this.bt_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.bt_new.FlatAppearance.BorderSize = 0;
            this.bt_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_new.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_new.ForeColor = System.Drawing.Color.White;
            this.bt_new.Location = new System.Drawing.Point(660, 12);
            this.bt_new.Name = "bt_new";
            this.bt_new.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bt_new.Size = new System.Drawing.Size(50, 33);
            this.bt_new.TabIndex = 67;
            this.bt_new.Text = "+";
            this.bt_new.UseVisualStyleBackColor = false;
            this.bt_new.Click += new System.EventHandler(this.button2_Click);
            // 
            // BT_DEL
            // 
            this.BT_DEL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_DEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BT_DEL.Enabled = false;
            this.BT_DEL.FlatAppearance.BorderSize = 0;
            this.BT_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_DEL.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.BT_DEL.ForeColor = System.Drawing.Color.White;
            this.BT_DEL.Image = ((System.Drawing.Image)(resources.GetObject("BT_DEL.Image")));
            this.BT_DEL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_DEL.Location = new System.Drawing.Point(288, 13);
            this.BT_DEL.Name = "BT_DEL";
            this.BT_DEL.Size = new System.Drawing.Size(110, 33);
            this.BT_DEL.TabIndex = 65;
            this.BT_DEL.Text = "حذف      ";
            this.BT_DEL.UseVisualStyleBackColor = false;
            this.BT_DEL.Click += new System.EventHandler(this.BT_DEL_Click);
            // 
            // BT_EDITE
            // 
            this.BT_EDITE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_EDITE.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BT_EDITE.Enabled = false;
            this.BT_EDITE.FlatAppearance.BorderSize = 0;
            this.BT_EDITE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_EDITE.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.BT_EDITE.ForeColor = System.Drawing.Color.White;
            this.BT_EDITE.Image = ((System.Drawing.Image)(resources.GetObject("BT_EDITE.Image")));
            this.BT_EDITE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_EDITE.Location = new System.Drawing.Point(448, 13);
            this.BT_EDITE.Name = "BT_EDITE";
            this.BT_EDITE.Size = new System.Drawing.Size(110, 33);
            this.BT_EDITE.TabIndex = 64;
            this.BT_EDITE.Text = "تعديل       ";
            this.BT_EDITE.UseVisualStyleBackColor = false;
            this.BT_EDITE.Click += new System.EventHandler(this.BT_EDITE_Click);
            // 
            // BT_BACK
            // 
            this.BT_BACK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_BACK.BackColor = System.Drawing.Color.Red;
            this.BT_BACK.FlatAppearance.BorderSize = 0;
            this.BT_BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_BACK.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.BT_BACK.ForeColor = System.Drawing.Color.White;
            this.BT_BACK.Image = ((System.Drawing.Image)(resources.GetObject("BT_BACK.Image")));
            this.BT_BACK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_BACK.Location = new System.Drawing.Point(131, 13);
            this.BT_BACK.Name = "BT_BACK";
            this.BT_BACK.Size = new System.Drawing.Size(110, 33);
            this.BT_BACK.TabIndex = 62;
            this.BT_BACK.Text = "إلغاء       ";
            this.BT_BACK.UseVisualStyleBackColor = false;
            this.BT_BACK.Click += new System.EventHandler(this.BT_BACK_Click_1);
            // 
            // User_Permiastion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1305, 663);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Permiastion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Permiastion";
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_PERMISITION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel8.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox COMBO_NAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button BT_BACK;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button BT_EDITE;
        public System.Windows.Forms.Button BT_DEL;
        public DevExpress.XtraGrid.GridControl GRID_PERMISITION;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.CheckBox C_DIEON;
        private System.Windows.Forms.CheckBox C_BAC_RES;
        private System.Windows.Forms.CheckBox C_POS;
        private System.Windows.Forms.CheckBox C_PERM;
        private System.Windows.Forms.CheckBox C_STG_OPE;
        private System.Windows.Forms.CheckBox C_STORAGE;
        private System.Windows.Forms.CheckBox C_SHECK;
        private System.Windows.Forms.CheckBox C_BANK_OPE;
        private System.Windows.Forms.CheckBox C_BANK;
        private System.Windows.Forms.CheckBox C_STOCK;
        private System.Windows.Forms.CheckBox C_PRD;
        private System.Windows.Forms.CheckBox C_CATE;
        private System.Windows.Forms.CheckBox C_EMP;
        private System.Windows.Forms.CheckBox C_CUS_PAY;
        private System.Windows.Forms.CheckBox C_CUST;
        private System.Windows.Forms.CheckBox C_BILLS;
        private System.Windows.Forms.Button bt_new;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالمستخدم;
        private DevExpress.XtraGrid.Columns.GridColumn colنوعالمستخدم;
        private DevExpress.XtraGrid.Columns.GridColumn colقاعدةالبيانات;
        private DevExpress.XtraGrid.Columns.GridColumn colالمصروفات;
        private DevExpress.XtraGrid.Columns.GridColumn colإضافةالعملاء;
        private DevExpress.XtraGrid.Columns.GridColumn colدفعاتالعملاء;
        private DevExpress.XtraGrid.Columns.GridColumn colالديون;
        private DevExpress.XtraGrid.Columns.GridColumn colإضافةالموظفين;
        private DevExpress.XtraGrid.Columns.GridColumn colالأصناف;
        private DevExpress.XtraGrid.Columns.GridColumn colالمنتجات;
        private DevExpress.XtraGrid.Columns.GridColumn colإدارةالمخزن;
        private DevExpress.XtraGrid.Columns.GridColumn colإضافةالبنوك;
        private DevExpress.XtraGrid.Columns.GridColumn colمعاملاتالبنك;
        private DevExpress.XtraGrid.Columns.GridColumn colإضافةالخزنة;
        private DevExpress.XtraGrid.Columns.GridColumn colمعاملاتالخزنة;
        private DevExpress.XtraGrid.Columns.GridColumn colالشيكات;
        private DevExpress.XtraGrid.Columns.GridColumn colنافذةالبيع;
        private DevExpress.XtraGrid.Columns.GridColumn colصلاحياتالمستخدمين;
    }
}