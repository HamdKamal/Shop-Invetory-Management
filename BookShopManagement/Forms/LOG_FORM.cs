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
using ShopInvetoryManagement.Forms;
using BookShopManagement.Forms;
using BookShopManagement;

namespace ShopInvetoryManagement.Forms
{
    public partial class LOG_FORM : Form
    {
        public int log_id;
        public string log_name;
        MAIN_FORM fm = new MAIN_FORM();
        Employees emp = new Employees();
        Customers cus = new Customers();
        ADD_BANK bank = new ADD_BANK();
        ADD_STORAGE stg = new ADD_STORAGE();
        UserForm uform = new UserForm();

        User_Operation LOG = new User_Operation();

        public void check()
        {
            string lo_name = TXT_NAME.Text;
            string lo_pass = TXT_PASS.Text;
            string CO_TYPE = CMBO_TYPE.Text;


            if (TXT_NAME.Text == string.Empty | TXT_PASS.Text == string.Empty)
            {
                MessageBox.Show("!يوجد خطأ في تسجيل الدخول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable DT = LOG.GetUser_Data(CMBO_TYPE.Text, TXT_NAME.Text, TXT_PASS.Text);
            if (DT.Rows.Count > 0)
            {
                if (DT.Rows[0][1].ToString() == "مدير النظام")
                {
                    Program.ISuser = false;
                    log_name = DT.Rows[0]["User_Name"].ToString();
                    Program.Casheir = DT.Rows[0]["User_Name"].ToString();
                    log_id = Convert.ToInt16(DT.Rows[0]["User_ID"]);
                    Program.Casheir_ID = Convert.ToInt16(DT.Rows[0]["User_ID"]);
                    fm.lbl_type.Text = "مدير النظام";
                    fm.lbl_name.Text = log_name.ToString();

                    fm.toolStripMenuItem10.Enabled = Convert.ToBoolean(DT.Rows[0]["POS"]);
                    fm.toolStripMenuItem13.Enabled = Convert.ToBoolean(DT.Rows[0]["CUS_PAY"]);
                    fm.toolStripMenuItem7.Enabled = Convert.ToBoolean(DT.Rows[0]["BAC_RES"]);
                    fm.toolStripMenuItem15.Enabled = Convert.ToBoolean(DT.Rows[0]["SHECKAT"]);
                    fm.toolStripMenuItem16.Enabled = Convert.ToBoolean(DT.Rows[0]["DIEON"]);

                    fm.toolStripMenuItem28.Enabled = Convert.ToBoolean(DT.Rows[0]["USER_PERM"]);
                    fm.toolStripMenuItem4.Enabled = Convert.ToBoolean(DT.Rows[0]["BANK_OPE"]);
                    fm.toolStripMenuItem14.Enabled = Convert.ToBoolean(DT.Rows[0]["STG_OPE"]);
                    fm.toolStripMenuItem2.Enabled = Convert.ToBoolean(DT.Rows[0]["BILLS_FORM"]);


                    fm.toolStripMenuItem12.Enabled = Convert.ToBoolean(DT.Rows[0]["CUSTOMER"]);
                    fm.toolStripMenuItem5.Enabled = Convert.ToBoolean(DT.Rows[0]["EMPLOYEE"]);
                    fm.toolStripMenuItem3.Enabled = Convert.ToBoolean(DT.Rows[0]["BANK_ADD"]);
                    fm.toolStripMenuItem1.Enabled = Convert.ToBoolean(DT.Rows[0]["NEW_PRODCT"]);

                    fm.إضافةالأصنافToolStripMenuItem.Enabled = Convert.ToBoolean(DT.Rows[0]["CATEGORY"]);
                    fm.إضافةخزنةToolStripMenuItem.Enabled = Convert.ToBoolean(DT.Rows[0]["ADD_STORAGE"]);
                    fm.المخزنToolStripMenuItem.Enabled = Convert.ToBoolean(DT.Rows[0]["ADD_STOCK"]);

                    this.Hide();
                    fm.ShowDialog();
                   
                }
            }
            if (DT.Rows.Count > 0)
            {
                if (DT.Rows[0][1].ToString() == "الموظف")
                {
                    Program.ISuser = true;
                    log_name = DT.Rows[0]["User_Name"].ToString();
                    Program.Casheir = DT.Rows[0]["User_Name"].ToString();
                    log_id = Convert.ToInt16(DT.Rows[0]["User_ID"]);
                    Program.Casheir_ID = Convert.ToInt16(DT.Rows[0]["User_ID"]);
                    fm.lbl_name.Text = log_name.ToString();
                    fm.lbl_type.Text = "موظف";

                    fm.toolStripMenuItem10.Enabled = Convert.ToBoolean(DT.Rows[0]["POS"]);
                    fm.toolStripMenuItem13.Enabled = Convert.ToBoolean(DT.Rows[0]["CUS_PAY"]);
                    fm.toolStripMenuItem7.Enabled = Convert.ToBoolean(DT.Rows[0]["BAC_RES"]);
                    fm.toolStripMenuItem15.Enabled = Convert.ToBoolean(DT.Rows[0]["SHECKAT"]);
                    fm.toolStripMenuItem16.Enabled = Convert.ToBoolean(DT.Rows[0]["DIEON"]);

                    fm.toolStripMenuItem28.Enabled = Convert.ToBoolean(DT.Rows[0]["USER_PERM"]);
                    fm.toolStripMenuItem4.Enabled = Convert.ToBoolean(DT.Rows[0]["BANK_OPE"]);
                    fm.toolStripMenuItem14.Enabled = Convert.ToBoolean(DT.Rows[0]["STG_OPE"]);
                    fm.toolStripMenuItem2.Enabled = Convert.ToBoolean(DT.Rows[0]["BILLS_FORM"]);


                    fm.toolStripMenuItem12.Enabled = Convert.ToBoolean(DT.Rows[0]["CUSTOMER"]);                   
                    fm.toolStripMenuItem5.Enabled = Convert.ToBoolean(DT.Rows[0]["EMPLOYEE"]);
                    fm.toolStripMenuItem3.Enabled = Convert.ToBoolean(DT.Rows[0]["BANK_ADD"]);
                    fm.toolStripMenuItem1.Enabled = Convert.ToBoolean(DT.Rows[0]["NEW_PRODCT"]);

                    fm.إضافةالأصنافToolStripMenuItem.Enabled = Convert.ToBoolean(DT.Rows[0]["CATEGORY"]);
                    fm.إضافةخزنةToolStripMenuItem.Enabled = Convert.ToBoolean(DT.Rows[0]["ADD_STORAGE"]);
                    fm.المخزنToolStripMenuItem.Enabled = Convert.ToBoolean(DT.Rows[0]["ADD_STOCK"]);

                    fm.toolStripMenuItem27.Enabled = false;
                    fm.toolStripMenuItem11.Enabled = false;
                    fm.toolStripMenuItem17.Enabled = false;
                    fm.toolStripMenuItem6.Enabled = true;

                    this.Hide();
                    fm.ShowDialog();
                   
                }
            }
            else
                MessageBox.Show("!فشل تسجيل الدخول", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
        public LOG_FORM()
        {
            InitializeComponent();
        }

        private void BT_OK_Click(object sender, EventArgs e)
        {
            check();
        }

        private void LOG_FORM_Load(object sender, EventArgs e)
        {
            try
            {
                if (ShopInvetoryManagement.Properties.Settings.Default.Counter >= 1)
                    return;
                else if (ShopInvetoryManagement.Properties.Settings.Default.Counter == 0)
                {
                    Server_Confiq SYS = new Server_Confiq();
                    SYS.ShowDialog();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("فشل الإتصال بالسيرفر");
            }
            TXT_NAME.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
