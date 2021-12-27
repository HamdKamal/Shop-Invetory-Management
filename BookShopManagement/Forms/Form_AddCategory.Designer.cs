namespace BookShopManagement.Forms
{
    partial class Form_AddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddCategory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.GRID_USER = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colرقمالصنف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإسمالصنف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colملاحظة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BT_NEW = new System.Windows.Forms.Button();
            this.BT_DEL = new System.Windows.Forms.Button();
            this.BT_BACK = new System.Windows.Forms.Button();
            this.BT_SAVE = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TXT_NOTE = new System.Windows.Forms.TextBox();
            this.TXT_NAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_USER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 10);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 572);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(623, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 572);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 582);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 10);
            this.panel3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PT Bold Heading", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(227, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 34);
            this.label4.TabIndex = 16;
            this.label4.Text = "إضافة الأصناف ";
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(16, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(601, 43);
            this.panel5.TabIndex = 27;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl2.Appearance.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl2.Controls.Add(this.GRID_USER);
            this.groupControl2.Location = new System.Drawing.Point(16, 223);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(601, 295);
            this.groupControl2.TabIndex = 42;
            // 
            // GRID_USER
            // 
            this.GRID_USER.DataMember = "Query";
            this.GRID_USER.DataSource = this.sqlDataSource1;
            this.GRID_USER.Font = new System.Drawing.Font("PT Bold Heading", 8F);
            this.GRID_USER.Location = new System.Drawing.Point(6, 7);
            this.GRID_USER.MainView = this.gridView1;
            this.GRID_USER.Name = "GRID_USER";
            this.GRID_USER.Size = new System.Drawing.Size(590, 283);
            this.GRID_USER.TabIndex = 2;
            this.GRID_USER.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GRID_USER.Click += new System.EventHandler(this.GRID_USER_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Aim-Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "SELECT [Gate_ID] AS\'رقم الصنف\'\r\n      ,[Gate_Name] AS \'إسم الصنف\'\r\n      ,[Gate_N" +
    "ote] AS \'ملاحظة\'\r\n  FROM [dbo].[TBL_Gategory]";
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
            this.colرقمالصنف,
            this.colإسمالصنف,
            this.colملاحظة});
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
            // colرقمالصنف
            // 
            this.colرقمالصنف.FieldName = "رقم الصنف";
            this.colرقمالصنف.Name = "colرقمالصنف";
            this.colرقمالصنف.Visible = true;
            this.colرقمالصنف.VisibleIndex = 0;
            // 
            // colإسمالصنف
            // 
            this.colإسمالصنف.FieldName = "إسم الصنف";
            this.colإسمالصنف.Name = "colإسمالصنف";
            this.colإسمالصنف.Visible = true;
            this.colإسمالصنف.VisibleIndex = 1;
            // 
            // colملاحظة
            // 
            this.colملاحظة.FieldName = "ملاحظة";
            this.colملاحظة.Name = "colملاحظة";
            this.colملاحظة.Visible = true;
            this.colملاحظة.VisibleIndex = 2;
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl3.Appearance.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.Appearance.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl3.Controls.Add(this.BT_NEW);
            this.groupControl3.Controls.Add(this.BT_DEL);
            this.groupControl3.Controls.Add(this.BT_BACK);
            this.groupControl3.Controls.Add(this.BT_SAVE);
            this.groupControl3.Location = new System.Drawing.Point(120, 524);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(390, 52);
            this.groupControl3.TabIndex = 41;
            this.groupControl3.Text = "بيانات الصنف ";
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
            this.BT_NEW.Location = new System.Drawing.Point(289, 15);
            this.BT_NEW.Name = "BT_NEW";
            this.BT_NEW.Size = new System.Drawing.Size(84, 30);
            this.BT_NEW.TabIndex = 0;
            this.BT_NEW.Text = "جديد      ";
            this.BT_NEW.UseVisualStyleBackColor = false;
            this.BT_NEW.Click += new System.EventHandler(this.BT_NEW_Click);
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
            this.BT_DEL.Location = new System.Drawing.Point(101, 15);
            this.BT_DEL.Name = "BT_DEL";
            this.BT_DEL.Size = new System.Drawing.Size(77, 30);
            this.BT_DEL.TabIndex = 2;
            this.BT_DEL.Text = "حذف      ";
            this.BT_DEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_DEL.UseVisualStyleBackColor = false;
            this.BT_DEL.Click += new System.EventHandler(this.BT_DEL_Click);
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
            this.BT_BACK.Location = new System.Drawing.Point(13, 15);
            this.BT_BACK.Name = "BT_BACK";
            this.BT_BACK.Size = new System.Drawing.Size(73, 30);
            this.BT_BACK.TabIndex = 3;
            this.BT_BACK.Text = "إلغاء       ";
            this.BT_BACK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_BACK.UseVisualStyleBackColor = false;
            this.BT_BACK.Click += new System.EventHandler(this.BT_BACK_Click);
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
            this.BT_SAVE.Location = new System.Drawing.Point(192, 15);
            this.BT_SAVE.Name = "BT_SAVE";
            this.BT_SAVE.Size = new System.Drawing.Size(83, 30);
            this.BT_SAVE.TabIndex = 1;
            this.BT_SAVE.Text = "حفظ       ";
            this.BT_SAVE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_SAVE.UseVisualStyleBackColor = false;
            this.BT_SAVE.Click += new System.EventHandler(this.BT_SAVE_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.TXT_NOTE);
            this.groupControl1.Controls.Add(this.TXT_NAME);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.TXT_ID);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Location = new System.Drawing.Point(16, 65);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(601, 152);
            this.groupControl1.TabIndex = 40;
            // 
            // TXT_NOTE
            // 
            this.TXT_NOTE.Font = new System.Drawing.Font("Simplified Arabic", 9F);
            this.TXT_NOTE.Location = new System.Drawing.Point(29, 75);
            this.TXT_NOTE.Multiline = true;
            this.TXT_NOTE.Name = "TXT_NOTE";
            this.TXT_NOTE.Size = new System.Drawing.Size(486, 59);
            this.TXT_NOTE.TabIndex = 2;
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Font = new System.Drawing.Font("Simplified Arabic", 9F);
            this.TXT_NAME.Location = new System.Drawing.Point(29, 28);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.Size = new System.Drawing.Size(246, 27);
            this.TXT_NAME.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(519, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "رقم الصنف :";
            // 
            // TXT_ID
            // 
            this.TXT_ID.Font = new System.Drawing.Font("Simplified Arabic", 9F);
            this.TXT_ID.Location = new System.Drawing.Point(360, 28);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.ReadOnly = true;
            this.TXT_ID.Size = new System.Drawing.Size(155, 27);
            this.TXT_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(519, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "الوصف :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(276, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "إسم الصنف :";
            // 
            // Form_AddCategory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 592);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddCategory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddCategory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_AddCategory_FormClosed);
            this.Load += new System.EventHandler(this.Form_AddCategory_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_USER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private DragControlDemo.DragControl dragControl1;
        private System.Windows.Forms.Panel panel5;
        public DevExpress.XtraEditors.GroupControl groupControl2;
        public DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Button BT_DEL;
        private System.Windows.Forms.Button BT_BACK;
        private System.Windows.Forms.Button BT_SAVE;
        public DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox TXT_NOTE;
        private System.Windows.Forms.TextBox TXT_NAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_NEW;
        public DevExpress.XtraGrid.GridControl GRID_USER;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colرقمالصنف;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالصنف;
        private DevExpress.XtraGrid.Columns.GridColumn colملاحظة;
    }
}