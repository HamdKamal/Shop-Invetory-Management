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
using DevExpress.XtraReports.UI;
using ShopInvetoryManagement.REPORT;
using ShopInvetoryManagement.Forms;

namespace BookShopManagement.Forms
{

    public partial class Form_FinishOrder : Form
    {
        string bar; string Z;
        ShopInvetoryManagement.DAL.DATAACCESSLAYER DAL = new ShopInvetoryManagement.DAL.DATAACCESSLAYER();
        SqlCommand CMD;
        SqlDataReader RED;

        ShopInvetoryManagement.Forms.gridview gr = new ShopInvetoryManagement.Forms.gridview();
       LOG_FORM f1 = new LOG_FORM();
        Customer_Operation CUS = new Customer_Operation();
        Pos_Operation ope = new Pos_Operation();

        void invoice()
        {
            REPORT_ZBAAAEN TK = new REPORT_ZBAAAEN();
            TK.Parameters["BILLS_NO"].Value = Convert.ToInt32(LBL_BILL_NO.Text);
            ReportPrintTool printTool = new ReportPrintTool(TK);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
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


        void GET_CUS_BILLS_ID()
        {
            DataTable DT = new DataTable();
            DT = ope.GET_CUS_BILLS_ID();
            int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
            TXT_BILLS_ID.Text = id.ToString();

        }
        string sql;
        public void LOAD_None_Customer_BILLS()
        {
            double totalprice;
            try
            {
                sql = "SELECT  TC.PRD_BARCODE, PRD_NAME,SALE_QUAN,isNull(PRICE,0),SALE_TOTAL FROM TBL_NONECUSTOMER_BILLS TC INNER JOIN TBL_PRODUCTS P ON P.PRD_BARCODE = TC.PRD_BARCODE WHERE TC.BILLS_NO ='" + TXT_BILLS_ID.Text + "'";

                cmd = new SqlCommand(sql, DAL.sqlconnection);
                DAL.open();
                RED = cmd.ExecuteReader();

                ListViewItem x;
                this.ListView1.Items.Clear();
                totalprice = 0;

                while (RED.Read())
                {
                    totalprice = totalprice + Convert.ToDouble(RED[4]);
                    x = new ListViewItem(RED[1].ToString());
                    x.SubItems.Add(RED[2].ToString());
                    x.SubItems.Add(RED[3].ToString());
                    x.SubItems.Add(RED[4].ToString());
                    x.SubItems.Add(RED[0].ToString());

                    Z = RED[0].ToString();
                    // MessageBox.Show(Z);
                    this.ListView1.Items.Add(x);
                }

                {
                    var withBlock = this;
                    withBlock.LBL_TOTAL_PRICE.Text = String.Format(totalprice.ToString(), "N2").ToString();
                    withBlock.LBL_BILL_PRICE.Text = String.Format(totalprice.ToString(), "N2").ToString();
                }
            }
            catch
            {
                return;
            }
            finally
            {
                cmd.Dispose();
                DAL.close();
            }
        }


        public void LOAD_CUSTOMER_BILLS()
        {
            double totalprice;
            try
            {
                sql = "SELECT  TC.PRD_BARCODE, PRD_NAME,SALE_QUAN,isNull(PRICE,0),SALE_TOTAL FROM TBL_BILLS_CUSTOMER TC INNER JOIN TBL_PRODUCTS P ON P.PRD_BARCODE = TC.PRD_BARCODE WHERE TC.BILLS_NO ='" + TXT_BILLS_ID.Text + "'";

                cmd = new SqlCommand(sql, DAL.sqlconnection);
                DAL.open();
                RED = cmd.ExecuteReader();

                ListViewItem x;
                this.ListView1.Items.Clear();
                totalprice = 0;

                while (RED.Read())
                {
                    totalprice = totalprice + Convert.ToDouble(RED[4]);
                    x = new ListViewItem(RED[1].ToString());
                    x.SubItems.Add(RED[2].ToString());
                    x.SubItems.Add(RED[3].ToString());
                    x.SubItems.Add(RED[4].ToString());
                    x.SubItems.Add(RED[0].ToString());

                    bar = RED[0].ToString();
                    // MessageBox.Show(Z);
                    this.ListView1.Items.Add(x);
                }

                {
                    var withBlock = this;
                    withBlock.LBL_TOTAL_PRICE.Text = String.Format(totalprice.ToString(), "N2").ToString();
                    withBlock.LBL_BILL_PRICE.Text = String.Format(totalprice.ToString(), "N2").ToString();
                }
            }
            catch
            {
                return;
            }
            finally
            {
                cmd.Dispose();
                DAL.close();
            }
        }

        void GET_NONE_CUS_BILLS_ID()
        {
            DataTable DT = new DataTable();
            DT = ope.GET_NONE_CUS_BILLS_ID();
            int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
            TXT_BILLS_ID.Text = id.ToString();
        }

        void CLEAR_TEXT_BOX()
        {
            TXT_BARCODE.Text = "";
            TXT_NEED_QUAN.Text = "";
            TXT_TOTAL_PRICE.Text = "";
            TXT_BRD_QUAN.Text = "0";
            TXT_SELLING_PRICE.Text = "";
            TXT_PRD_NAME.Text = "";

        }

        public void COM_ID()
        {
            COMBO_CUST.DataSource = CUS.GET_CUSTOMER_FULLNAME();
            COMBO_CUST.DisplayMember = "FULLNAME";
            COMBO_CUST.ValueMember = "CUS_ID";

        }
        //public void SEARCH_PRODUCT()
        //{
        //    COMBO_SEARCH.DataSource = ope.SEARCH_PRODUCT();
        //    COMBO_SEARCH.DisplayMember = "PRD_NAME";
        //    COMBO_SEARCH.ValueMember = "PRD_BARCODE";

        //}


        public DataTable DT = new DataTable();
        //void FILL_GRID()
        //{

        //    GRIDVIEW_POS.DataSource = ope.GET_POS_NONE_CUSTOMER(Convert.ToInt16(TXT_BILLS_ID.Text));
        //    //GRIDVIEW_POS.Columns[0].Visible = false;
        //    //MessageBox.Show(TXT_BILLS_ID.Text.ToString());
        //}

        //void FILL_GRID1()
        //{


        //    GRIDVIEW_POS.DataSource = ope.GET_POS_CUSTOMER(Convert.ToInt16(TXT_BILLS_ID.Text));
        //    // GRIDVIEW_POS.Columns[0].Visible = false;  
        //   // MessageBox.Show(TXT_BILLS_ID.Text.ToString());
        //}
        public Form_FinishOrder()
        {
            InitializeComponent();
            sqlDataSource1.Fill();
            //SEARCH_PRODUCT();
            // LOAD_CUSTOMER_BILLS();
            //This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource

            //This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_FinishOrder_Load(object sender, EventArgs e)
        {
            //DATE_BILL.Text = DateTime.Now.ToShortDateString();
            // TODO: This line of code loads data into the 'lang_DataBaseDataSet.SEARCH_PRODUCT' table. You can move, or remove it, as needed.
           // this.sEARCH_PRODUCTTableAdapter.GetData();
            // SEARCH_PRODUCT();
            LOG_FORM f = new LOG_FORM();
            f.log_name = TXT_EMBLOYEE.Text;
            DATE_BILL.Text = DateTime.Now.ToLongDateString();
            BT_CANCEL.Enabled = false;
            BT_DEL.Enabled = false;
            BT_PAY.Enabled = false;
            BT_PRINT.Enabled = false;
            //RAD_NAME.Checked = false;
            //RAD_CUST.Checked = false;
            TXT_NAME.Visible = false;
            COMBO_CUST.Visible = false;
            COMBO_SALE_TYPE.Enabled = false;
            //RAD_CUST.Visible = false;
            //RAD_NAME.Visible = false;
            LBL_DATE.Text = DateTime.Now.ToString();
            TXT_NEED_QUAN.Text = "0";
            TXT_TOTAL_PRICE.Text = "0";
          

        }

        private void BT_NEW_Click(object sender, EventArgs e)
        {


        }

        private void BT_EXIT_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void RAD_NAME_CheckedChanged(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX();
            BT_PAY.Enabled = true;
            BT_CANCEL.Enabled = true;
            BT_PRINT.Enabled = true;
            BT_REPORT.Enabled = false;

            if (RAD_NAME.Checked is true)
            {

                TXT_NAME.Visible = true;
                RAD_CUST.Visible = false;
                RAD_CUST.Checked = false;
                COMBO_CUST.Visible = false;
                GET_NONE_CUS_BILLS_ID();
                LBL_BILL_NO.Text = TXT_BILLS_ID.Text;
                DATE_BILL.Text = DateTime.Now.ToShortDateString();
                TXT_EMBLOYEE.Text = Program.Casheir;
            }
        }

        private void RAD_CUST_CheckedChanged(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX();
            BT_PAY.Enabled = true;
            BT_PRINT.Enabled = false;
            BT_CANCEL.Enabled = true;
            BT_REPORT.Enabled = true;

            if (RAD_CUST.Checked is true)
            {
                TXT_NAME.Visible = false;
                RAD_NAME.Visible = false;
                RAD_NAME.Checked = false;
                COMBO_CUST.Visible = true;
                GET_CUS_BILLS_ID();
                COM_ID();
                LBL_BILL_NO.Text = TXT_BILLS_ID.Text;
                BT_PRINT.Enabled = false;
                DATE_BILL.Text = DateTime.Now.ToShortDateString();
                TXT_EMBLOYEE.Text = Program.Casheir;
            }
        }
        public int SD, ZD;

        private void TXT_BARCODE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                COMBO_SALE_TYPE.Enabled = true;
                CMD = new SqlCommand("SELECT * FROM TBL_PRODUCTS WHERE PRD_BARCODE = @BarCode", DAL.sqlconnection);
                CMD.Parameters.Add(new SqlParameter("@BarCode", TXT_BARCODE.Text));
                DAL.open();
                RED = CMD.ExecuteReader();
                if (RED.Read() == true)
                {
                    TXT_PRD_NAME.Text = RED.GetString(2);
                    TXT_NOTE.Text = RED.GetString(9);
                    TXT_BRD_QUAN.Text = Convert.ToString(RED.GetValue(3));
                    I = Convert.ToString(RED.GetValue(7));
                    X = Convert.ToString(RED.GetValue(8));
                    COMBO_SEARCH.Text = "";
                }
                else
                {
                    MessageBox.Show("هذا المنتج غير موجود", "إشعار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                RED.Close();
                DAL.close();
            }

        }
        string X, I;
        private SqlCommand cmd;

        private void TXT_NEED_QUAN_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                Decimal PRICE = Convert.ToDecimal(TXT_SELLING_PRICE.Text);
                Decimal QUN = Convert.ToDecimal(TXT_NEED_QUAN.Text);
                Decimal TOTAL_PRICE = QUN * PRICE;
                TXT_TOTAL_PRICE.Text = TOTAL_PRICE.ToString();
            }
            catch
            {
                return;
            }

        }

        private void TXT_NEED_QUAN_KeyDown(object sender, KeyEventArgs e)
        {



        }

        private void BT_PRINT_Click(object sender, EventArgs e)
        {
            BT_PAY.Enabled = false;
            BT_PRINT.Enabled = false;
            BT_CANCEL.Enabled = false;

            this.Cursor = Cursors.WaitCursor;
            POS_BILLS TK = new POS_BILLS();
            TK.Parameters["BILLS_NO"].Value = Convert.ToInt32(LBL_BILL_NO.Text);
            ReportPrintTool printTool = new ReportPrintTool(TK);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
            this.Cursor = Cursors.Default;
            invoice();
            TXT_BILLS_ID.Text = "0";
            LBL_BILL_NO.Text = "0";
            ListView1.Items.Clear();
            LOAD_None_Customer_BILLS();

            BT_CANCEL.Enabled = false;
            RAD_NAME.Visible = true;
            RAD_NAME.Checked = false;
            RAD_CUST.Visible = true;
            RAD_CUST.Checked = false;
            TXT_NAME.Visible = true;
            COMBO_CUST.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BT_PAY.Enabled = false;
            BT_PRINT.Enabled = false;
            BT_CANCEL.Enabled = false;
            BT_REPORT.Enabled = false;

            this.Cursor = Cursors.WaitCursor;
            REPORT_POS TK = new REPORT_POS();
            TK.Parameters["BILLS_NO"].Value = Convert.ToInt32(LBL_BILL_NO.Text);
            ReportPrintTool printTool = new ReportPrintTool(TK);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
            this.Cursor = Cursors.Default;
            TXT_BILLS_ID.Text = "0";
            ListView1.Items.Clear();
            LOAD_CUSTOMER_BILLS();


            BT_CANCEL.Enabled = false;
            RAD_NAME.Visible = true;
            RAD_NAME.Checked = false;
            RAD_CUST.Visible = true;
            RAD_CUST.Checked = false;
            TXT_NAME.Visible = true;
            COMBO_CUST.Visible = true;
        }

        private void COMBO_SEARCH_EditValueChanged(object sender, EventArgs e)
        {

            COMBO_SALE_TYPE.Enabled = true;
            CMD = new SqlCommand("SELECT * FROM TBL_PRODUCTS WHERE PRD_BARCODE = @BarCode", DAL.sqlconnection);
            CMD.Parameters.Add(new SqlParameter("@BarCode", COMBO_SEARCH.EditValue.ToString()));
            DAL.open();
            RED = CMD.ExecuteReader();
            if (RED.Read() == true)
            {
                TXT_PRD_NAME.Text = RED.GetString(2);
                TXT_NOTE.Text = RED.GetString(9);
                TXT_BARCODE.Text = RED.GetString(1);
                TXT_BRD_QUAN.Text = Convert.ToString(RED.GetValue(3));
                I = Convert.ToString(RED.GetValue(7));
                X = Convert.ToString(RED.GetValue(8));
            }
            else
            {
                MessageBox.Show("هذا المنتج غير موجود", "إشعار", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            RED.Close();
            DAL.close();
        }


        private void TXT_BARCODE_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_NAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_NEED_QUAN_TextChanged(object sender, EventArgs e)
        {


        }

        private void TXT_NEED_QUAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(e);

        }

        private void TXT_NEED_QUAN_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TXT_NEED_QUAN.Text) > Convert.ToInt32(TXT_BRD_QUAN.Text))
                {
                    TXT_NEED_QUAN.Focus();
                    MessageBox.Show("انتبه ! الكمية المطلوبه تعدت الكمية الموجودة في المخزن");
                }
            }
            catch
            {
                return;

            }

        }

        private void BT_CANCEL_Click(object sender, EventArgs e)
        {
            
            

            if (ListView1.Items.Count > 0 )
            {
                MessageBox.Show("تنبيه ! الرجاء مسح جميع المنتجات الموجودة في القائمة");
                BT_CANCEL.Enabled = true;
                BT_PAY.Enabled = true;
                return;
                
            }

            if (MessageBox.Show("هل أنت متأكد من الغاء الفاتورة ؟", " تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
               MessageBox.Show("تنبيه ! تم إلغاء الفاتورة");
                BT_PRINT.Enabled = false;
                BT_PAY.Enabled = false;
                BT_DEL.Enabled = false;
            }
            BT_PRINT.Enabled = false;
            BT_PAY.Enabled = false;
            BT_DEL.Enabled = false;
            BT_CANCEL.Enabled = false;
            RAD_NAME.Visible = true;
            RAD_NAME.Checked = false;
            RAD_CUST.Visible = true;
            RAD_CUST.Checked = false;
            TXT_NAME.Visible = true;
            COMBO_CUST.Visible = true;
        }

        private void BT_DEL_Click(object sender, EventArgs e)
        {            
            try
            {
                if (ListView1.FocusedItem.Selected == false)
                {
                    MessageBox.Show("تنبيه ! الرجاء إختيار منتج من القائمة  ");
                    return;
                }

                else if (MessageBox.Show("  هل تريد حذف هذا المنتج   ", " تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    M = ListView1.SelectedItems[0].SubItems[4].Text;
                    Q = ListView1.SelectedItems[0].SubItems[1].Text;

                    if (RAD_NAME.Checked == true)
                    {
                   
                        ope.INCREASE_QUANTITY(Convert.ToInt32(Q),M);
                        ope.DELETE_ORDER_NONE(M, Convert.ToInt16(TXT_BILLS_ID.Text));
                        MessageBox.Show("تم حذف المنتج");
                        LOAD_None_Customer_BILLS();
                    }
                   else
                    {
                        //M = ListView1.SelectedItems[0].SubItems[4].Text;
                        ope.INCREASE_QUANTITY(Convert.ToInt32(Q), M);
                        ope.DELETE_ORDER(M, Convert.ToInt16(TXT_BILLS_ID.Text));
                        MessageBox.Show("تم حذف المنتج");
                        LOAD_CUSTOMER_BILLS();
                    }
                        }
            }
            catch
            {
                return;
            }


          
        }
        string Q;
        private void ListView1_Click(object sender, EventArgs e)
        {
        
        }

        string M = "";
        private void LBL_TOTAL_PRICE_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void sEARCHPRODUCTBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void BT_PAY_Click(object sender, EventArgs e)
        {

                if (TXT_BARCODE.Text == "" || TXT_BRD_QUAN.Text == "0" || TXT_PRD_NAME.Text == "" )
                {
                    MessageBox.Show("الرجاء ملء الحقول أولاً", "إشعار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                foreach (ListViewItem ITEM in ListView1.Items)
            {
                string MESS = ITEM.SubItems[4].Text.ToString();
                if (TXT_BARCODE.Text == MESS)
                {
                    MessageBox.Show("تنبيه ! تم إضافة هذا المنتج ");
                    return;
                }

               // string MESS += ITEM.SubItems[4].Text.ToString();
            }
              try
                { 
                if (RAD_NAME.Checked== true)
                {
                    Random ran = new Random();
                    int genrandom = ran.Next(1, 100000);

                    ope.ADD_BILL_NONECUSTOMER(Convert.ToInt16(TXT_BILLS_ID.Text),TXT_NAME.Text,Program.Casheir_ID,COMBO_SALE_TYPE.Text,TXT_BARCODE.Text,Convert.ToInt16(TXT_NEED_QUAN.Text),TXT_TOTAL_PRICE.Text,DATE_BILL.DateTime.Date,TXT_SELLING_PRICE.Text);
                    ope.ADD_POS_NONE_CUS(genrandom, Convert.ToInt16(TXT_BILLS_ID.Text),TXT_NAME.Text,TXT_BARCODE.Text);
                    ope.Min_Quan(Convert.ToInt16(TXT_NEED_QUAN.Text), TXT_BARCODE.Text);
                    

                    MessageBox.Show("تم شراء المنتج", "شراء المنتج", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LOAD_None_Customer_BILLS();
                    CLEAR_TEXT_BOX();
                    COMBO_SALE_TYPE.SelectedText = "";
                    TXT_BRD_QUAN.Text = "0";
                    COMBO_SALE_TYPE.Text = "";
                }
                else
                {
                    Random ran = new Random();
                    int genrandom = ran.Next(1, 100000);

                    ope.ADD_BILL_CUSTOMER(Convert.ToInt16(TXT_BILLS_ID.Text),Convert.ToInt16(COMBO_CUST.SelectedValue), Program.Casheir_ID, COMBO_SALE_TYPE.Text, TXT_BARCODE.Text, Convert.ToInt16(TXT_NEED_QUAN.Text), TXT_TOTAL_PRICE.Text, DATE_BILL.DateTime.Date,TXT_SELLING_PRICE.Text);
                    ope.ADD_POS_CUSTOMER(genrandom, Convert.ToInt16(TXT_BILLS_ID.Text), TXT_BARCODE.Text,Convert.ToInt16(COMBO_CUST.SelectedValue));
                    ope.Min_Quan(Convert.ToInt16(TXT_NEED_QUAN.Text), TXT_BARCODE.Text);
                   

                    MessageBox.Show("تم شراء المنتج", "شراء المنتج", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LOAD_CUSTOMER_BILLS();
                    CLEAR_TEXT_BOX();                  
                    TXT_BRD_QUAN.Text = "0";
                    COMBO_SALE_TYPE.SelectedText = "";
                    COMBO_SALE_TYPE.Text = "";
                }      
            }
            catch
            {
                return;
            }
            DATE_BILL.Text = DateTime.Now.ToShortDateString();
            BT_DEL.Enabled = true;
        }

        private void COMBO_SALE_TYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(COMBO_SALE_TYPE.Text == "بيع جملة")
            {
                SD = 1;
                TXT_SELLING_PRICE.Text = X;
                
            }
            else
            {
                SD = 2;
                TXT_SELLING_PRICE.Text = I;
            }
              
        }
    }
}
