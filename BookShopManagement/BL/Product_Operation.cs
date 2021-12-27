using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ShopInvetoryManagement;
using System.Data;

namespace ShopInvetoryManagement.BL
{
    class Product_Operation
    {
        DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
        // DELETE product DATA 
        public void DELETE_PRODUCTS(int PRD_NO)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@PRD_NO", SqlDbType.Int);
            parm[0].Value = PRD_NO;

            //parm[1] = new SqlParameter("@PRD_BARCODE", SqlDbType.NVarChar,50);
            //parm[1].Value = PRD_BARCODE;

            DAL.ExecuteCommand("DELETE_PRODUCTS", parm);
            DAL.close();
        }
        // ADD produc DATA 
        public void ADD_PRODUCTS(int PRD_NO, string PRD_BARCODE, string PRD_NAME, int PRD_QUANINSTOCK, int Gate_ID,
           string STOCK_NO,string PRD_PRICE,string PRD_TAJZA_PRICE,string PRD_JUOMLA_PRICE,string PRD_NOTE,DateTime DATE_ENTER)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[11];

            parm[0] = new SqlParameter("@PRD_NO", SqlDbType.Int);
            parm[0].Value = PRD_NO;

            parm[1] = new SqlParameter("@PRD_BARCODE", SqlDbType.NVarChar, 30);
            parm[1].Value = PRD_BARCODE;

            parm[2] = new SqlParameter("@PRD_NAME", SqlDbType.NVarChar, 30);
            parm[2].Value = PRD_NAME;

            parm[3] = new SqlParameter("@PRD_QUANINSTOCK", SqlDbType.Int);
            parm[3].Value = PRD_QUANINSTOCK;

            parm[4] = new SqlParameter("@Gate_ID", SqlDbType.Int);
            parm[4].Value = Gate_ID;

            parm[5] = new SqlParameter("@STOCK_NO", SqlDbType.NVarChar,30);
            parm[5].Value = STOCK_NO;

            parm[6] = new SqlParameter("@PRD_PRICE", SqlDbType.NVarChar, 30);
            parm[6].Value = PRD_PRICE;

            parm[7] = new SqlParameter("@PRD_TAJZA_PRICE", SqlDbType.NVarChar, 30);
            parm[7].Value = PRD_TAJZA_PRICE;

            parm[8] = new SqlParameter("@PRD_JUOMLA_PRICE", SqlDbType.NVarChar,30);
            parm[8].Value = PRD_JUOMLA_PRICE;

            parm[9] = new SqlParameter("@PRD_NOTE", SqlDbType.NVarChar,100);
            parm[9].Value = PRD_NOTE;

            parm[10] = new SqlParameter("@DATE_ENTER", SqlDbType.Date);
            parm[10].Value = DATE_ENTER;

            DAL.ExecuteCommand("ADD_PRODUCTS", parm);
            DAL.close();
        }
        // EDIT PRODUCT DATA
        public void EDIT_PRODUCTS(int PRD_NO, string PRD_BARCODE, string PRD_NAME, int PRD_QUANINSTOCK, int Gate_ID,
         string STOCK_NO, string PRD_PRICE, string PRD_TAJZA_PRICE, string PRD_JUOMLA_PRICE, string PRD_NOTE, DateTime DATE_ENTER)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[11];

            parm[0] = new SqlParameter("@PRD_NO", SqlDbType.Int);
            parm[0].Value = PRD_NO;

            parm[1] = new SqlParameter("@PRD_BARCODE", SqlDbType.NVarChar, 30);
            parm[1].Value = PRD_BARCODE;

            parm[2] = new SqlParameter("@PRD_NAME", SqlDbType.NVarChar, 30);
            parm[2].Value = PRD_NAME;

            parm[3] = new SqlParameter("@PRD_QUANINSTOCK", SqlDbType.Int);
            parm[3].Value = PRD_QUANINSTOCK;

            parm[4] = new SqlParameter("@Gate_ID", SqlDbType.Int);
            parm[4].Value = Gate_ID;

            parm[5] = new SqlParameter("@STOCK_NO", SqlDbType.NVarChar ,30);
            parm[5].Value = STOCK_NO;

            parm[6] = new SqlParameter("@PRD_PRICE", SqlDbType.NVarChar, 30);
            parm[6].Value = PRD_PRICE;

            parm[7] = new SqlParameter("@PRD_TAJZA_PRICE", SqlDbType.NVarChar, 30);
            parm[7].Value = PRD_TAJZA_PRICE;

            parm[8] = new SqlParameter("@PRD_JUOMLA_PRICE", SqlDbType.NVarChar, 30);
            parm[8].Value = PRD_JUOMLA_PRICE;

            parm[9] = new SqlParameter("@PRD_NOTE", SqlDbType.NVarChar, 100);
            parm[9].Value = PRD_NOTE;

            parm[10] = new SqlParameter("@DATE_ENTER", SqlDbType.Date);
            parm[10].Value = DATE_ENTER;

            DAL.ExecuteCommand("EDIT_PRODUCTS", parm);
            DAL.close();
        }
        // get PRODUCT id 
        public DataTable GET_PRODUCT_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_PRODUCT_ID", param);
            DAL.close();
            return Dt;
        }

        // get categeroy 
        public DataTable GET_Cateagory_NAME()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_Cateagory_NAME", param);
            DAL.close();
            return Dt;
        }
        // get all product
        public DataTable GET_ALL_PRODUCTS()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_ALL_PRODUCTS", param);
            DAL.close();
            return Dt;
        }


        public void ADD_QUANTITYIN_FIRST(int QUANT, string BAR)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[2];

            parm[0] = new SqlParameter("@QUANT", SqlDbType.Int);
            parm[0].Value = QUANT;

            parm[1] = new SqlParameter("@BAR", SqlDbType.NVarChar, 30);
            parm[1].Value = BAR;

            DAL.ExecuteCommand("ADD_QUANTITYIN_FIRST", parm);
            DAL.close();
        }

        // get count customer 

        public DataTable count_customer()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("count_customer", param);
            DAL.close();
            return Dt;
        }

        // get sum customer 

        public DataTable sum_customer()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("sum_customer", param);
            DAL.close();
            return Dt;
        }
        // get sum none_customer 

        public DataTable sum_none_customer()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("sum_none_customer", param);
            DAL.close();
            return Dt;
        }
        // get sum bank 

        public DataTable sum_bank()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("sum_bank", param);
            DAL.close();
            return Dt;
        }
        // get sum cash 

        public DataTable sum_cash()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("sum_cash", param);
            DAL.close();
            return Dt;
        }
    }
}
