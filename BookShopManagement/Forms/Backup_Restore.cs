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

namespace BookShopManagement.Forms
{
    public partial class Backup_Restore : Form
    {
        SqlConnection sqlconn = new SqlConnection(@"server= MO-KAMAL\SQLEXPRESS; Database=Lang_DataBase; integrated Security=true");
        SqlCommand CMD;

        public Backup_Restore()
        {
            InitializeComponent();
        }

        private void BT_GET_Click(object sender, EventArgs e)
        {
            TXT_PATH.BackColor = Color.White;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TXT_PATH.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private void BT_BAC_Click(object sender, EventArgs e)
        {
            if (TXT_PATH.Text == "")
            {
                TXT_PATH.BackColor = Color.Red;
                return;
            }
            string filename = TXT_PATH.Text + "//Lang_DataBase" + DateTime.Now.ToLongDateString().Replace('/', '-') + " ^ " + DateTime.Now.ToShortTimeString().Replace(':', '-');

            string strqry = "Backup Database Lang_DataBase to Disk ='" + filename + ".bak'";
            CMD = new SqlCommand(strqry, sqlconn);
            sqlconn.Open();
            CMD.ExecuteNonQuery();
            sqlconn.Close();
            MessageBox.Show("تم عمل النسخة الإحتياطية بنجاح", "عمل نسخة  إحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TXT_PATH.Text = "";
        }

        private void BT_SET_Click(object sender, EventArgs e)
        {
            TXT_PATH1.BackColor = Color.White;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                TXT_PATH1.Text = openFileDialog1.FileName;
            }
        }

        private void BT_RES_Click(object sender, EventArgs e)
        {
            if (TXT_PATH1.Text == "")
            {
                TXT_PATH1.BackColor = Color.Red;
                return;
            }
            string strqry = "ALTER Database Lang_DataBase SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database Lang_DataBase From Disk ='" + TXT_PATH1.Text + "'";
            CMD = new SqlCommand(strqry, sqlconn);
            sqlconn.Open();
            CMD.ExecuteNonQuery();
            sqlconn.Close();
            MessageBox.Show("تم إستعادة النسخة الإحتياطية بنجاح", "إستعادة نسخة  إحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TXT_PATH1.Text = "";
        }

        private void Backup_Restore_Load(object sender, EventArgs e)
        {
            TXT_PATH.Text = "";
            TXT_PATH1.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
