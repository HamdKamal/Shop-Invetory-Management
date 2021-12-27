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
using System.Data.SqlClient;

namespace BookShopManagement.Forms
{
    public partial class Storage : Form
    {
        public string RAD = "";
        Another_Finance ope = new Another_Finance();
        Bank_Operation BNK = new Bank_Operation();
        ShopInvetoryManagement.DAL.DATAACCESSLAYER DAL = new ShopInvetoryManagement.DAL.DATAACCESSLAYER();
        void GET_ID()
        {
            DataTable DT = new DataTable();
            DT = ope.GET_STORAGE_ID();
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
            TXT_EMP.Text = Program.Casheir;

        }

        void SOLAFA(Boolean SOL)
        {
            

            RAD_CASH.Enabled = SOL;
            RAD_PUSH.Enabled = SOL;
            RAD_CASH.Visible = SOL;
            RAD_PUSH.Visible = SOL;

            TXT_BYAN.Enabled = SOL;
            TXT_MONEY.Enabled = SOL;
            TXT_EMP.Enabled = SOL;
            TXT_NOTE.Enabled = SOL;
            TXT_ID.Enabled = SOL;
        }
        public void get_STORAGEmoney()
        {
            string b_money;
            DataTable DT = BNK.GetSTORAGE_Data_ONE(COMBO_STORE.Text);
            if (DT.Rows.Count > 0)
            {
                b_money = DT.Rows[0]["STG_MONEY"].ToString();
                LBL_BANK_MONEY.Text = b_money;
                LBL_BANK_MONEY.Visible = true;
                label2.Visible = true;

            }
        }
        public void COM_ID()
        {
            COMBO_STORE.DataSource = BNK.Get_ADD_STORAGE_Data();
            COMBO_STORE.DisplayMember = "STG";
            COMBO_STORE.ValueMember = "STG_NO";

        }
        public Storage()
        {
            InitializeComponent();
            TXT_EMP.Text = Program.Casheir;
            DATE_OPE.Text = DateTime.Now.ToLongDateString();
            BT_SAVE.Enabled = false;
            SOLAFA(false);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RAD_CASH_CheckedChanged(object sender, EventArgs e)
        {
            RAD = "سحب";
           
            RAD_PUSH.Checked = false;
            RAD_PUSH.Visible = false;
            
            DATE_PUSH.Text = DATE_OPE.Text = DateTime.Now.ToLongDateString();
            label2.Text = "تاريخ السحب";
            label2.Visible = true;
            DATE_PUSH.Visible = true;
        }

        private void RAD_PUSH_CheckedChanged(object sender, EventArgs e)
        {
            RAD = "إيداع";
            RAD_CASH.Checked =false;
            RAD_CASH.Visible = false;
            DATE_PUSH.Text = DATE_OPE.Text = DateTime.Now.ToLongDateString();
            label2.Text = "تاريخ الإيداع";
            label2.Visible = true;
            DATE_PUSH.Visible = true;
        }

        private void BT_NEW_Click(object sender, EventArgs e)
        {
            DATE_OPE.Text = DateTime.Now.ToShortDateString();
            DATE_PUSH.Text = DateTime.Now.ToShortDateString();
            SOLAFA(true);
            CLEAR_TEXT_BOX(this);
            GET_ID();
            BT_SAVE.Enabled = true;
            BT_NEW.Enabled = false;
            COM_ID();
            
        }

        private void BT_BACK_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void BT_SAVE_Click(object sender, EventArgs e)
        {
            if (TXT_MONEY.Text == "" || TXT_ID.Text == "" || TXT_BYAN.Text == " " || TXT_NOTE.Text == " ")
            {
                MessageBox.Show("الرجاء ملء الحقول");
                return;
            }
            if (RAD == "سحب")
            {
                var M = Convert.ToDecimal(LBL_BANK_MONEY.Text) - Convert.ToDecimal(TXT_MONEY.Text);

                ope.ADD_TO_STORAGE(Convert.ToInt16(TXT_ID.Text),COMBO_STORE.Text,RAD,TXT_MONEY.Text,TXT_BYAN.Text,DATE_PUSH.DateTime.Date,TXT_NOTE.Text,Program.Casheir_ID,DATE_OPE.DateTime.Date,LBL_BANK_MONEY.Text,M.ToString());
                BNK.CONFIQ_Storage_MONEY(COMBO_STORE.Text,TXT_MONEY.Text,"ONE");
                LBL_BANK_MONEY.Text = M.ToString();
            }
            else
            {
                var M = Convert.ToDecimal(LBL_BANK_MONEY.Text) + Convert.ToDecimal(TXT_MONEY.Text);
                ope.ADD_TO_STORAGE(Convert.ToInt16(TXT_ID.Text), COMBO_STORE.Text, RAD, TXT_MONEY.Text, TXT_BYAN.Text, DATE_PUSH.DateTime.Date, TXT_NOTE.Text, Program.Casheir_ID, DATE_OPE.DateTime.Date,LBL_BANK_MONEY.Text,M.ToString());
                BNK.CONFIQ_Storage_MONEY(COMBO_STORE.Text, TXT_MONEY.Text, "TWO");
                LBL_BANK_MONEY.Text = M.ToString();
            }

            MessageBox.Show("تمت إضافة المعاملة ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CLEAR_TEXT_BOX(this);
            BT_NEW.Enabled = true;
            BT_SAVE.Enabled = false;

            RAD_CASH.Visible = false;
            RAD_PUSH.Visible = false;

            label2.Visible = false;
            DATE_PUSH.Visible = false;

            RAD_PUSH.Checked = false;
            RAD_CASH.Checked = false;
            SOLAFA(false);
            DATE_OPE.Text = DateTime.Now.ToLongDateString();
            label2.Visible = false;
            DATE_PUSH.Visible = false;

        }

        private void Storage_Load(object sender, EventArgs e)
        {
            BT_SAVE.Enabled = false;
        }

        private void COMBO_STORE_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_STORAGEmoney();
        }

        private void TXT_MONEY_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }
    }
}
