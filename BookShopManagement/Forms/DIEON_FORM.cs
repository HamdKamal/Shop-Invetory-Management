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
using BookShopManagement;

namespace ShopInvetoryManagement.Forms
{
    public partial class DIEON_FORM : Form
    {
        public string RAD ;
        Another_Finance ope = new Another_Finance();
        ShopInvetoryManagement.DAL.DATAACCESSLAYER DAL = new ShopInvetoryManagement.DAL.DATAACCESSLAYER();
        void GET_ID()
        {
            DataTable DT = new DataTable();
            DT = ope.GET_ELTIZAM_ID();
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

            COMBO_OPE.Enabled = SOL;
            DATE_OPE.Enabled = SOL;
            DATE_COME.Enabled = SOL;
            DATE_PAID.Enabled = SOL;
            TXT_PAY_TYPE.Enabled = SOL;
            TXT_LNAME.Enabled = SOL;
            TXT_FNAME.Enabled = SOL;
            TXT_MONEY.Enabled = SOL;
            TXT_EMP.Enabled = SOL;
            TXT_NOTE.Enabled = SOL;
            TXT_ID.Enabled = SOL;
        }
        public DIEON_FORM()
        {
            InitializeComponent();
            BT_SAVE.Enabled = false;
        }

        private void BT_NEW_Click(object sender, EventArgs e)
        {
            DATE_OPE.Text = DateTime.Now.ToShortDateString();
            DATE_COME.Text = DateTime.Now.ToShortDateString();
            DATE_PAID.Text = DateTime.Now.ToShortDateString();
            SOLAFA(true);
            CLEAR_TEXT_BOX(this);
            GET_ID();
            BT_SAVE.Enabled = true;
            BT_NEW.Enabled = false;
        }

        private void BT_BACK_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void BT_SAVE_Click(object sender, EventArgs e)
        {
            if (TXT_MONEY.Text == "" || TXT_ID.Text == "")
            {
                MessageBox.Show("الرجاء ملء الحقول");
                return;
            }
            if (RAD == "دائن")
            {
                ope.ADD_TO_ELTIZAM(Convert.ToInt16(TXT_ID.Text),RAD,TXT_FNAME.Text,TXT_LNAME.Text,DATE_COME.DateTime.Date,DATE_PAID.DateTime.Date,TXT_MONEY.Text,TXT_PAY_TYPE.Text,TXT_NOTE.Text,Program.Casheir_ID,DATE_OPE.DateTime.Date);

            }
            else
            {
                ope.ADD_TO_ELTIZAM(Convert.ToInt16(TXT_ID.Text), RAD, TXT_FNAME.Text, TXT_LNAME.Text, DATE_COME.DateTime.Date, DATE_PAID.DateTime.Date, TXT_MONEY.Text, TXT_PAY_TYPE.Text, TXT_NOTE.Text, Program.Casheir_ID, DATE_OPE.DateTime.Date);

            }

            MessageBox.Show("تمت إضافة المعاملة ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CLEAR_TEXT_BOX(this);
            BT_NEW.Enabled = true;
            BT_SAVE.Enabled = false;
            SOLAFA(false);

            label_F.Visible = false;
            label_L.Visible = false;
            TXT_FNAME.Visible = false;
            TXT_LNAME.Visible = false;

            DATE_OPE.Text = DateTime.Now.ToLongDateString();
                 
        
    }

        private void COMBO_OPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            RAD = COMBO_OPE.Text;
            if(RAD == "دائن")
            {
                label_F.Visible = true;
                label_L.Visible = true;
                TXT_FNAME.Visible = true;
                TXT_LNAME.Visible = true;

                label_F.Text = "إسم الدائن";
                label_L.Text = "إسم المدين";
            }
            else if(RAD == "مدين")
            {
                label_F.Visible = true;
                label_L.Visible = true;
                TXT_FNAME.Visible = true;
                TXT_LNAME.Visible = true;

                label_F.Text = "إسم المدين";
                label_L.Text = "إسم الدائن";
            }
                

            
                
            }

        private void DIEON_FORM_Load(object sender, EventArgs e)
        {

        }

        private void TXT_MONEY_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }
    }
    
}
