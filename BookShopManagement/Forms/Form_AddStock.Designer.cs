namespace BookShopManagement.Forms
{
    partial class Form_AddStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddStock));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.GRID_CUSTOMER = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colرقمالمنتج = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colباركودالمنتج = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإسمالمنتج = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colكميةالمخزن = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالصنف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colرقمالمستودع = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colسعرالشراء = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colسعربيعالتجزئة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colسعربيعالجملة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالوصف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالتاريخ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.BT_NEW = new System.Windows.Forms.Button();
            this.BT_DEL = new System.Windows.Forms.Button();
            this.BT_BACK = new System.Windows.Forms.Button();
            this.BT_EDIT = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_CUSTOMER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 687);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Location = new System.Drawing.Point(1026, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 687);
            this.panel4.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 697);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1036, 10);
            this.panel3.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 10);
            this.panel1.TabIndex = 8;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(21, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(995, 48);
            this.panel5.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("PT Bold Heading", 14F);
            this.label12.Location = new System.Drawing.Point(442, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 34);
            this.label12.TabIndex = 16;
            this.label12.Text = "إدارة المخزن ";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.groupControl1);
            this.panel6.Location = new System.Drawing.Point(21, 70);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(995, 560);
            this.panel6.TabIndex = 30;
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.GRID_CUSTOMER);
            this.groupControl1.Controls.Add(this.label14);
            this.groupControl1.Location = new System.Drawing.Point(3, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(987, 545);
            this.groupControl1.TabIndex = 38;
            this.groupControl1.Text = "groupControl1";
            // 
            // GRID_CUSTOMER
            // 
            this.GRID_CUSTOMER.DataMember = "Query";
            this.GRID_CUSTOMER.DataSource = this.sqlDataSource1;
            this.GRID_CUSTOMER.Font = new System.Drawing.Font("PT Bold Heading", 8F);
            this.GRID_CUSTOMER.Location = new System.Drawing.Point(0, 30);
            this.GRID_CUSTOMER.MainView = this.gridView1;
            this.GRID_CUSTOMER.Name = "GRID_CUSTOMER";
            this.GRID_CUSTOMER.Size = new System.Drawing.Size(983, 512);
            this.GRID_CUSTOMER.TabIndex = 64;
            this.GRID_CUSTOMER.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GRID_CUSTOMER.Click += new System.EventHandler(this.GRID_CUSTOMER_Click);
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
            this.colرقمالمنتج,
            this.colباركودالمنتج,
            this.colإسمالمنتج,
            this.colكميةالمخزن,
            this.colالصنف,
            this.colرقمالمستودع,
            this.colسعرالشراء,
            this.colسعربيعالتجزئة,
            this.colسعربيعالجملة,
            this.colالوصف,
            this.colالتاريخ});
            this.gridView1.GridControl = this.GRID_CUSTOMER;
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
            // colرقمالمنتج
            // 
            this.colرقمالمنتج.FieldName = "رقم المنتج";
            this.colرقمالمنتج.Name = "colرقمالمنتج";
            this.colرقمالمنتج.Visible = true;
            this.colرقمالمنتج.VisibleIndex = 0;
            // 
            // colباركودالمنتج
            // 
            this.colباركودالمنتج.FieldName = "باركود المنتج";
            this.colباركودالمنتج.Name = "colباركودالمنتج";
            this.colباركودالمنتج.Visible = true;
            this.colباركودالمنتج.VisibleIndex = 1;
            // 
            // colإسمالمنتج
            // 
            this.colإسمالمنتج.FieldName = "إسم المنتج";
            this.colإسمالمنتج.Name = "colإسمالمنتج";
            this.colإسمالمنتج.Visible = true;
            this.colإسمالمنتج.VisibleIndex = 2;
            // 
            // colكميةالمخزن
            // 
            this.colكميةالمخزن.FieldName = "كمية المخزن";
            this.colكميةالمخزن.Name = "colكميةالمخزن";
            this.colكميةالمخزن.Visible = true;
            this.colكميةالمخزن.VisibleIndex = 3;
            // 
            // colالصنف
            // 
            this.colالصنف.FieldName = "الصنف";
            this.colالصنف.Name = "colالصنف";
            this.colالصنف.Visible = true;
            this.colالصنف.VisibleIndex = 4;
            // 
            // colرقمالمستودع
            // 
            this.colرقمالمستودع.FieldName = "رقم المستودع";
            this.colرقمالمستودع.Name = "colرقمالمستودع";
            this.colرقمالمستودع.Visible = true;
            this.colرقمالمستودع.VisibleIndex = 5;
            // 
            // colسعرالشراء
            // 
            this.colسعرالشراء.FieldName = "سعر الشراء";
            this.colسعرالشراء.Name = "colسعرالشراء";
            this.colسعرالشراء.Visible = true;
            this.colسعرالشراء.VisibleIndex = 6;
            // 
            // colسعربيعالتجزئة
            // 
            this.colسعربيعالتجزئة.FieldName = "سعر بيع التجزئة";
            this.colسعربيعالتجزئة.Name = "colسعربيعالتجزئة";
            this.colسعربيعالتجزئة.Visible = true;
            this.colسعربيعالتجزئة.VisibleIndex = 7;
            // 
            // colسعربيعالجملة
            // 
            this.colسعربيعالجملة.FieldName = "سعر بيع الجملة";
            this.colسعربيعالجملة.Name = "colسعربيعالجملة";
            this.colسعربيعالجملة.Visible = true;
            this.colسعربيعالجملة.VisibleIndex = 8;
            // 
            // colالوصف
            // 
            this.colالوصف.FieldName = "الوصف";
            this.colالوصف.Name = "colالوصف";
            this.colالوصف.Visible = true;
            this.colالوصف.VisibleIndex = 9;
            // 
            // colالتاريخ
            // 
            this.colالتاريخ.FieldName = "التاريخ";
            this.colالتاريخ.Name = "colالتاريخ";
            this.colالتاريخ.Visible = true;
            this.colالتاريخ.VisibleIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label14.Location = new System.Drawing.Point(864, 2);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(103, 25);
            this.label14.TabIndex = 61;
            this.label14.Text = "بحث عن منتج ... ";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.groupControl2);
            this.panel7.Location = new System.Drawing.Point(21, 636);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(995, 55);
            this.panel7.TabIndex = 32;
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Controls.Add(this.BT_NEW);
            this.groupControl2.Controls.Add(this.BT_DEL);
            this.groupControl2.Controls.Add(this.BT_BACK);
            this.groupControl2.Controls.Add(this.BT_EDIT);
            this.groupControl2.Location = new System.Drawing.Point(80, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(823, 45);
            this.groupControl2.TabIndex = 41;
            this.groupControl2.Text = "groupControl2";
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
            this.BT_NEW.Location = new System.Drawing.Point(579, 4);
            this.BT_NEW.Name = "BT_NEW";
            this.BT_NEW.Size = new System.Drawing.Size(98, 38);
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
            this.BT_DEL.Location = new System.Drawing.Point(284, 4);
            this.BT_DEL.Name = "BT_DEL";
            this.BT_DEL.Size = new System.Drawing.Size(110, 38);
            this.BT_DEL.TabIndex = 2;
            this.BT_DEL.Text = "حذف      ";
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
            this.BT_BACK.Location = new System.Drawing.Point(145, 4);
            this.BT_BACK.Name = "BT_BACK";
            this.BT_BACK.Size = new System.Drawing.Size(105, 38);
            this.BT_BACK.TabIndex = 3;
            this.BT_BACK.Text = "إلغاء       ";
            this.BT_BACK.UseVisualStyleBackColor = false;
            this.BT_BACK.Click += new System.EventHandler(this.BT_BACK_Click);
            // 
            // BT_EDIT
            // 
            this.BT_EDIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_EDIT.BackColor = System.Drawing.Color.SeaGreen;
            this.BT_EDIT.FlatAppearance.BorderSize = 0;
            this.BT_EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_EDIT.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.BT_EDIT.ForeColor = System.Drawing.Color.White;
            this.BT_EDIT.Image = ((System.Drawing.Image)(resources.GetObject("BT_EDIT.Image")));
            this.BT_EDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_EDIT.Location = new System.Drawing.Point(432, 4);
            this.BT_EDIT.Name = "BT_EDIT";
            this.BT_EDIT.Size = new System.Drawing.Size(110, 38);
            this.BT_EDIT.TabIndex = 1;
            this.BT_EDIT.Text = "تعديل       ";
            this.BT_EDIT.UseVisualStyleBackColor = false;
            this.BT_EDIT.Click += new System.EventHandler(this.BT_EDIT_Click);
            // 
            // Form_AddStock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 707);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddStock";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddStock";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_CUSTOMER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private DragControlDemo.DragControl dragControl1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button BT_NEW;
        private System.Windows.Forms.Button BT_DEL;
        private System.Windows.Forms.Button BT_BACK;
        private System.Windows.Forms.Button BT_EDIT;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label14;
        public DevExpress.XtraGrid.GridControl GRID_CUSTOMER;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colرقمالمنتج;
        private DevExpress.XtraGrid.Columns.GridColumn colباركودالمنتج;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالمنتج;
        private DevExpress.XtraGrid.Columns.GridColumn colكميةالمخزن;
        private DevExpress.XtraGrid.Columns.GridColumn colالصنف;
        private DevExpress.XtraGrid.Columns.GridColumn colرقمالمستودع;
        private DevExpress.XtraGrid.Columns.GridColumn colسعرالشراء;
        private DevExpress.XtraGrid.Columns.GridColumn colسعربيعالتجزئة;
        private DevExpress.XtraGrid.Columns.GridColumn colسعربيعالجملة;
        private DevExpress.XtraGrid.Columns.GridColumn colالوصف;
        private DevExpress.XtraGrid.Columns.GridColumn colالتاريخ;
    }
}