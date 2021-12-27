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
using ShopInvetoryManagement;

namespace BookShopManagement.Forms
{
    public partial class Customers_Pay : Form
    {
        ShopInvetoryManagement.DAL.DATAACCESSLAYER DAL = new ShopInvetoryManagement.DAL.DATAACCESSLAYER();
        //SqlCommand CMD;
        //SqlDataReader RED;
        Customer_Operation CUS = new Customer_Operation();
        Pos_Operation ope = new Pos_Operation();
        void GET_CUS_BILLS_ID()
        {
            
            DT = ope.GET_CUS_PAYMENTr_ID1();
            int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
            TXT_CODE.Text = id.ToString();

        }
        void GET_CUS_BILLS_ID1()
        {

            DT = ope.GET_CUS_PAYMENTr_ID();
            int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
            TXT_CODE.Text = id.ToString();

        }

        DataTable DT = new DataTable();
        void FILL_GRID()
        {

            DT = CUS.GET_ALL_PAYMENT_BY_CUSTOMER(Convert.ToInt32(COMBO_CUS.SelectedValue),Convert.ToInt16(TXT_PAY_NO.Text));
            GRID_Pay.DataSource = DT;
           // gridView1.Columns["رقم الطلب"].Visible = false;

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
        public void COM_ID()
        {
            COMBO_CUS.DataSource = CUS.GET_CUSTOMER_FULLNAME();
            COMBO_CUS.DisplayMember = "FULLNAME";
            COMBO_CUS.ValueMember = "CUS_ID";

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
            TXT_CODE.Enabled = SOL;
            TXT_BILL_DATE.Enabled = SOL;
            
            TXT_CODE.Enabled = SOL;
            TXT_MADFOOA.Enabled = SOL;
            TXT_MONEY.Enabled = SOL;
          
            TXT_TOTAL.Enabled = SOL;
            TXT_NOTE.Enabled = SOL;
            DATE_PAYMENT.Enabled = SOL;
        }
        public Customers_Pay()
        {
            InitializeComponent();
            TXT_EMP.Text = Program.Casheir;
            DATE_PAYMENT.Text = DateTime.Now.ToLongDateString();
            BT_SAVE.Enabled = false;
            BT_PAY.Enabled = false;
            
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BT_NEW_Click(object sender, EventArgs e)
        {
            DATE_PAYMENT.Text = DateTime.Now.ToShortDateString();

            SOLAFA(true);
            CLEAR_TEXT_BOX(this);
            GET_CUS_BILLS_ID();
            COM_ID();
           // get_CUSTOMER_DATA();
            BT_SAVE.Enabled = true;
            BT_NEW.Enabled = false;
            BT_PAY.Enabled = false;
            RAD_FIND.Checked = false;
            TXT_MONEY.Visible = false;
            LAB_MONEY.Visible = false;
            TXT_MADFOOA.Visible = false;
            lab_MADFO.Visible = false;
        }

       
        private void Customers_Pay_Load(object sender, EventArgs e)
        {
           
        }

        private void RAD_FIND_CheckedChanged(object sender, EventArgs e)
        {
            BT_SAVE.Enabled = false;
            BT_PAY.Enabled = true;
            BT_NEW.Enabled = true;
            TXT_BILL_DATE.Enabled = false;
            TXT_MADFOOA.Enabled = false;
            COM_ID();
            GET_CUS_BILLS_ID1();
            TXT_TOTAL.Enabled = false;
            TXT_MONEY.Visible = true;
            LAB_MONEY.Visible = true;
            TXT_MADFOOA.Visible = true;
            lab_MADFO.Visible = true;

            DATE_PAYMENT.Text = DateTime.Now.ToShortDateString();
           

        }

        private void BT_SAVE_Click(object sender, EventArgs e)
        {
            ope.add_customer_payment1(Convert.ToInt32(TXT_CODE.Text),Convert.ToInt32(TXT_PAY_NO.Text),Convert.ToInt32(COMBO_CUS.SelectedValue),Program.Casheir_ID,TXT_TOTAL.Text,TXT_MADFOOA.Text,TXT_MOTABAGI.Text,COMBO_PAYMENT.Text,DATE_PAYMENT.DateTime.Date,TXT_NOTE.Text, TXT_BILL_DATE.DateTime.Date);
            MessageBox.Show("تمت إضافة الدفعة ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CLEAR_TEXT_BOX(this);
            BT_SAVE.Enabled = false;
            BT_PAY.Enabled = false;
            BT_NEW.Enabled = true;
        }

        private void BT_PAY_Click(object sender, EventArgs e)
        {
            if(TXT_TOTAL.Text == TXT_MADFOOA.Text)
            {
                MessageBox.Show("تنبيه ! , تم سداد قيمة المبلغ");
                return;
                    
            }
            ope.update_paid_pay2(Convert.ToInt32(TXT_CODE.Text), Convert.ToInt32(TXT_PAY_NO.Text), Convert.ToInt32(COMBO_CUS.SelectedValue), Program.Casheir_ID,TXT_MONEY.Text, COMBO_PAYMENT.Text, DATE_PAYMENT.DateTime.Date, TXT_NOTE.Text, TXT_BILL_DATE.DateTime.Date);
            MessageBox.Show("تمت سداد دفعة جديدة ", "عملية السداد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FILL_GRID();
            ope.update_paid_pay(Convert.ToInt32(TXT_PAY_NO.Text), Convert.ToInt32(COMBO_CUS.SelectedValue), TXT_MONEY.Text, PAY_NO);

            CLEAR_TEXT_BOX(this);
            BT_SAVE.Enabled = false;
            BT_PAY.Enabled = false;
            BT_NEW.Enabled = true;
            RAD_FIND.Checked = false;
        }

        private void BT_CANCEL_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void COMBO_CUS_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  get_CUSTOMER_DATA();
        }

        private void TXT_TOTAL_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void TXT_MADFOOA_KeyUp(object sender, KeyEventArgs e)
        {
           
          

        }

      

        private void TXT_PAY_NO_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DataTable DT = ope.search_PAY1(Convert.ToInt32(TXT_PAY_NO.Text),Convert.ToInt32(COMBO_CUS.SelectedValue));
                if (DT.Rows.Count > 0)
                {

                    PAY_NO = Convert.ToInt32(DT.Rows[0]["PAY_NO"]);  
                    string PAY_DATE  = DT.Rows[0]["PILLS_DATE"].ToString();

                        string TOT = (DT.Rows[0]["TOTAL"]).ToString();
                        string MADFO = (DT.Rows[0]["MADFOOA"]).ToString();
                        string MOTABG = (DT.Rows[0]["MOTABAGI"]).ToString();


                   // = PAY_NO.ToString();
                    TXT_BILL_DATE.DateTime =Convert.ToDateTime(PAY_DATE);

                    TXT_TOTAL.Text = TOT.ToString();
                    TXT_MADFOOA.Text = MADFO.ToString();
                    TXT_MOTABAGI.Text = MOTABG.ToString();

                    FILL_GRID();

                    // This line of code is generated by Data Source Configuration Wizard
                    // Fill a SqlDataSource
                   
                    //sqlDataSource1.Fill();

                }
                }

            }
        int PAY_NO;
        private void TXT_MONEY_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }

        private void TXT_PAY_NO_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);
        }

        private void TXT_TOTAL_Leave(object sender, EventArgs e)
        {
            try
            {
                double TOTAL = Convert.ToDouble(TXT_TOTAL.Text);
                double MADFO = Convert.ToDouble(TXT_MADFOOA.Text);

                double MOTABG = TOTAL - MADFO;
                TXT_MOTABAGI.Text = MOTABG.ToString();
            }
            catch
            {
                return;

            }
        }
    }
    }

