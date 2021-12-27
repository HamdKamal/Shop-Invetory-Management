using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using ShopInvetoryManagement.BL;
using BookShopManagement.Forms;
using ShopInvetoryManagement.DAL;

namespace BookShopManagement.Forms
{
    public partial class Home_Page : Form
    {
        DATAACCESSLAYER DAL = new DATAACCESSLAYER();
        Product_Operation PRD = new Product_Operation();
        SqlDataReader RED,RED1;
        SqlCommand COM,COM1;
        string SQL,SQL1;

        void CALCULATE_VALUES()
        {
            // COUNT CUSTOMER
            try
            {
                SQL = "select count(CUS_ID) from TBL_Customer";
                COM = new SqlCommand(SQL, DAL.sqlconnection);

                DAL.open();
                RED = COM.ExecuteReader();
                while (RED.Read())
                {
                    string Z = RED[0].ToString();
                    label5.Text = Z;
                }
            }
            catch
            {
                return;
            }
            finally
            {
                COM.Dispose();
                DAL.close();
            }

            //  Sales calculate
            try
            {
                SQL = "select sum(BILL_MONEY) from TBL_BILLS_BANK";
               
                COM = new SqlCommand(SQL, DAL.sqlconnection);
               
                DAL.open();
                RED = COM.ExecuteReader();
              
                while (RED.Read())
                {
                    string X = RED[0].ToString();
                    label8.Text = X;
                    
                }
            }
            catch
            {
                return;
            }
            finally
            {
                COM.Dispose();
                DAL.close();
            }

            // SALSE CALCULATE
            try
            {
                SQL = "select sum(BILL_MONEY) from TBL_BILLS_CASH";

                COM = new SqlCommand(SQL, DAL.sqlconnection);

                DAL.open();
                RED = COM.ExecuteReader();

                while (RED.Read())
                {
                    string X1 = RED[0].ToString();
                    label7.Text = X1;

                }
            }
            catch
            {
                return;
            }
            finally
            {
                COM.Dispose();
                DAL.close();
            }

            // BILLS CALCULATE
            try
            {
                SQL = "select sum(SALE_TOTAL) from TBL_NONECUSTOMER_BILLS";

                COM = new SqlCommand(SQL, DAL.sqlconnection);

                DAL.open();
                RED = COM.ExecuteReader();

                while (RED.Read())
                {
                    string X2 = RED[0].ToString();
                    label9.Text = X2;

                }
            }
            catch
            {
                return;
            }
            finally
            {
                COM.Dispose();
                DAL.close();
            }

            // BILLS CALCULATE
            try
            {
                SQL = "select sum(SALE_TOTAL) from TBL_BILLS_CUSTOMER";

                COM = new SqlCommand(SQL, DAL.sqlconnection);

                DAL.open();
                RED = COM.ExecuteReader();

                while (RED.Read())
                {
                    string X3 = RED[0].ToString();
                    label10.Text = X3;

                }
            }
            catch
            {
                return;
            }
            finally
            {
                COM.Dispose();
                DAL.close();
            }


            label3.Text = Convert.ToString(Convert.ToDouble(label9.Text) + Convert.ToDouble(label10.Text));
            label4.Text = Convert.ToString(Convert.ToDouble(label7.Text) + Convert.ToDouble(label8.Text));
        }

        public Home_Page()
        {
            InitializeComponent();
            CALCULATE_VALUES();
        }

        private void Home_Page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lang_DataBaseDataSet.SEARCH_PRODUCT' table. You can move, or remove it, as needed.
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CALCULATE_VALUES();
        }
    }
}
