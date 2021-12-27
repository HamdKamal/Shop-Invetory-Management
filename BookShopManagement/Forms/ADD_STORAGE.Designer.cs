﻿namespace ShopInvetoryManagement.Forms
{
    partial class ADD_STORAGE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD_STORAGE));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.BT_EDIT = new System.Windows.Forms.Button();
            this.BT_NEW = new System.Windows.Forms.Button();
            this.BT_DEL = new System.Windows.Forms.Button();
            this.BT_BACK = new System.Windows.Forms.Button();
            this.BT_SAVE = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.GRID_STORAGE = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colرقمالخزنة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colإسمالخزنة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالرصيد = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TXT_MONEY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_NAME = new System.Windows.Forms.TextBox();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_STORAGE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 434);
            this.panel2.TabIndex = 43;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(966, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 434);
            this.panel4.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 444);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(976, 10);
            this.panel3.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 10);
            this.panel1.TabIndex = 42;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.BT_EDIT);
            this.panel8.Controls.Add(this.BT_NEW);
            this.panel8.Controls.Add(this.BT_DEL);
            this.panel8.Controls.Add(this.BT_BACK);
            this.panel8.Controls.Add(this.BT_SAVE);
            this.panel8.Location = new System.Drawing.Point(244, 385);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(509, 53);
            this.panel8.TabIndex = 49;
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
            this.BT_EDIT.Location = new System.Drawing.Point(214, 6);
            this.BT_EDIT.Name = "BT_EDIT";
            this.BT_EDIT.Size = new System.Drawing.Size(81, 38);
            this.BT_EDIT.TabIndex = 5;
            this.BT_EDIT.Text = "تعديل       ";
            this.BT_EDIT.UseVisualStyleBackColor = false;
            this.BT_EDIT.Click += new System.EventHandler(this.BT_EDIT_Click);
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
            this.BT_NEW.Location = new System.Drawing.Point(403, 6);
            this.BT_NEW.Name = "BT_NEW";
            this.BT_NEW.Size = new System.Drawing.Size(90, 38);
            this.BT_NEW.TabIndex = 3;
            this.BT_NEW.Text = "جديد      ";
            this.BT_NEW.UseVisualStyleBackColor = false;
            this.BT_NEW.Click += new System.EventHandler(this.BT_NEW_Click_1);
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
            this.BT_DEL.Location = new System.Drawing.Point(112, 7);
            this.BT_DEL.Name = "BT_DEL";
            this.BT_DEL.Size = new System.Drawing.Size(85, 38);
            this.BT_DEL.TabIndex = 6;
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
            this.BT_BACK.Location = new System.Drawing.Point(20, 7);
            this.BT_BACK.Name = "BT_BACK";
            this.BT_BACK.Size = new System.Drawing.Size(76, 38);
            this.BT_BACK.TabIndex = 7;
            this.BT_BACK.Text = "إلغاء       ";
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
            this.BT_SAVE.Location = new System.Drawing.Point(311, 7);
            this.BT_SAVE.Name = "BT_SAVE";
            this.BT_SAVE.Size = new System.Drawing.Size(77, 38);
            this.BT_SAVE.TabIndex = 4;
            this.BT_SAVE.Text = "حفظ       ";
            this.BT_SAVE.UseVisualStyleBackColor = false;
            this.BT_SAVE.Click += new System.EventHandler(this.BT_SAVE_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(20, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(939, 58);
            this.panel5.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PT Bold Heading", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(396, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 34);
            this.label4.TabIndex = 16;
            this.label4.Text = "إضافة خزنة جديدة";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.GRID_STORAGE);
            this.panel7.Location = new System.Drawing.Point(521, 81);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(438, 297);
            this.panel7.TabIndex = 47;
            // 
            // GRID_STORAGE
            // 
            this.GRID_STORAGE.DataMember = "Query";
            this.GRID_STORAGE.DataSource = this.sqlDataSource1;
            this.GRID_STORAGE.Font = new System.Drawing.Font("PT Bold Heading", 8F);
            this.GRID_STORAGE.Location = new System.Drawing.Point(4, 5);
            this.GRID_STORAGE.MainView = this.gridView1;
            this.GRID_STORAGE.Name = "GRID_STORAGE";
            this.GRID_STORAGE.Size = new System.Drawing.Size(426, 284);
            this.GRID_STORAGE.TabIndex = 2;
            this.GRID_STORAGE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GRID_STORAGE.Click += new System.EventHandler(this.GRID_STORAGE_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Aim-Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "SELECT [STG_NO]  AS \'رقم الخزنة\' \r\n      ,[STG]  AS \'إسم الخزنة\'\r\n      ,[STG_MON" +
    "EY]  AS \'الرصيد\'\r\n\r\n  FROM [dbo].[TBL_ADD_STORAGE]";
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
            this.colرقمالخزنة,
            this.colإسمالخزنة,
            this.colالرصيد});
            this.gridView1.GridControl = this.GRID_STORAGE;
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
            // colرقمالخزنة
            // 
            this.colرقمالخزنة.FieldName = "رقم الخزنة";
            this.colرقمالخزنة.Name = "colرقمالخزنة";
            this.colرقمالخزنة.Visible = true;
            this.colرقمالخزنة.VisibleIndex = 0;
            // 
            // colإسمالخزنة
            // 
            this.colإسمالخزنة.FieldName = "إسم الخزنة";
            this.colإسمالخزنة.Name = "colإسمالخزنة";
            this.colإسمالخزنة.Visible = true;
            this.colإسمالخزنة.VisibleIndex = 1;
            // 
            // colالرصيد
            // 
            this.colالرصيد.FieldName = "الرصيد";
            this.colالرصيد.Name = "colالرصيد";
            this.colالرصيد.Visible = true;
            this.colالرصيد.VisibleIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.TXT_MONEY);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.TXT_ID);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.TXT_NAME);
            this.panel6.Location = new System.Drawing.Point(20, 81);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(492, 297);
            this.panel6.TabIndex = 46;
            // 
            // TXT_MONEY
            // 
            this.TXT_MONEY.Font = new System.Drawing.Font("Simplified Arabic", 9F);
            this.TXT_MONEY.Location = new System.Drawing.Point(136, 131);
            this.TXT_MONEY.Name = "TXT_MONEY";
            this.TXT_MONEY.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_MONEY.Size = new System.Drawing.Size(268, 27);
            this.TXT_MONEY.TabIndex = 2;
            this.TXT_MONEY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_MONEY_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(406, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 104;
            this.label7.Text = "الرصيد :";
            // 
            // TXT_ID
            // 
            this.TXT_ID.Font = new System.Drawing.Font("Simplified Arabic", 9F);
            this.TXT_ID.Location = new System.Drawing.Point(271, 27);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.ReadOnly = true;
            this.TXT_ID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_ID.Size = new System.Drawing.Size(133, 27);
            this.TXT_ID.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(406, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "إسم الخزنة :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("PT Bold Heading", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(405, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "رقم الخزنة :";
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Font = new System.Drawing.Font("Simplified Arabic", 9F);
            this.TXT_NAME.Location = new System.Drawing.Point(136, 77);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_NAME.Size = new System.Drawing.Size(268, 27);
            this.TXT_NAME.TabIndex = 1;
            // 
            // ADD_STORAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 454);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADD_STORAGE";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD_STORAGE";
            this.Load += new System.EventHandler(this.ADD_STORAGE_Load);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_STORAGE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button BT_EDIT;
        private System.Windows.Forms.Button BT_NEW;
        private System.Windows.Forms.Button BT_DEL;
        private System.Windows.Forms.Button BT_BACK;
        private System.Windows.Forms.Button BT_SAVE;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        public DevExpress.XtraGrid.GridControl GRID_STORAGE;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox TXT_MONEY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_NAME;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colرقمالخزنة;
        private DevExpress.XtraGrid.Columns.GridColumn colإسمالخزنة;
        private DevExpress.XtraGrid.Columns.GridColumn colالرصيد;
    }
}