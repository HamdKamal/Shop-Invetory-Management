using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ShopInvetoryManagement;
using System.Configuration;


namespace BookShopManagement.Forms
{
    public partial class Server_Confiq : Form
    {
        public Server_Confiq()
        {
            InitializeComponent();
        }

        private void bt_conn_Click(object sender, EventArgs e)
        {
 
                ShopInvetoryManagement.Properties.Settings.Default.Server = txt_server.Text;
                ShopInvetoryManagement.Properties.Settings.Default.DataBase = txt_base.Text;
                ShopInvetoryManagement.Properties.Settings.Default.Mode = rbt_win.Checked == true ? "Windows" : "Windows";
                ShopInvetoryManagement.Properties.Settings.Default.Counter += 1;
                ShopInvetoryManagement.Properties.Settings.Default.Save();

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.ConnectionStrings.ConnectionStrings["Aim-Connection"].ConnectionString = "XpoProvider=MSSqlServer;data source='" + txt_server.Text + "';integrated security=SSPI;initial catalog='" + txt_base.Text + "'";
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("connectionStrings");

                config.ConnectionStrings.ConnectionStrings["ShopInvetoryManagement.Properties.Settings.ConnectionString"].ConnectionString = "XpoProvider=MSSqlServer;data source='" + txt_server.Text + "';integrated security=SSPI;initial catalog='" + txt_base.Text + "'";
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("connectionStrings");

                MessageBox.Show("تم تفعيل الإتصال بنجاح", "الإتصال بالسيرفر", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Server_Confiq_Load(object sender, EventArgs e)
        {
           txt_server.Text =ShopInvetoryManagement. Properties.Settings.Default.Server;
            txt_base .Text =ShopInvetoryManagement .Properties.Settings.Default.DataBase;
            if (ShopInvetoryManagement. Properties.Settings.Default.Mode == "Windows")
                rbt_win.Checked = true;
        }
    }
}

