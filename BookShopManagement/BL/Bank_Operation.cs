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
    class Bank_Operation
    {
        DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();

        // DELETE Bank DATA 
        public void DELETE_BANK(int B_ID)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@B_ID", SqlDbType.Int);
            parm[0].Value = B_ID;

            DAL.ExecuteCommand("DELETE_BANK", parm);
            DAL.close();
        }

        // DELETE STORAGE DATA 
        public void DELETE_STORAGE_DATA(int S_ID)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@S_ID", SqlDbType.Int);
            parm[0].Value = S_ID;

            DAL.ExecuteCommand("DELETE_STORAGE_DATA", parm);
            DAL.close();
        }

        // ADD Bank DATA 
        public void ADD_BANK(int B_ID, string B_NAME, string B_ACC, string B_ADD, string B_NOTE,string B_Money)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[6];

            parm[0] = new SqlParameter("@B_ID", SqlDbType.Int);
            parm[0].Value = B_ID;

            parm[1] = new SqlParameter("@B_NAME", SqlDbType.NVarChar, 30);
            parm[1].Value = B_NAME;

            parm[2] = new SqlParameter("@B_ACC", SqlDbType.NVarChar, 30);
            parm[2].Value = B_ACC;

            parm[3] = new SqlParameter("@B_ADD", SqlDbType.NVarChar, 30);
            parm[3].Value = B_ADD;

            parm[4] = new SqlParameter("@B_NOTE", SqlDbType.NVarChar,100);
            parm[4].Value = B_NOTE;

            parm[5] = new SqlParameter("@B_Money", SqlDbType.NVarChar, 100);
            parm[5].Value = B_Money;

            DAL.ExecuteCommand("ADD_BANK", parm);
            DAL.close();
        }

        // EDIT BANK DATA
        public void EDIT_BANK(int B_ID, string B_NAME, string B_ACC, string B_ADD, string B_NOTE, string B_Money)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[6];

            parm[0] = new SqlParameter("@B_ID", SqlDbType.Int);
            parm[0].Value = B_ID;

            parm[1] = new SqlParameter("@B_NAME", SqlDbType.NVarChar, 30);
            parm[1].Value = B_NAME;

            parm[2] = new SqlParameter("@B_ACC", SqlDbType.NVarChar, 30);
            parm[2].Value = B_ACC;

            parm[3] = new SqlParameter("@B_ADD", SqlDbType.NVarChar, 30);
            parm[3].Value = B_ADD;

            parm[4] = new SqlParameter("@B_NOTE", SqlDbType.NVarChar, 100);
            parm[4].Value = B_NOTE;

            parm[5] = new SqlParameter("@B_Money", SqlDbType.NVarChar, 100);
            parm[5].Value = B_Money;

            DAL.ExecuteCommand("EDIT_BANK", parm);
            DAL.close();
        }

        // get BANK id 
        public DataTable GET_Bank_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_Bank_ID", param);
            DAL.close();
            return Dt;
        }
        // get STORAGE id 
        public DataTable GET_ADD_STORAGE_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_ADD_STORAGE_ID", param);
            DAL.close();
            return Dt;
        }
        // DELETE Bank_Operation DATA 
        public void DELETE_BANK_OPERATION(int Ope_ID)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@Ope_ID", SqlDbType.Int);
            parm[0].Value = Ope_ID;

            DAL.ExecuteCommand("DELETE_BANK_OPERATION", parm);
            DAL.close();
        }
        // get BANK_Operation id 
        public DataTable GET_BankOPERATION_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_BankOPERATION_ID", param);
            DAL.close();
            return Dt;
        }

        // ADD BANK_Operation DATA
        public void ADD_BANKOPERATION(int Ope_ID,int Bank_ID,int User_ID, string F_Name, string L_Name,string Ope_Money, string Ope_Type,string Ope_Byan,string Ope_Note,DateTime Ope_Date,string B_Amount,string B_After_Ope)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[12];

            parm[0] = new SqlParameter("@Ope_ID", SqlDbType.Int);
            parm[0].Value = Ope_ID;

            parm[1] = new SqlParameter("@Bank_ID", SqlDbType.Int);
            parm[1].Value = Bank_ID;

            parm[2] = new SqlParameter("@User_ID", SqlDbType.Int);
            parm[2].Value = User_ID;

            parm[3] = new SqlParameter("@F_Name", SqlDbType.NVarChar, 30);
            parm[3].Value = F_Name;

            parm[4] = new SqlParameter("@L_Name", SqlDbType.NVarChar, 30);
            parm[4].Value = L_Name;

            parm[5] = new SqlParameter("@Ope_Money", SqlDbType.NVarChar, 30);
            parm[5].Value = Ope_Money;

            parm[6] = new SqlParameter("@Ope_Type", SqlDbType.NVarChar, 30);
            parm[6].Value = Ope_Type;

            parm[7] = new SqlParameter("@Ope_Byan", SqlDbType.NVarChar, 100);
            parm[7].Value = Ope_Byan;

            parm[8] = new SqlParameter("@Ope_Note", SqlDbType.NVarChar, 100);
            parm[8].Value = Ope_Note;

            parm[9] = new SqlParameter("@Ope_Date", SqlDbType.Date);
            parm[9].Value = Ope_Date;

            parm[10] = new SqlParameter("@B_Amount", SqlDbType.NVarChar, 30);
            parm[10].Value = B_Amount;

            parm[11] = new SqlParameter("@B_After_Ope", SqlDbType.NVarChar, 30);
            parm[11].Value = B_After_Ope;

            DAL.ExecuteCommand("ADD_BANKOPERATION", parm);
            DAL.close();
        }

        // EDIT BANK_Operation DATA
        public void EDIT_BANKOPERATION(int Ope_ID, int Bank_ID, int User_ID, string F_Name, string L_Name, string Ope_Money, string Ope_Type, string Ope_Byan, string Ope_Note, DateTime Ope_Date)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@Ope_ID", SqlDbType.Int);
            parm[0].Value = Ope_ID;

            parm[1] = new SqlParameter("@Bank_ID", SqlDbType.Int);
            parm[1].Value = Bank_ID;

            parm[2] = new SqlParameter("@User_ID", SqlDbType.Int);
            parm[2].Value = User_ID;

            parm[3] = new SqlParameter("@F_Name", SqlDbType.NVarChar, 30);
            parm[3].Value = F_Name;

            parm[4] = new SqlParameter("@L_Name", SqlDbType.NVarChar, 30);
            parm[4].Value = L_Name;

            parm[5] = new SqlParameter("@Ope_Money", SqlDbType.NVarChar, 30);
            parm[5].Value = Ope_Money;

            parm[6] = new SqlParameter("@Ope_Type", SqlDbType.NVarChar, 30);
            parm[6].Value = Ope_Type;

            parm[7] = new SqlParameter("@Ope_Byan", SqlDbType.NVarChar, 100);
            parm[7].Value = Ope_Byan;

            parm[8] = new SqlParameter("@Ope_Note", SqlDbType.NVarChar, 100);
            parm[8].Value = Ope_Note;

            parm[9] = new SqlParameter("@Ope_Date", SqlDbType.Date);
            parm[9].Value = Ope_Date;

            DAL.ExecuteCommand("EDIT_BANKOPERATION", parm);
            DAL.close();
        }

        // get BANK DATA 
        public DataTable GetBank_Data()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GetBank_Data", param);
            DAL.close();
            return Dt;
        }

        // get ADD_STORAGE DATA 
        public DataTable Get_ADD_STORAGE_Data()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("Get_ADD_STORAGE_Data", param);
            DAL.close();
            return Dt;
        }
        // GET_BANK_MONEY
        public DataTable GetBank_Data_ONE(string B_NAME)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@B_NAME", SqlDbType.NVarChar, 50);
            param[0].Value = B_NAME;
            
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GetBank_Data_ONE", param);
            DAL.close();
            return Dt;
        }
        // GET_STORAGE_MONEY
        public DataTable GetSTORAGE_Data_ONE(string S_NAME)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@S_NAME", SqlDbType.NVarChar, 50);
            param[0].Value = S_NAME;

            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GetSTORAGE_Data_ONE", param);
            DAL.close();
            return Dt;
        }
        // CONFIQ Money_Bank
        public DataTable CONFIQ_Bank_MONEY(string B_NAME, string B_MONEY, string CHECK)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[3];
            DataTable Dt = new DataTable();

            parm[0] = new SqlParameter("@B_NAME", SqlDbType.NVarChar, 35);
            parm[0].Value = B_NAME;

            parm[1] = new SqlParameter("@B_MONEY", SqlDbType.NVarChar, 35);
            parm[1].Value = B_MONEY;

            parm[2] = new SqlParameter("@CHECK", SqlDbType.NVarChar, 35);
            parm[2].Value = CHECK;


            DAL.ExecuteCommand("CONFIQ_Bank_MONEY", parm);
            DAL.close();
            return Dt;
        }
        // ADD ADD_STORAGE DATA 
        public void ADD_STORAGE_DATA(int S_ID, string S_NAME, string S_MONEY)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[3];

            parm[0] = new SqlParameter("@S_ID", SqlDbType.Int);
            parm[0].Value = S_ID;

            parm[1] = new SqlParameter("@S_NAME", SqlDbType.NVarChar, 30);
            parm[1].Value = S_NAME;

            parm[2] = new SqlParameter("@S_MONEY", SqlDbType.NVarChar, 30);
            parm[2].Value = S_MONEY;

            DAL.ExecuteCommand("ADD_STORAGE_DATA", parm);
            DAL.close();
        }

        // EDIT ADD_STORAGE DATA 
        public void EDIT_STORAGE_DATA(int S_ID, string S_NAME, string S_MONEY)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[3];

            parm[0] = new SqlParameter("@S_ID", SqlDbType.Int);
            parm[0].Value = S_ID;

            parm[1] = new SqlParameter("@S_NAME", SqlDbType.NVarChar, 30);
            parm[1].Value = S_NAME;

            parm[2] = new SqlParameter("@S_MONEY", SqlDbType.NVarChar, 30);
            parm[2].Value = S_MONEY;

            DAL.ExecuteCommand("EDIT_STORAGE_DATA", parm);
            DAL.close();
        }
        // CONFIQ Storage_Bank
        public DataTable CONFIQ_Storage_MONEY(string S_NAME, string S_MONEY, string CHECK)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[3];
            DataTable Dt = new DataTable();

            parm[0] = new SqlParameter("@S_NAME", SqlDbType.NVarChar, 35);
            parm[0].Value = S_NAME;

            parm[1] = new SqlParameter("@S_MONEY", SqlDbType.NVarChar, 35);
            parm[1].Value = S_MONEY;

            parm[2] = new SqlParameter("@CHECK", SqlDbType.NVarChar, 35);
            parm[2].Value = CHECK;


            DAL.ExecuteCommand("CONFIQ_Storage_MONEY", parm);
            DAL.close();
            return Dt;
        }

    }
}
