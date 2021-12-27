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
   
    class Another_Finance
    {
        DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
        // get storage id 
        public DataTable GET_STORAGE_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_STORAGE_ID", param);
            DAL.close();
            return Dt;
        }
        // get GET_TORREEID_ID id 
        public DataTable GET_TORREEID_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_TORREEID_ID", param);
            DAL.close();
            return Dt;
        }

        // get GET_SAHAAB_ID id 
        public DataTable GET_SAHAAB_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_SAHAAB_ID", param);
            DAL.close();
            return Dt;
        }
        // get BILLS_CASH id 
        public DataTable get_CASH_BILL_id()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_CASH_BILL_id", param);
            DAL.close();
            return Dt;
        }

        // get BILLS_BANK id 
        public DataTable get_BANK_BILLS_id()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_BANK_BILLS_id", param);
            DAL.close();
            return Dt;
        }

        // ADD storage DATA 
        public void ADD_TO_STORAGE(int STG_ID, string STG_NAME, string OPE_TYPE, string OPE_MONEY, string OPE_BYAN,
            DateTime DATE_GET_SET, string OPE_NOTE,int U_ID,DateTime DATE_OPE,string B_Amount,string B_After_Ope)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[11];

            parm[0] = new SqlParameter("@STG_ID", SqlDbType.Int);
            parm[0].Value = STG_ID;

            parm[1] = new SqlParameter("@STG_NAME", SqlDbType.NVarChar, 30);
            parm[1].Value = STG_NAME;

            parm[2] = new SqlParameter("@OPE_TYPE", SqlDbType.NVarChar, 30);
            parm[2].Value = OPE_TYPE;

            parm[3] = new SqlParameter("@OPE_MONEY", SqlDbType.NVarChar, 30);
            parm[3].Value = OPE_MONEY;

            parm[4] = new SqlParameter("@OPE_BYAN", SqlDbType.NVarChar, 100);
            parm[4].Value = OPE_BYAN;

            parm[5] = new SqlParameter("@DATE_GET_SET", SqlDbType.Date);
            parm[5].Value = DATE_GET_SET;

            parm[6] = new SqlParameter("@OPE_NOTE", SqlDbType.NVarChar, 100);
            parm[6].Value = OPE_NOTE;

            parm[7] = new SqlParameter("@U_ID", SqlDbType.Int);
            parm[7].Value = U_ID;

            parm[8] = new SqlParameter("@DATE_OPE", SqlDbType.Date);
            parm[8].Value = DATE_OPE;

            parm[9] = new SqlParameter("@B_Amount", SqlDbType.NVarChar ,30);
            parm[9].Value = B_Amount;

            parm[10] = new SqlParameter("@B_After_Ope", SqlDbType.NVarChar ,30);
            parm[10].Value = B_After_Ope;

            DAL.ExecuteCommand("ADD_TO_STORAGE", parm);
            DAL.close();
        }
        // get ELTIZAM id 
        public DataTable GET_ELTIZAM_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_ELTIZAM_ID", param);
            DAL.close();
            return Dt;
        }


        // ADD TO ELTIZAM
        public void ADD_TO_ELTIZAM(int Ope_NO, string OPE_TYPE, string F_NAME, string L_NAME,
            DateTime DATE_1, DateTime DATE_2,string Ope_Money,string PAY_Type, string Ope_Note,
             int USER_ID, DateTime Ope_Date)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[11];

            parm[0] = new SqlParameter("@Ope_NO", SqlDbType.Int);
            parm[0].Value = Ope_NO;

            parm[1] = new SqlParameter("@OPE_TYPE", SqlDbType.NVarChar, 30);
            parm[1].Value = OPE_TYPE;

            parm[2] = new SqlParameter("@F_NAME", SqlDbType.NVarChar, 30);
            parm[2].Value = F_NAME;

            parm[3] = new SqlParameter("@L_NAME", SqlDbType.NVarChar, 30);
            parm[3].Value = L_NAME;

            parm[4] = new SqlParameter("@DATE_1", SqlDbType.Date);
            parm[4].Value = DATE_1;

            parm[5] = new SqlParameter("@DATE_2", SqlDbType.Date);
            parm[5].Value = DATE_2;

            parm[6] = new SqlParameter("@Ope_Money", SqlDbType.NVarChar, 30);
            parm[6].Value = Ope_Money;

            parm[7] = new SqlParameter("@PAY_Type", SqlDbType.NVarChar,30);
            parm[7].Value = PAY_Type;

            parm[8] = new SqlParameter("@Ope_Note", SqlDbType.NVarChar,30);
            parm[8].Value = Ope_Note;

            parm[9] = new SqlParameter("@USER_ID", SqlDbType.Int);
            parm[9].Value = USER_ID;

            parm[10] = new SqlParameter("@Ope_Date", SqlDbType.Date);
            parm[10].Value = Ope_Date;

            DAL.ExecuteCommand("ADD_TO_ELTIZAM", parm);
            DAL.close();
        }

        // ADD BILL_CASH DATA 
        public void ADD_TO_BILLS_CASH(int B_NO, int U_ID, string B_MONEY, string B_TYPE, string B_BYAN,
            string PAY_TYPE, DateTime B_DATE)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[7];

            parm[0] = new SqlParameter("@B_NO", SqlDbType.Int);
            parm[0].Value = B_NO;

            parm[1] = new SqlParameter("@U_ID", SqlDbType.Int);
            parm[1].Value = U_ID;

            parm[2] = new SqlParameter("@B_MONEY", SqlDbType.NVarChar, 30);
            parm[2].Value = B_MONEY;

            parm[3] = new SqlParameter("@B_TYPE", SqlDbType.NVarChar, 30);
            parm[3].Value = B_TYPE;

            parm[4] = new SqlParameter("@B_BYAN", SqlDbType.NVarChar, 100);
            parm[4].Value = B_BYAN;

            parm[5] = new SqlParameter("@PAY_TYPE", SqlDbType.NVarChar ,30);
            parm[5].Value = PAY_TYPE;

            parm[6] = new SqlParameter("@B_DATE", SqlDbType.Date);
            parm[6].Value = B_DATE;

            DAL.ExecuteCommand("ADD_TO_BILLS_CASH", parm);
            DAL.close();
        }

        // ADD BILL_BANK DATA 
        public void ADD_TO_BILLS_BANK(int B_NO, int U_ID, string B_MONEY, string B_TYPE, string B_BYAN,
            string PAY_TYPE, DateTime B_DATE,int BANK_ID,int CHECK_NO)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[9];

            parm[0] = new SqlParameter("@B_NO", SqlDbType.Int);
            parm[0].Value = B_NO;

            parm[1] = new SqlParameter("@U_ID", SqlDbType.Int);
            parm[1].Value = U_ID;

            parm[2] = new SqlParameter("@B_MONEY", SqlDbType.NVarChar, 30);
            parm[2].Value = B_MONEY;

            parm[3] = new SqlParameter("@B_TYPE", SqlDbType.NVarChar, 30);
            parm[3].Value = B_TYPE;

            parm[4] = new SqlParameter("@B_BYAN", SqlDbType.NVarChar, 100);
            parm[4].Value = B_BYAN;

            parm[5] = new SqlParameter("@PAY_TYPE", SqlDbType.NVarChar, 30);
            parm[5].Value = PAY_TYPE;

            parm[6] = new SqlParameter("@B_DATE", SqlDbType.Date);
            parm[6].Value = B_DATE;

            parm[7] = new SqlParameter("@BANK_ID", SqlDbType.Int);
            parm[7].Value = BANK_ID;

            parm[8] = new SqlParameter("@CHECK_NO", SqlDbType.Int);
            parm[8].Value = CHECK_NO;

            DAL.ExecuteCommand("ADD_TO_BILLS_BANK", parm);
            DAL.close();
        }
        // ADD TO SAHAAB
        public void ADD_TO_SAHAAP(int OPE_ID, string OPE_TYPE, string B_NAME, string CHECK_NO, string F_NAME,
           string L_NAME, string BANK_WONER, string THREE_NAME, string CHECK_MONEY, DateTime DATE_RECIPT, int U_ID,DateTime DATE_OPE)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[12];

            parm[0] = new SqlParameter("@OPE_ID", SqlDbType.Int);
            parm[0].Value = OPE_ID;

            parm[1] = new SqlParameter("@OPE_TYPE", SqlDbType.NVarChar, 30);
            parm[1].Value = OPE_TYPE;

            parm[2] = new SqlParameter("@B_NAME", SqlDbType.NVarChar, 30);
            parm[2].Value = B_NAME;

            parm[3] = new SqlParameter("@CHECK_NO", SqlDbType.NVarChar, 30);
            parm[3].Value = CHECK_NO;

            parm[4] = new SqlParameter("@F_NAME", SqlDbType.NVarChar, 30);
            parm[4].Value = F_NAME;

            parm[5] = new SqlParameter("@L_NAME", SqlDbType.NVarChar, 30);
            parm[5].Value = L_NAME;

            parm[6] = new SqlParameter("@BANK_WONER", SqlDbType.NVarChar, 30);
            parm[6].Value = BANK_WONER;

            parm[7] = new SqlParameter("@THREE_NAME", SqlDbType.NVarChar, 30);
            parm[7].Value = THREE_NAME;

            parm[8] = new SqlParameter("@CHECK_MONEY", SqlDbType.NVarChar ,30);
            parm[8].Value = CHECK_MONEY;

            parm[9] = new SqlParameter("@DATE_RECIPT", SqlDbType.DateTime);
            parm[9].Value = DATE_RECIPT;

            parm[10] = new SqlParameter("@U_ID", SqlDbType.Int);
            parm[10].Value = U_ID;

            parm[11] = new SqlParameter("@DATE_OPE", SqlDbType.DateTime);
            parm[11].Value = DATE_OPE;

            DAL.ExecuteCommand("ADD_TO_SAHAAP", parm);
            DAL.close();
        }

        // ADD TO torred
        public void ADD_TO_TORREEID(int OPE_ID, string OPE_TYPE, string BANK_MORD, string CHECK_NO, string F_NAME,
           string L_NAME, string BANK_WONER, DateTime DATE_TORREEID, string CHECK_MONEY, DateTime DATE_RECIPT, int U_ID, DateTime DATE_OPE)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[12];

            parm[0] = new SqlParameter("@OPE_ID", SqlDbType.Int);
            parm[0].Value = OPE_ID;

            parm[1] = new SqlParameter("@OPE_TYPE", SqlDbType.NVarChar, 30);
            parm[1].Value = OPE_TYPE;

            parm[2] = new SqlParameter("@BANK_MORD", SqlDbType.NVarChar, 30);
            parm[2].Value = BANK_MORD;

            parm[3] = new SqlParameter("@CHECK_NO", SqlDbType.NVarChar, 30);
            parm[3].Value = CHECK_NO;

            parm[4] = new SqlParameter("@F_NAME", SqlDbType.NVarChar, 30);
            parm[4].Value = F_NAME;

            parm[5] = new SqlParameter("@L_NAME", SqlDbType.NVarChar, 30);
            parm[5].Value = L_NAME;

            parm[6] = new SqlParameter("@BANK_WONER", SqlDbType.NVarChar, 30);
            parm[6].Value = BANK_WONER;

            parm[7] = new SqlParameter("@DATE_TORREEID", SqlDbType.DateTime);
            parm[7].Value = DATE_TORREEID;

            parm[8] = new SqlParameter("@CHECK_MONEY", SqlDbType.NVarChar, 30);
            parm[8].Value = CHECK_MONEY;

            parm[9] = new SqlParameter("@DATE_RECIPT", SqlDbType.DateTime);
            parm[9].Value = DATE_RECIPT;

            parm[10] = new SqlParameter("@U_ID", SqlDbType.Int);
            parm[10].Value = U_ID;

            parm[11] = new SqlParameter("@DATE_OPE", SqlDbType.DateTime);
            parm[11].Value = DATE_OPE;

            DAL.ExecuteCommand("ADD_TO_TORREEID", parm);
            DAL.close();
        }
    }
}
