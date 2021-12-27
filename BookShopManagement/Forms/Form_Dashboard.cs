using BookShopManagement.UserControls;
using ShopInvetoryManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class Form_Dashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;

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
        public Form_Dashboard()
        {

            InitializeComponent();
            
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            //UC_Home uch = new UC_Home();
            //AddControlsToPanel2(uch);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            lbl__date.Text = DateTime.Now.ToLongDateString();
            Home_Page frm = new Home_Page();
            frm.MdiParent = this;
            frm.Show ();
            frm.Visible = true ;
           
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 13;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 13;
                if (panelLeft.Width <= 45)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(ToolStripMenuItem  btn)
        {
            panelSide.Top = btn.Height ;
            panelSide.Height = btn.Height;
        }

        private void moveSidePanel2(Button  btn)
        {
            panelSide.Top = btn.Height;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel2(Control  c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        private void AddControlsToPanel(Form c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls .Add(c);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel2(btnHome);
            //UC_Home uch = new UC_Home();
            //AddControlsToPanel2(uch);
        }

        private void btnSaleBooks_Click(object sender, EventArgs e)
        {
            //moveSidePanel(btnSale);
            //UC_Sales us = new UC_Sales();
            //AddControlsToPanel(us);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            //moveSidePanel(btnPurchase);
            //UC_PurchaseDetails up = new UC_PurchaseDetails();
            //AddControlsToPanel(up);
        }

       

        private void btnUsers_Click(object sender, EventArgs e)
        {
            //moveSidePanel(btnUsers);
            //UC_ManageUser um = new UC_ManageUser();
            //AddControlsToPanel(um);
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            //moveSidePanel(btnViewSales);
            //UC_ViewSales vs = new UC_ViewSales();
            //AddControlsToPanel(vs);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // moveSidePanel(btnSettings);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt =  DateTime.Today;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Strip_sales_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewSales_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            //moveSidePanel(btnHome);
            CLOSECHILDFORM();
            Form_AddNewproduct frm = new Form_AddNewproduct();
            // frm.MdiParent = this;
            frm.ShowDialog ();
           

        }

        private void المخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLOSECHILDFORM();
            Form_AddStock frm = new Form_AddStock ();
            // frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void إضافةالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLOSECHILDFORM();
            Form_AddCategory  frm = new Form_AddCategory ();
            // frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CLOSECHILDFORM();
            BILLLS_FORM  frm = new BILLLS_FORM ();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            CLOSECHILDFORM();
            Customers frm = new Customers ();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            CLOSECHILDFORM();
            Customers_Pay  frm = new Customers_Pay ();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CLOSECHILDFORM();
            ADD_BANK frm = new ADD_BANK ();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CLOSECHILDFORM();
            Form_Bank_opreation  frm = new Form_Bank_opreation ();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            CLOSECHILDFORM();
            Employees  frm = new Employees ();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            CLOSECHILDFORM();
            UserForm  frm = new UserForm ();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            CLOSECHILDFORM();
            Backup_Restore frm = new Backup_Restore ();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            CLOSECHILDFORM();
            About_Pro  frm = new About_Pro ();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            
            CLOSECHILDFORM();
            About_Developer  frm = new About_Developer ();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            CLOSECHILDFORM();
            Storage  frm = new Storage ();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            CLOSECHILDFORM();
            Form_FinishOrder  frm = new Form_FinishOrder ();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            CLOSECHILDFORM();
            DIEON_FORM frm = new DIEON_FORM();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            //CLOSECHILDFORM();
            // frm = new DIEON_FORM();
            ////frm.MdiParent = this;
            //frm.ShowDialog();
        }
    }
}
