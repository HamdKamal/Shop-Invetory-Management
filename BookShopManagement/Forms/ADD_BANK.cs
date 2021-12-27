﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopInvetoryManagement.BL;


namespace BookShopManagement.Forms
{
    public partial class ADD_BANK : Form
    {
        Bank_Operation ope = new Bank_Operation();
        void GET_ID()
        {
            DataTable DT = new DataTable();
            DT = ope.GET_Bank_ID();
            int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
            TXT_ID.Text = id.ToString();
        }
        public void JustNumber(KeyPressEventArgs r)
        {
            if (!char.IsDigit(r.KeyChar))
            {
                if (!char.IsControl(r.KeyChar))
                {
                    if (!char.IsPunctuation(r.KeyChar))
                    {
                        if (!char.IsWhiteSpace(r.KeyChar))
                        {
                            if (!char.IsSeparator(r.KeyChar))
                                r.Handled = true;
                        }
                    }
                }
            }
        }
        void CLEAR_TEXT_BOX(Control CN)
        {
            foreach (Control C in CN.Controls)
                if (C is TextBox)

                    ((TextBox)C).Clear();

                else

                    CLEAR_TEXT_BOX(C);

        }
        public ADD_BANK()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
        }

        private void ADD_BANK_Load(object sender, EventArgs e)
        {
            BT_DEL.Enabled = false;
            BT_EDIT.Enabled = false;
            BT_SAVE.Enabled = false;

        }

        private void BT_NEW_Click(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX(this);
           sqlDataSource1.Fill();
            GET_ID();
            BT_SAVE.Enabled = true;
            BT_NEW.Enabled = false;
            BT_EDIT.Enabled = false;
            BT_DEL.Enabled = false;
        }

        private void BT_DEL_Click(object sender, EventArgs e)
        {
            ope.DELETE_BANK(Convert.ToInt16(TXT_ID.Text));
            MessageBox.Show("تم حذف بيانات البنك ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CLEAR_TEXT_BOX(this);
            sqlDataSource1.Fill();
            BT_DEL.Enabled = false;
            BT_EDIT.Enabled = false;
            BT_SAVE.Enabled = false;
        }

        private void BT_SAVE_Click(object sender, EventArgs e)
        {
            if(TXT_NAME.Text == " " || TXT_MONEY.Text == " " || TXT_ADD.Text == " " || TXT_ACC.Text == " ")
            {
                MessageBox.Show("الرجاء ملء الحقول");
                return;
            }
            ope.ADD_BANK(Convert.ToInt16(TXT_ID.Text), TXT_NAME.Text, TXT_ACC.Text, TXT_ADD.Text, TXT_NOTE.Text,TXT_MONEY.Text);
            MessageBox.Show("تمت إضافة بيانات البنك ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlDataSource1.Fill();
            CLEAR_TEXT_BOX(this);
            BT_SAVE.Enabled = false;
            BT_NEW.Enabled = true;
            BT_EDIT.Enabled = false;
            
        }

        private void BT_EDIT_Click(object sender, EventArgs e)
        {
            ope.EDIT_BANK(Convert.ToInt16(TXT_ID.Text), TXT_NAME.Text, TXT_ACC.Text, TXT_ADD.Text, TXT_NOTE.Text,TXT_MONEY.Text);
            MessageBox.Show("تم تعديل  بيانات البنك ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlDataSource1.Fill();
            CLEAR_TEXT_BOX(this);
            BT_SAVE.Enabled = false;
            BT_NEW.Enabled = true;
            BT_EDIT.Enabled = false;
        }

        private void BT_BACK_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void GRID_BANK_Click(object sender, EventArgs e)
        {
            BT_SAVE.Enabled = false;
            BT_EDIT.Enabled = true;
            BT_DEL.Enabled = true;
            try
            {
                CLEAR_TEXT_BOX(this);
                TXT_ID.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("رقم البنك"));
                TXT_NAME.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("إسم البنك"));
                TXT_ACC.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("رقم الحساب"));
                TXT_ADD.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("عنوان البنك"));
                TXT_NOTE.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("الوصف"));
                TXT_MONEY.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("رصيد البنك"));

            }
            catch
            {
                return;
            }
        }

        private void TXT_MONEY_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }
    }
}
