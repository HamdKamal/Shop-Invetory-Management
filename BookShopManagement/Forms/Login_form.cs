using BookShopManagement.Forms;
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

namespace BookShopManagement 
{
    public partial class Form1 : Form
    {
        public int log_id;
        public string log_name;
        Form_Dashboard fm = new Form_Dashboard();
        User_Operation LOG = new User_Operation();   
        public void check()
        {
            string lo_name = TXT_NAME.Text;
            string lo_pass = TXT_PASS.Text;
            string CO_TYPE =  CMBO_TYPE.Text;
            

            if (TXT_NAME.Text == string.Empty | TXT_PASS.Text == string.Empty)
            {
                MessageBox.Show("!يوجد خطأ في تسجيل الدخول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable DT = LOG.GetUser_Data(CMBO_TYPE.Text , TXT_NAME.Text, TXT_PASS.Text);
            if (DT.Rows.Count > 0)
            {
                if (DT.Rows[0][1].ToString() == "مدير النظام")
                {
                    log_name = DT.Rows[0]["User_Name"].ToString();
                    log_id = Convert.ToInt16( DT.Rows[0]["User_ID"]);
                    fm .lbl_type.Text = "مدير النظام";
                    fm .lbl_name.Text = log_name.ToString();
                    this.Hide();
                    fm.ShowDialog();
                }
            }
            if (DT.Rows.Count > 0)
            {
                if (DT.Rows[0][1].ToString() == "الموظف")
                {
                    log_name = DT.Rows[0]["User_Name"].ToString();
                    log_id = Convert.ToInt16(DT.Rows[0]["User_ID"]);
                    fm.lbl_name.Text = log_name.ToString();
                    fm.lbl_type.Text = "موظف";
                    this.Hide();
                    fm.ShowDialog();
                }
            }
            else
                MessageBox.Show("!فشل تسجيل الدخول", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }




        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (Form_Dashboard fd = new Form_Dashboard())
            //{
            //    fd.ShowDialog();
            //}
            check();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (ShopInvetoryManagement. Properties.Settings.Default.Counter >= 1)
                    return;
                else if (ShopInvetoryManagement. Properties.Settings.Default.Counter == 0)
                {
                    Server_Confiq SYS = new Server_Confiq ();
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
