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
using System.IO;

namespace BookShopManagement.Forms
{
    public partial class Customers : Form
    {
        Customer_Operation CUS = new Customer_Operation();
        // GET NEW ID 
        void GET_ID()
        {
            DataTable DT = new DataTable();
            DT = CUS.GET_CUS_ID();
            int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
            TXT_ID.Text = id.ToString();
        }
        // visible tools text
        void tool_visible(Boolean G)
        {
            TXT_ID.Enabled = G;
            TXT_FRIST.Enabled = G;
            TXT_LAST.Enabled = G;
            TXT_IDENTITY.Enabled = G;
            TXT_AGE.Enabled = G;
            TXT_NOTE.Enabled = G;
            TXT_QUAN.Enabled = G;
            TXT_ADDRESS.Enabled = G;
            TXT_PHONE.Enabled = G;
            COMBO_DEGREE.Enabled = G;
            COMBO_GENDER.Enabled = G;
            DATE_REGISTER.Enabled = G;

            CUS_IMG.Enabled = G;
            DOC1.Enabled = G;
            DOC2.Enabled = G;
            DOC3.Enabled = G;
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
        // CLEAR TEXTBOX
        void CLEAR_TEXT_BOX(Control CN)
        {
            foreach (Control C in CN.Controls)
                if (C is TextBox)

                    ((TextBox)C).Clear();

                else

                    CLEAR_TEXT_BOX(C);



            CUS_IMG.Image = ShopInvetoryManagement.Properties.Resources.photo;
            DOC1.Image = ShopInvetoryManagement.Properties.Resources._1;
            DOC2.Image = ShopInvetoryManagement.Properties.Resources._1;
            DOC3.Image = ShopInvetoryManagement.Properties.Resources._1;
                  }
        void grid_visible()
        {
            gridView1.Columns["ONE"].Visible = false;
            gridView1.Columns["TWO"].Visible = false;
            gridView1.Columns["THREE"].Visible = false;
           
        }
        public Customers()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
        }

           private void BT_DEL_Click(object sender, EventArgs e)
        {
          
        }

        private void BT_BACK_Click(object sender, EventArgs e)
        {
        
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            tool_visible(false);
            grid_visible();
            BT_DEL.Enabled = false;
            BT_EDIT.Enabled = false;
            BT_SAVE.Enabled = false;
        }

        private void CUS_IMG_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور |*.JPG;*.PNG;*.GIF;*.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                CUS_IMG.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void DOC1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور |*.JPG;*.PNG;*.GIF;*.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DOC1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void DOC2_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور |*.JPG;*.PNG;*.GIF;*.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DOC2.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void DOC3_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور |*.JPG;*.PNG;*.GIF;*.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DOC3.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void GRID_CUSTOMER_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("رقم العميل").ToString() is null)
            {
                return;
            }
            else
            {
                try
                {
                    tool_visible(true);
                    BT_EDIT.Enabled = true;
                    BT_DEL.Enabled = true;
                    BT_SAVE.Enabled = false;

                    TXT_ID.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("رقم العميل"));
                    TXT_FRIST.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("الإسم الأول"));
                    TXT_LAST.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("الإسم الإخير"));
                    TXT_IDENTITY.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("رقم الهوية"));
                    TXT_AGE.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("العمر"));
                    COMBO_GENDER.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("النوع"));
                    COMBO_DEGREE.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("درجة العميل"));
                    TXT_QUAN.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("حصة العميل"));
                    TXT_NOTE.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("الوصف"));
                    TXT_PHONE.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("رقم الهاتف"));
                    TXT_ADDRESS.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("العنوان"));
                    DATE_REGISTER.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("تاريخ التسجيل"));


                    byte[] pic = (byte[])gridView1.GetFocusedRowCellValue("صورة العميل");
                    MemoryStream MS = new MemoryStream(pic);
                    CUS_IMG.Image = Image.FromStream(MS);

                    byte[] pic1 = (byte[])gridView1.GetFocusedRowCellValue("ONE");
                    MemoryStream MS1 = new MemoryStream(pic1);
                    DOC1.Image = Image.FromStream(MS1);

                    byte[] pic2 = (byte[])gridView1.GetFocusedRowCellValue("TWO");
                    MemoryStream MS2 = new MemoryStream(pic2);
                    DOC2.Image = Image.FromStream(MS2);

                    byte[] pic3 = (byte[])gridView1.GetFocusedRowCellValue("THREE");
                    MemoryStream MS3 = new MemoryStream(pic3);
                    DOC3.Image = Image.FromStream(MS3);
                                        
                }
                catch
                {
                    return;
                }
            }
        }

        private void BT_SAVE_Click(object sender, EventArgs e)
        {
            
        }

        private void BT_EDIT_Click(object sender, EventArgs e)
        {
          
        }

        private void BT_NEW_Click_1(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX(this);
            tool_visible(true);
            sqlDataSource1.Fill();
            GET_ID();
            BT_SAVE.Enabled = true;
            BT_NEW.Enabled = false;
            BT_EDIT.Enabled = false;
            BT_DEL.Enabled = false;
            DATE_REGISTER.Text = DateTime.Now.ToShortDateString();
        }

        private void BT_EDIT_Click_1(object sender, EventArgs e)
        {
            byte[] pictuer, DOC_1, DOC_2, DOC_3;
            if (CUS_IMG.Image == null)
            {
                pictuer = new byte[0];
                DOC_1 = new byte[0];
                DOC_2 = new byte[0];
                DOC_3 = new byte[0];

                CUS.EDIT_CUSTOMERS(Convert.ToInt16(TXT_ID.Text), TXT_FRIST.Text, TXT_LAST.Text, TXT_IDENTITY.Text, Convert.ToInt16(TXT_AGE.Text), COMBO_GENDER.Text
                    , COMBO_DEGREE.Text, TXT_QUAN.Text, TXT_NOTE.Text, TXT_PHONE.Text, TXT_ADDRESS.Text, DATE_REGISTER.DateTime.Date, pictuer, DOC_1, DOC_2, DOC_3, "without_image");


            }
            else
            {
                MemoryStream ms = new MemoryStream();
                MemoryStream D1 = new MemoryStream();
                MemoryStream D2 = new MemoryStream();
                MemoryStream D3 = new MemoryStream();


                CUS_IMG.Image.Save(ms, CUS_IMG.Image.RawFormat);
                pictuer = ms.ToArray();

                DOC1.Image.Save(D1, DOC1.Image.RawFormat);
                DOC_1 = D1.ToArray();

                DOC2.Image.Save(D2, DOC2.Image.RawFormat);
                DOC_2 = D2.ToArray();

                DOC3.Image.Save(D3, DOC3.Image.RawFormat);
                DOC_3 = D3.ToArray();

                CUS.EDIT_CUSTOMERS(Convert.ToInt16(TXT_ID.Text), TXT_FRIST.Text, TXT_LAST.Text, TXT_IDENTITY.Text, Convert.ToInt16(TXT_AGE.Text), COMBO_GENDER.Text
                   , COMBO_DEGREE.Text, TXT_QUAN.Text, TXT_NOTE.Text, TXT_PHONE.Text, TXT_ADDRESS.Text, DATE_REGISTER.DateTime.Date, pictuer, DOC_1, DOC_2, DOC_3, "with_image");

            }


            MessageBox.Show("تم تعديل بيانات العميل", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CLEAR_TEXT_BOX(this);
            sqlDataSource1.Fill();
            BT_SAVE.Enabled = false;
            BT_EDIT.Enabled = false;
            BT_NEW.Enabled = true;
        }

        

        private void BT_BACK_Click_1(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void BT_DEL_Click_1(object sender, EventArgs e)
        {
            CUS.DELETE_CUSTOMER(Convert.ToInt16(TXT_ID.Text));
            MessageBox.Show("تم حذف بيانات العميل ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CLEAR_TEXT_BOX(this);
            sqlDataSource1.Fill();
            BT_DEL.Enabled = false;
            BT_EDIT.Enabled = false;
            BT_SAVE.Enabled = false;
        }

        private void BT_SAVE_Click_1(object sender, EventArgs e)
        {
            if (TXT_FRIST.Text == " " || TXT_ADDRESS.Text == " " || TXT_LAST.Text == " " || TXT_PHONE.Text == " ")
            {
                MessageBox.Show("الرجاء ملء الحقول");
                return;
            }

            byte[] pictuer, DOC_1, DOC_2, DOC_3;
            if (CUS_IMG.Image == null)
            {
                pictuer = new byte[0];
                DOC_1 = new byte[0];
                DOC_2 = new byte[0];
                DOC_3 = new byte[0];

                CUS.ADD_CUSTOMERS(Convert.ToInt16(TXT_ID.Text), TXT_FRIST.Text, TXT_LAST.Text, TXT_IDENTITY.Text, Convert.ToInt16(TXT_AGE.Text), COMBO_GENDER.Text
                    , COMBO_DEGREE.Text, TXT_QUAN.Text, TXT_NOTE.Text,TXT_PHONE.Text, TXT_ADDRESS.Text, DATE_REGISTER.DateTime.Date, pictuer, DOC_1, DOC_2, DOC_3, "without_image");


            }
            else
            {
                MemoryStream ms = new MemoryStream();
                MemoryStream D1 = new MemoryStream();
                MemoryStream D2 = new MemoryStream();
                MemoryStream D3 = new MemoryStream();


                CUS_IMG.Image.Save(ms, CUS_IMG.Image.RawFormat);
                pictuer = ms.ToArray();

                DOC1.Image.Save(D1, DOC1.Image.RawFormat);
                DOC_1 = D1.ToArray();

                DOC2.Image.Save(D2, DOC2.Image.RawFormat);
                DOC_2 = D2.ToArray();

                DOC3.Image.Save(D3, DOC3.Image.RawFormat);
                DOC_3 = D3.ToArray();

                CUS.ADD_CUSTOMERS(Convert.ToInt16(TXT_ID.Text), TXT_FRIST.Text, TXT_LAST.Text, TXT_IDENTITY.Text, Convert.ToInt16(TXT_AGE.Text), COMBO_GENDER.Text
                   , COMBO_DEGREE.Text, TXT_QUAN.Text, TXT_NOTE.Text, TXT_PHONE.Text, TXT_ADDRESS.Text, DATE_REGISTER.DateTime.Date, pictuer, DOC_1, DOC_2, DOC_3, "with_image");

            }


            MessageBox.Show("تم حفظ بيانات بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CLEAR_TEXT_BOX(this);
            sqlDataSource1.Fill();
            BT_SAVE.Enabled = false;
            BT_EDIT.Enabled = false;
            BT_NEW.Enabled = true;
        }

        private void TXT_AGE_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }

        private void TXT_PHONE_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }
    }
}
