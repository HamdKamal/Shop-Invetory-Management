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
    class Pos_Operation
    {
        DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();

        // ADD Bills_custmer DATA 
        public void ADD_BILL_CUSTOMER(int B_ID, int CUS_ID, int User_ID, string S_TYPE, string PRD_CODE,
           int S_QUAN, string S_TOTAL, DateTime S_DATE, string BILL_PRICE)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[9];

            parm[0] = new SqlParameter("@B_ID", SqlDbType.Int);
            parm[0].Value = B_ID;

            parm[1] = new SqlParameter("@CUS_ID", SqlDbType.Int);
            parm[1].Value = CUS_ID;

            parm[2] = new SqlParameter("@User_ID", SqlDbType.Int);
            parm[2].Value = User_ID;

            parm[3] = new SqlParameter("@S_TYPE", SqlDbType.NVarChar, 50);
            parm[3].Value = S_TYPE;

            parm[4] = new SqlParameter("@PRD_CODE", SqlDbType.NVarChar, 50);
            parm[4].Value = PRD_CODE;

            parm[5] = new SqlParameter("@S_QUAN", SqlDbType.Int);
            parm[5].Value = S_QUAN;

            parm[6] = new SqlParameter("@S_TOTAL", SqlDbType.NVarChar, 30);
            parm[6].Value = S_TOTAL;

            parm[7] = new SqlParameter("@S_DATE", SqlDbType.Date);
            parm[7].Value = S_DATE;

            parm[8] = new SqlParameter("@BILL_PRICE", SqlDbType.NVarChar, 30);
            parm[8].Value = BILL_PRICE;

            DAL.ExecuteCommand("ADD_BILL_CUSTOMER", parm);
            DAL.close();
        }

        // ADD Bill_None_customer DATA 
        public void ADD_BILL_NONECUSTOMER(int B_ID, string NAME, int User_ID, string S_TYPE, string PRD_CODE,
           int S_QUAN, string S_TOTAL, DateTime S_DATE, string BILL_PRICE)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[9];

            parm[0] = new SqlParameter("@B_ID", SqlDbType.Int);
            parm[0].Value = B_ID;

            parm[1] = new SqlParameter("@NAME", SqlDbType.NVarChar, 50);
            parm[1].Value = NAME;

            parm[2] = new SqlParameter("@User_ID", SqlDbType.Int);
            parm[2].Value = User_ID;

            parm[3] = new SqlParameter("@S_TYPE", SqlDbType.NVarChar, 50);
            parm[3].Value = S_TYPE;

            parm[4] = new SqlParameter("@PRD_CODE", SqlDbType.NVarChar, 50);
            parm[4].Value = PRD_CODE;

            parm[5] = new SqlParameter("@S_QUAN", SqlDbType.Int);
            parm[5].Value = S_QUAN;

            parm[6] = new SqlParameter("@S_TOTAL", SqlDbType.NVarChar, 30);
            parm[6].Value = S_TOTAL;

            parm[7] = new SqlParameter("@S_DATE", SqlDbType.Date);
            parm[7].Value = S_DATE;

            parm[8] = new SqlParameter("@BILL_PRICE", SqlDbType.NVarChar, 30);
            parm[8].Value = BILL_PRICE;

            DAL.ExecuteCommand("ADD_BILL_NONECUSTOMER", parm);
            DAL.close();
        }

        // ADD pos_None_customer DATA 
        public void ADD_POS_NONE_CUS(int POS_ID, int BILLS_NO, string NAME, string PRD_CODE)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[4];

            parm[0] = new SqlParameter("@POS_ID", SqlDbType.Int);
            parm[0].Value = POS_ID;

            parm[1] = new SqlParameter("@BILLS_NO", SqlDbType.Int);
            parm[1].Value = BILLS_NO;

            parm[2] = new SqlParameter("@NAME", SqlDbType.NVarChar, 50);
            parm[2].Value = NAME;

            parm[3] = new SqlParameter("@PRD_CODE", SqlDbType.NVarChar, 50);
            parm[3].Value = PRD_CODE;

            DAL.ExecuteCommand("ADD_POS_NONE_CUS", parm);
            DAL.close();
        }

        // ADD pos_customer DATA 
        public void ADD_POS_CUSTOMER(int POS_ID, int BILLS_NO, string PRD_CODE, int CUS_ID)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[4];

            parm[0] = new SqlParameter("@POS_ID", SqlDbType.Int);
            parm[0].Value = POS_ID;

            parm[1] = new SqlParameter("@BILLS_NO", SqlDbType.Int);
            parm[1].Value = BILLS_NO;

            parm[2] = new SqlParameter("@PRD_CODE", SqlDbType.NVarChar, 50);
            parm[2].Value = PRD_CODE;

            parm[3] = new SqlParameter("@CUS_ID", SqlDbType.Int);
            parm[3].Value = CUS_ID;

            DAL.ExecuteCommand("ADD_POS_CUSTOMER", parm);
            DAL.close();
        }

        // get CUSTOMER_BILLS id 
        public DataTable GET_CUS_BILLS_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_CUS_BILLS_ID", param);
            DAL.close();
            return Dt;
        }
        // get NONE_CUSTOMER_BILLS id 
        public DataTable GET_NONE_CUS_BILLS_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_NONE_CUS_BILLS_ID", param);
            DAL.close();
            return Dt;
        }

        // get NO_CUSTOMER_BILLS id
        public DataTable GET_CUS_PAYMENTr_ID1()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_CUS_PAYMENTr_ID1", param);
            DAL.close();
            return Dt;
        }

        public DataTable GET_CUS_PAYMENTr_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_CUS_PAYMENTr_ID", param);
            DAL.close();
            return Dt;
        }


        // UPDATE QUANTITY IN STOCK
        public void Min_Quan(int D2, string D1)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[2];

            parm[0] = new SqlParameter("@D2", SqlDbType.Int);
            parm[0].Value = D2;

            parm[1] = new SqlParameter("@D1", SqlDbType.NVarChar, 35);
            parm[1].Value = D1;

            DAL.ExecuteCommand("Min_Quan", parm);
            DAL.close();
        }

        // GET POS_CUSTOMER DATA 
        public DataTable GET_POS_CUSTOMER(int BILL_NO)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];
            DataTable Dt = new DataTable();

            parm[0] = new SqlParameter("@BILL_NO", SqlDbType.Int);
            parm[0].Value = BILL_NO;

            DAL.ExecuteCommand("GET_POS_CUSTOMER", parm);
            DAL.close();
            return Dt;
        }

        // GET POS_NONE_CUSTOMER DATA 
        public DataTable GET_POS_NONE_CUSTOMER(int BILL_NO)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];
            DataTable Dt = new DataTable();

            parm[0] = new SqlParameter("@BILL_NO", SqlDbType.Int);
            parm[0].Value = BILL_NO;

            DAL.ExecuteCommand("GET_POS_NONE_CUSTOMER", parm);
            DAL.close();
            return Dt;
        }
        // CONFIQ QUANTITY
        public DataTable Confeg_Quant(string Barcode_product, int qte_in_stock)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[2];
            DataTable Dt = new DataTable();

            parm[0] = new SqlParameter("@Barcode_product", SqlDbType.NVarChar, 35);
            parm[0].Value = Barcode_product;

            parm[1] = new SqlParameter("@qte_in_stock", SqlDbType.Int);
            parm[1].Value = qte_in_stock;

            DAL.ExecuteCommand("Confeg_Quant", parm);
            DAL.close();
            return Dt;
        }
       
        public void add_customer_payment1(int PAY_NO, int BILL_NO, int CUST_ID, int User_ID,
            string TOTAL, string MADFOOA, string MOTABAGI, string PAY_NAME, DateTime PAY_DATE,
            string NOTE, DateTime BILLS_DATE)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[11];

            parm[0] = new SqlParameter("@PAY_NO", SqlDbType.Int);
            parm[0].Value = PAY_NO;

            parm[1] = new SqlParameter("@BILL_NO", SqlDbType.Int);
            parm[1].Value = BILL_NO;

            parm[2] = new SqlParameter("@CUST_ID", SqlDbType.Int);
            parm[2].Value = CUST_ID;

            parm[3] = new SqlParameter("@User_ID", SqlDbType.Int);
            parm[3].Value = User_ID;

            parm[4] = new SqlParameter("@TOTAL", SqlDbType.NVarChar, 50);
            parm[4].Value = TOTAL;

            parm[5] = new SqlParameter("@MADFOOA", SqlDbType.NVarChar, 50);
            parm[5].Value = MADFOOA;

            parm[6] = new SqlParameter("@MOTABAGI", SqlDbType.NVarChar, 50);
            parm[6].Value = MOTABAGI;

            parm[7] = new SqlParameter("@PAY_NAME", SqlDbType.NVarChar, 50);
            parm[7].Value = PAY_NAME;

            parm[8] = new SqlParameter("@PAY_DATE", SqlDbType.Date);
            parm[8].Value = PAY_DATE;

            parm[9] = new SqlParameter("@NOTE", SqlDbType.NVarChar, 50);
            parm[9].Value = NOTE;

            parm[10] = new SqlParameter("@BILLS_DATE", SqlDbType.Date);
            parm[10].Value = BILLS_DATE;



            DAL.ExecuteCommand("add_customer_payment1", parm);
            DAL.close();
        }

        // GET POS_NONE_CUSTOMER DATA 
        public DataTable SEARCH_PRODUCT()
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[0];
            DataTable Dt = new DataTable();

            //parm[0] = new SqlParameter("@OBJECT", SqlDbType.NVarChar ,50);
            //parm[0].Value = OBJECT;

            DAL.ExecuteCommand("SEARCH_PRODUCT", parm);
            DAL.close();
            return Dt;
        }
        // DELETE bills_custmoer DATA 
        public void DELETE_BILLS_customer(int Bills_NO)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@Bills_NO", SqlDbType.Int);
            parm[0].Value = Bills_NO;

            DAL.ExecuteCommand("DELETE_BILLS_customer", parm);
            DAL.close();
        }

        // DELETE bills_nonecustmoer DATA 
        public void DELETE_BILLS_none_customer(int Bills_NO)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@Bills_NO", SqlDbType.Int);
            parm[0].Value = Bills_NO;

            DAL.ExecuteCommand("DELETE_BILLS_none_customer", parm);
            DAL.close();
        }
        // UPDATE QUANTITY IN STOCK
        public void Confeg_Quant_Plas(int qte_in_stock, string PRD_CODE)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[2];

            parm[0] = new SqlParameter("@qte_in_stock", SqlDbType.Int);
            parm[0].Value = qte_in_stock;

            parm[1] = new SqlParameter("@PRD_CODE", SqlDbType.NVarChar, 35);
            parm[1].Value = PRD_CODE;

            DAL.ExecuteCommand("Confeg_Quant_Plas", parm);
            DAL.close();
        }

        // DELETE bills_nonecustmoer DATA 
        public void DELETE_ORDER_NONE(string PRD_BAR, int BILLS_NO)
        {
         
            DAL.open();
            SqlParameter[] parm = new SqlParameter[2];

            parm[0] = new SqlParameter("@PRD_BAR", SqlDbType.NVarChar, 30);
            parm[0].Value = PRD_BAR;

            parm[1] = new SqlParameter("@BILLS_NO", SqlDbType.Int);
            parm[1].Value = BILLS_NO;

            DAL.ExecuteCommand("DELETE_ORDER_NONE", parm);
            DAL.close();
        }
        public void DELETE_ORDER(string PRD_BAR,int BILLS_NO)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[2];

            parm[0] = new SqlParameter("@PRD_BAR", SqlDbType.NVarChar, 30);
            parm[0].Value = PRD_BAR;

            parm[1] = new SqlParameter("@BILLS_NO", SqlDbType.Int);
            parm[1].Value = BILLS_NO;

            DAL.ExecuteCommand("DELETE_ORDER", parm);
            DAL.close();
        }

        public DataTable search_PAY1(int BILL_ID, int CUST_ID)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@BILL_ID", SqlDbType.Int);
            param[0].Value = BILL_ID;

            param[1] = new SqlParameter("@CUST_ID", SqlDbType.Int);
            param[1].Value = CUST_ID;


            DataTable Dt = new DataTable();
            Dt = DAL.selectData("search_PAY1", param);
            DAL.close();
            return Dt;
        }
        //EDITE CUSTOMERPAYMENT
        public void EDIT_customer_payment1(int PAY_NO, int BILL_NO, int CUST_ID, int User_ID,
             string PAY_NAME, DateTime PAY_DATE,
            string NOTE, DateTime BILLS_DATE)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[8];

            parm[0] = new SqlParameter("@PAY_NO", SqlDbType.Int);
            parm[0].Value = PAY_NO;

            parm[1] = new SqlParameter("@BILL_NO", SqlDbType.Int);
            parm[1].Value = BILL_NO;

            parm[2] = new SqlParameter("@CUST_ID", SqlDbType.Int);
            parm[2].Value = CUST_ID;

            parm[3] = new SqlParameter("@User_ID", SqlDbType.Int);
            parm[3].Value = User_ID;

            parm[4] = new SqlParameter("@PAY_NAME", SqlDbType.NVarChar, 50);
            parm[4].Value = PAY_NAME;

            parm[5] = new SqlParameter("@PAY_DATE", SqlDbType.Date);
            parm[5].Value = PAY_DATE;

            parm[6] = new SqlParameter("@NOTE", SqlDbType.NVarChar, 50);
            parm[6].Value = NOTE;

            parm[7] = new SqlParameter("@BILLS_DATE", SqlDbType.Date);
            parm[7].Value = BILLS_DATE;



            DAL.ExecuteCommand("EDIT_customer_payment1", parm);
            DAL.close();
        }
        public void update_paid_pay(int BILL_ID, int CUST_ID,string D2,int pay_no)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[4];

            parm[0] = new SqlParameter("@BILL_ID", SqlDbType.Int);
            parm[0].Value = BILL_ID;

            parm[1] = new SqlParameter("@CUST_ID", SqlDbType.Int);
            parm[1].Value = CUST_ID;

            parm[2] = new SqlParameter("@D2", SqlDbType.NVarChar, 35);
            parm[2].Value = D2;

            parm[3] = new SqlParameter("@pay_no", SqlDbType.Int);
            parm[3].Value = pay_no;

            DAL.ExecuteCommand("update_paid_pay", parm);
            DAL.close();
        }

        // INCREASE QUANTITY IN STOCK 
        public void INCREASE_QUANTITY(int QUAN, string CODE)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[2];

            parm[0] = new SqlParameter("@QUAN", SqlDbType.Int);
            parm[0].Value = QUAN;

            parm[1] = new SqlParameter("@CODE", SqlDbType.NVarChar, 35);
            parm[1].Value = CODE;

            DAL.ExecuteCommand("INCREASE_QUANTITY", parm);
            DAL.close();
        }

        // purcheur new payment 
        public void update_paid_pay2(int PAY_NO, int BILL_NO, int CUST_ID, int User_ID,
            string PAY_MONEY, string PAY_NAME, DateTime PAY_DATE,
           string NOTE, DateTime BILLS_DATE)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[9];

            parm[0] = new SqlParameter("@PAY_NO", SqlDbType.Int);
            parm[0].Value = PAY_NO;

            parm[1] = new SqlParameter("@BILL_NO", SqlDbType.Int);
            parm[1].Value = BILL_NO;

            parm[2] = new SqlParameter("@CUST_ID", SqlDbType.Int);
            parm[2].Value = CUST_ID;

            parm[3] = new SqlParameter("@User_ID", SqlDbType.Int);
            parm[3].Value = User_ID;

            parm[4] = new SqlParameter("@PAY_MONEY", SqlDbType.NVarChar, 50);
            parm[4].Value = PAY_MONEY;

            parm[5] = new SqlParameter("@PAY_NAME", SqlDbType.NVarChar, 50);
            parm[5].Value = PAY_NAME;

            parm[6] = new SqlParameter("@PAY_DATE", SqlDbType.Date);
            parm[6].Value = PAY_DATE;

            parm[7] = new SqlParameter("@NOTE", SqlDbType.NVarChar, 50);
            parm[7].Value = NOTE;

            parm[8] = new SqlParameter("@BILLS_DATE", SqlDbType.Date);
            parm[8].Value = BILLS_DATE;

            DAL.ExecuteCommand("update_paid_pay2", parm);
            DAL.close();
        }
    }
}
