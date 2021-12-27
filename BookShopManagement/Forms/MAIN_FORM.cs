using BookShopManagement.Forms;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopInvetoryManagement.REPORT;


namespace ShopInvetoryManagement.Forms
{
    
    public partial class MAIN_FORM : Form
    {

        public void CLOSECHILDFORM()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "Home_Page")
                {
                }
                else
                {
                    frm.Close();
                }

            };
        }


        public MAIN_FORM()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void MAIN_FORM_Load(object sender, EventArgs e)
        {
            lbl__date.Text = DateTime.Now.ToLongDateString();
           // label_watch.Text = DateTime.Now.TimeOfDay.ToString();

            Home_Page frm = new Home_Page();
            frm.MdiParent = this;
            frm.Show();
            frm.Visible = true;

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
           // CLOSECHILDFORM();
            Form_FinishOrder FRM = new Form_FinishOrder();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
           // CLOSECHILDFORM();
            Customers FRM = new Customers();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            //CLOSECHILDFORM();
            Customers_Pay FRM = new Customers_Pay();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            //CLOSECHILDFORM();
            Backup_Restore FRM = new Backup_Restore();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
          //  CLOSECHILDFORM();
            About_Pro FRM = new About_Pro();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            //CLOSECHILDFORM();
            About_Developer FRM = new About_Developer();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
           // CLOSECHILDFORM();
            FORM_CHEEK FRM = new FORM_CHEEK();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
           // CLOSECHILDFORM();
            DIEON_FORM FRM = new DIEON_FORM();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
           // CLOSECHILDFORM();
            Employees FRM = new Employees();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
           // CLOSECHILDFORM();
            UserForm  FRM = new UserForm ();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           // CLOSECHILDFORM();
            ADD_BANK FRM = new ADD_BANK();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
           // CLOSECHILDFORM();
            Form_Bank_opreation FRM = new Form_Bank_opreation ();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
           // CLOSECHILDFORM();
            BookShopManagement.Forms.Storage FRM = new BookShopManagement.Forms.Storage();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void إضافةخزنةToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // CLOSECHILDFORM();
            ADD_STORAGE  FRM = new ADD_STORAGE ();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //CLOSECHILDFORM();
            Form_AddNewproduct  FRM = new Form_AddNewproduct ();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void المخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   CLOSECHILDFORM();
            Form_AddStock  FRM = new Form_AddStock ();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void إضافةالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    CLOSECHILDFORM();
            Form_AddCategory FRM = new Form_AddCategory ();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
         //   CLOSECHILDFORM();
            BILLLS_FORM  FRM = new BILLLS_FORM ();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("  هل تريد تسجيل الخروج  ", " تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
                Application.Exit();
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            context_Sales.Show(btnSale,btnSale.PointToClient(Cursor.Position));
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            Strip_Payment.Show(btnPurchase, btnPurchase.PointToClient(Cursor.Position));

        }

      

        private void btnUsers_Click(object sender, EventArgs e)
        {
            context_bank.Show(btnUsers, btnUsers.PointToClient(Cursor.Position));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            context_Asool.Show(button2, button2.PointToClient(Cursor.Position));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            context_user.Show(button1, button1.PointToClient(Cursor.Position));

        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            STRIP_REPORT.Show(btnViewSales, btnViewSales.PointToClient(Cursor.Position));

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            context_System.Show(btnSettings, btnSettings.PointToClient(Cursor.Position));

        }

        private void button8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            EMPLOYEEY_DATA RT = new EMPLOYEEY_DATA();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            CUSTOMER_DATA RT = new CUSTOMER_DATA();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            POS_CUSTOMER RT = new POS_CUSTOMER();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            SALES_REPORT RT = new SALES_REPORT();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {

            PAYMENT_REPORT RT = new PAYMENT_REPORT();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {

            STORE_REPORT RT = new STORE_REPORT();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {

            BANK_REPORT RT = new BANK_REPORT();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {

            REPORT.Storage RT = new REPORT.Storage();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {

            MOSROFAT RT = new MOSROFAT();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {

            ELTEIZAAM_REPORT RT = new ELTEIZAAM_REPORT();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {

            ALsheckat RT = new ALsheckat();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {

            ARBAH RT = new ARBAH();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            contex_custmers.Show(simpleButton1, simpleButton1.PointToClient(Cursor.Position));
            WindowState = FormWindowState.Maximized;
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            User_Permiastion FRM = new User_Permiastion();
            FRM.Parent = this.MdiParent;
            FRM.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_watch.Text = DateTime.Now.ToShortTimeString().ToString();
        }
    }
}
