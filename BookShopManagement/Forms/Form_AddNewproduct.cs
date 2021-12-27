using System;
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
    public partial class Form_AddNewproduct : Form
    {
        Form_AddStock ST = new Form_AddStock();
        public string state = "add";
        Product_Operation ope = new Product_Operation();
        void GET_ID()
        {
            DataTable DT = new DataTable();
            DT = ope.GET_PRODUCT_ID();
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
        public void COM_ID()
        {
            COMBO_CAT.DataSource = ope.GET_Cateagory_NAME();
            COMBO_CAT.DisplayMember = "Gate_Name";
            COMBO_CAT.ValueMember = "Gate_ID";

        }

        public Form_AddNewproduct()
        {
            InitializeComponent();
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form_AddNewproduct_Load(object sender, EventArgs e)
        {
           
                   
        }

        private void BT_NEW_Click(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX(this);
            COM_ID();
            GET_ID();
            BT_SAVE.Enabled = true;
            BT_NEW.Enabled = false;
            DATE_ENTER.Text = DateTime.Now.ToShortDateString();


        }

        private void BT_BACK_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void BT_SAVE_Click(object sender, EventArgs e)
        {
            if (TXT_NAME.Text == "" || TXT_BARCODE.Text == "" || TXT_PRICE.Text == "" || TXT_STOCK_NO.Text == "")
            {
                return;
            }
            
                if (state == "add")
                {
                    ope.ADD_PRODUCTS(Convert.ToInt16(TXT_ID.Text), TXT_BARCODE.Text, TXT_NAME.Text, Convert.ToInt16(TXT_QUAN.Text), Convert.ToInt32(COMBO_CAT.SelectedValue),(TXT_STOCK_NO.Text), TXT_PRICE.Text, TXT_TAJZA_PRICE.Text, TXT_JUOMLA_PRICE.Text, TXT_NOTE.Text, DATE_ENTER.DateTime);
                    ope.ADD_QUANTITYIN_FIRST(Convert.ToInt16(TXT_QUAN.Text),TXT_BARCODE.Text);
                    MessageBox.Show("تمت إضافة المنتج ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CLEAR_TEXT_BOX(this);

                    BT_NEW.Enabled = true;
                    ST.GRID_CUSTOMER.DataSource = ope.GET_ALL_PRODUCTS();
                }
                else
                {
                    ope.EDIT_PRODUCTS(Convert.ToInt16(TXT_ID.Text), TXT_BARCODE.Text, TXT_NAME.Text, Convert.ToInt16(TXT_QUAN.Text), Convert.ToInt32(COMBO_CAT.SelectedValue), (TXT_STOCK_NO.Text), TXT_PRICE.Text, TXT_TAJZA_PRICE.Text, TXT_JUOMLA_PRICE.Text, TXT_NOTE.Text, DATE_ENTER.DateTime);

                    MessageBox.Show("تم تعديل بيانات المنتج ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CLEAR_TEXT_BOX(this);

                    BT_NEW.Enabled = true;
                    ST.GRID_CUSTOMER.DataSource = ope.GET_ALL_PRODUCTS();
                }
                Form_AddStock.getMainForm.GRID_CUSTOMER.DataSource = ope.GET_ALL_PRODUCTS();
            
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            //using (Form_AddCategory ac = new Form_AddCategory())
            //{
            //    ac.ShowDialog();
            //}
        }

        private void Form_AddNewproduct_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Dispose();
        }

        private void TXT_PRICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }

        private void TXT_TAJZA_PRICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }

        private void TXT_JUOMLA_PRICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }

        private void TXT_QUAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }
    }
}
