using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Forms;
using ShopInvetoryManagement.Forms;

namespace BookShopManagement
{
   
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static int Casheir_ID;
        public static int Cate_ID = 0;
        public static string Casheir;
        public static Boolean ISuser;
        public static string Key = "AIMMO-TECH2-G77MM-4XJMR-2Q2QK";
        [STAThread]
       
        static void Main()
        {
            Application.EnableVisualStyles();
            DevExpress.DataAccess.Sql.SqlDataSource.AllowCustomSqlQueries = true;
            DevExpress.DataAccess.Sql.SqlDataSource.DisableCustomQueryValidation = true;
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LOG_FORM());
        }
    }
}
