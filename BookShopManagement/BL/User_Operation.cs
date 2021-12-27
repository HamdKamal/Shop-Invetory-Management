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
    
    class User_Operation
    {
        DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
        public DataTable GetUser_Data(string U_TYPE, string U_NAME, string U_PASS)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@U_TYPE", SqlDbType.NVarChar, 30);
            param[0].Value = U_TYPE;

            param[1] = new SqlParameter("@U_NAME", SqlDbType.NVarChar, 30);
            param[1].Value = U_NAME;

            param[2] = new SqlParameter("@U_PASS", SqlDbType.NVarChar,30);
            param[2].Value = U_PASS;

            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GetUser_Data", param);
            DAL.close();
            return Dt;
        }
        // get user id 
        public DataTable GET_User_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_User_ID", param);
            DAL.close();
            return Dt;
        }

        // GET EMPLOYEE FULLNAME (GRID VIEW)
        public DataTable GET_EMP_FULLNAME()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_EMP_FULLNAME", param);
            DAL.close();
            return Dt;
        }

        // DELETE USER DATA 
        public void DELETE_USER(int USER_ID)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@USER_ID", SqlDbType.Int);
            parm[0].Value = USER_ID;

            DAL.ExecuteCommand("DELETE_USER", parm);
            DAL.close();
        }

        // ADD USER DATA 
        public void ADD_USER(int U_ID, string U_TYPE, string U_NAME, string U_PASS, int EMP_ID)
        {
          
            DAL.open();
            SqlParameter[] parm = new SqlParameter[5];

            parm[0] = new SqlParameter("@U_ID", SqlDbType.Int);
            parm[0].Value = U_ID;

            parm[1] = new SqlParameter("@U_TYPE", SqlDbType.NVarChar, 30);
            parm[1].Value = U_TYPE;

            parm[2] = new SqlParameter("@U_NAME", SqlDbType.NVarChar, 30);
            parm[2].Value = U_NAME;

            parm[3] = new SqlParameter("@U_PASS", SqlDbType.NVarChar,30);
            parm[3].Value = U_PASS;

            parm[4] = new SqlParameter("@EMP_ID", SqlDbType.Int);
            parm[4].Value = EMP_ID;

            DAL.ExecuteCommand("ADD_USER", parm);
            DAL.close();
        }

        // EDIT USER DATA
        public void EDIT_USER(int U_ID, string U_TYPE, string U_NAME, string U_PASS, int EMP_ID)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[5];

            parm[0] = new SqlParameter("@U_ID", SqlDbType.Int);
            parm[0].Value = U_ID;

            parm[1] = new SqlParameter("@U_TYPE", SqlDbType.NVarChar, 30);
            parm[1].Value = U_TYPE;

            parm[2] = new SqlParameter("@U_NAME", SqlDbType.NVarChar, 30);
            parm[2].Value = U_NAME;

            parm[3] = new SqlParameter("@U_PASS", SqlDbType.NVarChar, 30);
            parm[3].Value = U_PASS;

            parm[4] = new SqlParameter("@EMP_ID", SqlDbType.Int);
            parm[4].Value = EMP_ID;

            DAL.ExecuteCommand("EDIT_USER", parm);
            DAL.close();
        }

        // get Gate id 
        public DataTable GET_Gate_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_Gate_ID", param);
            DAL.close();
            return Dt;
        }
        // ADD GATE DATA
        public void ADD_GATE_DATA(int G_ID, string G_NAME, string G_NOTE)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[3];

            parm[0] = new SqlParameter("@G_ID", SqlDbType.Int);
            parm[0].Value = G_ID;

            parm[1] = new SqlParameter("@G_NAME", SqlDbType.NVarChar, 30);
            parm[1].Value = G_NAME;

            parm[2] = new SqlParameter("@G_NOTE", SqlDbType.NVarChar, 30);
            parm[2].Value = G_NOTE;
                       
            DAL.ExecuteCommand("ADD_GATE_DATA", parm);
            DAL.close();
        }

        // DELETE GATE DATA 
        public void DELETE_GATE_DATA(int G_ID)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@G_ID", SqlDbType.Int);
            parm[0].Value = G_ID;

            DAL.ExecuteCommand("DELETE_GATE_DATA", parm);
            DAL.close();
        }
        public DataTable get_user_name()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_user_name", param);
            DAL.close();
            return Dt;
        }
        // UBDATE PERMISSITION
        public void UBDATE_USER_PERMISITION
           (int USER_ID , Boolean BILLS_FORM, Boolean CUSTOMER,
           Boolean CUS_PAY, Boolean DIEON, Boolean EMPLOYEE,
           Boolean CATEGORY, Boolean NEW_PRODCT, Boolean ADD_STOCK, Boolean BANK_ADD, Boolean BANK_OPE,
           Boolean ADD_STORAGE, Boolean STG_OPE,
           Boolean SHECKAT, Boolean POS, Boolean USER_PERM, Boolean BAC_RES)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[17];

            parm[0] = new SqlParameter("@USER_ID", SqlDbType.Int);
            parm[0].Value = USER_ID;

            parm[1] = new SqlParameter("@BILLS_FORM", SqlDbType.Bit);
            parm[1].Value = BILLS_FORM;

            parm[2] = new SqlParameter("@CUSTOMER", SqlDbType.Bit);
            parm[2].Value = CUSTOMER;

            parm[3] = new SqlParameter("@CUS_PAY", SqlDbType.Bit);
            parm[3].Value = CUS_PAY;

            parm[4] = new SqlParameter("@DIEON", SqlDbType.Bit);
            parm[4].Value = DIEON;

            parm[5] = new SqlParameter("@EMPLOYEE", SqlDbType.Bit);
            parm[5].Value = EMPLOYEE;

            parm[6] = new SqlParameter("@CATEGORY", SqlDbType.Bit);
            parm[6].Value = CATEGORY;

            parm[7] = new SqlParameter("@NEW_PRODCT", SqlDbType.Bit);
            parm[7].Value = NEW_PRODCT;

            parm[8] = new SqlParameter("@ADD_STOCK", SqlDbType.Bit);
            parm[8].Value = ADD_STOCK;

            parm[9] = new SqlParameter("@BANK_ADD", SqlDbType.Bit);
            parm[9].Value = BANK_ADD;

            parm[10] = new SqlParameter("@BANK_OPE", SqlDbType.Bit);
            parm[10].Value = BANK_OPE;

            parm[11] = new SqlParameter("@ADD_STORAGE", SqlDbType.Bit);
            parm[11].Value = ADD_STORAGE;

            parm[12] = new SqlParameter("@STG_OPE", SqlDbType.Bit);
            parm[12].Value = STG_OPE;

            parm[13] = new SqlParameter("@SHECKAT", SqlDbType.Bit);
            parm[13].Value = SHECKAT;

            parm[14] = new SqlParameter("@POS", SqlDbType.Bit);
            parm[14].Value = POS;

            parm[15] = new SqlParameter("@USER_PERM", SqlDbType.Bit);
            parm[15].Value = USER_PERM;

            parm[16] = new SqlParameter("@BAC_RES", SqlDbType.Bit);
            parm[16].Value = BAC_RES;

            DAL.ExecuteCommand("UBDATE_USER_PERMISITION", parm);
            DAL.close();
        }
        // get USER DATA 
        public DataTable for_user(int user_id)
        {
            SqlParameter[] param = new SqlParameter[1];
            DataTable Dt = new DataTable();

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;
            
            Dt = DAL.selectData("for_user", param);
            DAL.close();
            return Dt;
        }
              
    }
}
