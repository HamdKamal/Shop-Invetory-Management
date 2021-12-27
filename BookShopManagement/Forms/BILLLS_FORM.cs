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
    
    public partial class BILLLS_FORM : Form
    {
        Another_Finance ANT = new Another_Finance();
        Bank_Operation BNK = new Bank_Operation();
        public string RAD;

        ShopInvetoryManagement.DAL.DATAACCESSLAYER DAL = new ShopInvetoryManagement.DAL.DATAACCESSLAYER();
        int B_ID;
        public void get_bankmoney()
        {
           
            DataTable DT = BNK.GetBank_Data_ONE(COMBO_BANK.Text);
            if (DT.Rows.Count > 0)
            {
                B_ID = Convert.ToInt32( DT.Rows[0]["Bank_ID"]);
               
            }
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
        public void COM_BANK()
        {
            COMBO_BANK.DataSource = BNK.GetBank_Data();
            COMBO_BANK.DisplayMember = "Bank_Name";
            COMBO_BANK.ValueMember = "Bank_ID";
        }
      
        void GET_ID_BANK()
        {
            DataTable DT = new DataTable();
            DT = ANT.get_BANK_BILLS_id();
            int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
            TXT_ID.Text = id.ToString();
        }
        void GET_ID_CASHK()
        {
            DataTable DT = new DataTable();
            DT = ANT.get_CASH_BILL_id();
            int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
            TXT_ID.Text = id.ToString();
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
            COMBO_BANK.Visible = SOL;
            TXT_CHECK.Visible = SOL;
            label1.Visible = SOL;
            label7.Visible = SOL;
            TXT_BYAN.Enabled = SOL;
            TXT_CHECK.Enabled = SOL;
            TXT_EMP.Enabled = SOL;
            TXT_ID.Enabled = SOL;
            TXT_MONEY.Enabled = SOL;
            COMBO_BILLS.Enabled = SOL;
            COMBO_BANK.Enabled = SOL;
            DATE_BILLS.Enabled = SOL;
            RAD_CASH.Enabled = SOL;
            RAD_CHECH.Enabled = SOL;
         }

        public BILLLS_FORM()
        {
            InitializeComponent();
            TXT_EMP.Text = Program.Casheir;
        }

        private void RAD_CASH_CheckedChanged(object sender, EventArgs e)
        {
            RAD = "نقدي";
            //RAD_CASH.Checked = true;
            RAD_CHECH.Enabled = false;
            RAD_CHECH.Visible = false;
            COMBO_BANK.Visible = false;
            TXT_CHECK.Visible = false;
            label1.Visible = false;
            label7.Visible = false;
            GET_ID_CASHK();


        }

        private void RAD_CHECH_CheckedChanged(object sender, EventArgs e)
        {
            RAD = "شيك";
            //RAD_CHECH.Checked = true;
            RAD_CASH.Enabled = false;
            RAD_CASH.Visible = false;
            COMBO_BANK.Visible = true;
            TXT_CHECK.Visible = true;
            label1.Visible = true;
            label7.Visible = true;
            GET_ID_BANK();
        }

        private void BT_NEW_Click(object sender, EventArgs e)
        {
            DATE_BILLS.Text = DateTime.Now.ToShortDateString();
            SOLAFA(true);
            CLEAR_TEXT_BOX(this);
           
            BT_SAVE.Enabled = true;
            BT_NEW.Enabled = false;

        }

        private void BT_EDIT_Click(object sender, EventArgs e)
        {

        }

        private void BT_SAVE_Click(object sender, EventArgs e)
        {
            if (TXT_MONEY.Text == "" || TXT_ID.Text == "" || TXT_CHECK.Text == "")
            {
                MessageBox.Show("الرجاء ملء الحقول");
                return;
            }
            if (RAD == "نقدي")
            {
                ANT.ADD_TO_BILLS_CASH(Convert.ToInt16(TXT_ID.Text),Program.Casheir_ID,TXT_MONEY.Text,COMBO_BILLS.Text,TXT_BYAN.Text,RAD,DATE_BILLS.DateTime.Date);
            }
            else
            {
                ANT.ADD_TO_BILLS_BANK(Convert.ToInt16(TXT_ID.Text), Program.Casheir_ID, TXT_MONEY.Text, COMBO_BILLS.Text, TXT_BYAN.Text, RAD, DATE_BILLS.DateTime.Date,B_ID,Convert.ToInt32(TXT_CHECK.Text));

            }

            MessageBox.Show("تمت إضافة المعاملة ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CLEAR_TEXT_BOX(this);
            BT_NEW.Enabled = true;
            BT_SAVE.Enabled = false;
            SOLAFA(false);

            label1.Visible = false;
            label7.Visible = false;
            COMBO_BANK.Visible = false;
            TXT_CHECK.Visible = false;

            RAD_CASH.Checked = false;
            RAD_CHECH.Checked = false;

            RAD_CHECH.Visible = true;
            RAD_CASH.Visible = true;

            DATE_BILLS.Text = DateTime.Now.ToLongDateString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TXT_CHECK_TextChanged(object sender, EventArgs e)
        {

        }

        private void BILLLS_FORM_Load(object sender, EventArgs e)
        {
            COM_BANK();
        }

        private void COMBO_BANK_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_bankmoney();
        }

        private void BT_BACK_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void TXT_MONEY_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }

        private void TXT_CHECK_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }
    }
}
