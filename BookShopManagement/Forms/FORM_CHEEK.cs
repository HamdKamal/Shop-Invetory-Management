using BookShopManagement.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopInvetoryManagement.Forms;
using ShopInvetoryManagement.BL;
using BookShopManagement;

namespace ShopInvetoryManagement.Forms
{
    public partial class FORM_CHEEK : Form
    {
        public string RAD = "";
        Another_Finance ope = new Another_Finance();
        Bank_Operation BNK = new Bank_Operation();
        ShopInvetoryManagement.DAL.DATAACCESSLAYER DAL = new ShopInvetoryManagement.DAL.DATAACCESSLAYER();
        void GET_SAHAAB_ID()
        {
            DataTable DT = new DataTable();
            DT = ope.GET_SAHAAB_ID();
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
        void GET_TORREEID_ID()
        {
            DataTable DT = new DataTable();
            DT = ope.GET_TORREEID_ID();
            int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
            TXT_ID1.Text = id.ToString();
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


            //RAD_SAAHB.Enabled = SOL;
            //RAD_TORRIED.Enabled = SOL;
            //RAD_SAAHB.Checked = SOL;
            //RAD_TORRIED.Checked = SOL;   
        }
        public void COM_ID()
        {
            BANK_MORD.DataSource = BNK.GetBank_Data();
            BANK_MORD.DisplayMember = "Bank_Name";
            BANK_MORD.ValueMember = "Bank_ID";

        }
        public FORM_CHEEK()
        {
            InitializeComponent();
            TXT_EMP.Text = Program.Casheir;
            TXTT_EMP.Text = Program.Casheir;
            DATE_OPE.Text = DateTime.Now.ToLongDateString();
            DATE_ESTLAM.Text = DateTime.Now.ToLongDateString();
            DATE_RECIPT.Text = DateTime.Now.ToLongDateString();
            DATE_TORREID.Text = DateTime.Now.ToLongDateString();
            DATE_OPE1.Text = DateTime.Now.ToLongDateString();
            BT_SAVE.Enabled = false;

        }

        private void RAD_SAAHB_CheckedChanged(object sender, EventArgs e)
        {
            RAD = "سحب";
            PANEL_SAHHAP.Visible = true;
            PANAL_TORRIED.Visible = false;
            GET_SAHAAB_ID();
            //moveSidePanel2(RAD_SAAHB);
            //UC_Sales uch = new UC_Sales();
            //AddControlsToPanel2(uch);
        }

        private void RAD_TORRIED_CheckedChanged(object sender, EventArgs e)
        {
            RAD = "توريد";
            PANAL_TORRIED.Visible = true;
            PANEL_SAHHAP.Visible = false;
            GET_TORREEID_ID();
            COM_ID();
            //moveSidePanel2(RAD_TORRIED);
            //UC_ManageUser uch = new UC_ManageUser();
            //AddControlsToPanel2(uch);
        }

        private void FORM_CHEEK_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //moveSidePanel2(button1);
            //UC_ManageUser uch = new UC_ManageUser();
            //AddControlsToPanel2(uch);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //moveSidePanel2(button2);
            //UC_Sales uch = new UC_Sales();
            //AddControlsToPanel2(uch);
        }

        private void PANAL_TORRIED_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BT_BACK_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void BT_NEW_Click(object sender, EventArgs e)
        {
            PANAL_TORRIED.Visible = false;
            PANEL_SAHHAP.Visible = false;
            RAD_SAAHB.Enabled = true;
            RAD_TORRIED.Enabled = true;
            RAD_SAAHB.Checked = false;
            RAD_TORRIED.Checked = false;
            DATE_OPE.Text = DateTime.Now.ToShortDateString();
            DATE_ESTLAM.Text = DateTime.Now.ToShortDateString();
            DATE_OPE1.Text = DateTime.Now.ToShortDateString();
            DATE_TORREID.Text = DateTime.Now.ToShortDateString();
            DATE_RECIPT.Text = DateTime.Now.ToShortDateString();
           
            //  SOLAFA(true);
            CLEAR_TEXT_BOX(this);
            BT_SAVE.Enabled = true;
            BT_NEW.Enabled = false;
          //  COM_ID();
        }

        private void BT_SAVE_Click(object sender, EventArgs e)
        {
           
            if (RAD == "سحب")
            {
                ope.ADD_TO_SAHAAP(Convert.ToInt16(TXT_ID.Text),RAD  ,TXT_BANK_NAME.Text,TXT_CHECK.Text,TXT_FNAME.Text,TXT_LNAME.Text,TXT_BANK_WONER.Text,TXT_3NAME.Text,TXT_MONEY.Text,DATE_RECIPT.DateTime.Date,Program.Casheir_ID,DATE_OPE.DateTime.Date);
            }
            else
            {
                ope.ADD_TO_TORREEID(Convert.ToInt16(TXT_ID1.Text),RAD,BANK_MORD.Text,CHECK_NO.Text,FRIST.Text,SECOND.Text,WONER_BANK.Text,
                    DATE_TORREID.DateTime.Date,T_MONEY.Text,DATE_ESTLAM.DateTime.Date,Program.Casheir_ID,DATE_OPE1.DateTime.Date);

            }

            MessageBox.Show("تمت إضافة المعاملة ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CLEAR_TEXT_BOX(this);
            BT_NEW.Enabled = true;
            BT_SAVE.Enabled = false;       
            SOLAFA(false);

            RAD_SAAHB.Enabled = false;
            RAD_TORRIED.Enabled = false;
            RAD_SAAHB.Checked = false;
            RAD_TORRIED.Checked = false;

            RAD_SAAHB.Visible = false;
            RAD_TORRIED.Visible = false;
            DATE_OPE.Text = DateTime.Now.ToLongDateString();
          

        }

        private void TXT_CHECK_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }

        private void TXT_MONEY_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }

        private void T_MONEY_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }

        private void CHECK_NO_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }
    }
}


//moveSidePanel2(btnHome);
////UC_Home uch = new UC_Home();
////AddControlsToPanel2(uch);