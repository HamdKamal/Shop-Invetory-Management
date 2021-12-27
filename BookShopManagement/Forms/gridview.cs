using ShopInvetoryManagement.BL;
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

namespace ShopInvetoryManagement.Forms
{
    public partial class gridview : Form
    {
        Pos_Operation ope = new Pos_Operation();
        public gridview()
        {
            InitializeComponent();
        }
        
        //private void gridview_Load(object sender, EventArgs e)
        ////{
        ////    DataTable DT = new DataTable();
        ////    DT = ope.GET_POS_CUSTOMER(9);
        //    GRIDVIEW_POS.DataSource = DT;
        
    }
}
