using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ShopInvetoryManagement.BL
{
    class Customer_Operation
    {
        DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();

        //GET CUSTOMER FULLNAME
        public DataTable GET_CUSTOMER_FULLNAME()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_CUSTOMER_FULLNAME", param);
            DAL.close();
            return Dt;
        }

        // get Customer id 
        public DataTable GET_CUS_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_CUS_ID", param);
            DAL.close();
            return Dt;
        }

        // DELETE Customer DATA 
        public void DELETE_CUSTOMER(int CUS_ID)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@CUS_ID", SqlDbType.Int);
            parm[0].Value = CUS_ID;

            DAL.ExecuteCommand("DELETE_CUSTOMER", parm);
            DAL.close();
        }
        // GET ALL CUSTOMERS DATA (GRID VIEW)
        public DataTable GET_ALL_CUSTOMER()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_ALL_CUSTOMER", param);
            DAL.close();
            return Dt;
        }

        internal DataTable GeTCustomer_Data_ONE(object selectedValue)
        {
            throw new NotImplementedException();
        }


        // ADD CUSTOMER DATA 
        public void ADD_CUSTOMERS(int CUS_ID, string CUS_Firstname, string CUS_lastname, string CUS_Identity, int CUS_Age, string CUS_Gender,
            string CUS_Degree, string CUS_Quan, string CUS_Note, string CUS_Phone, string CUS_Address, DateTime Date_Register,
            byte[] CUS_Image, byte[] DOC_1, byte[] DOC_2, byte[] DOC_3, string check)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[17];

            parm[0] = new SqlParameter("@CUS_ID", SqlDbType.Int);
            parm[0].Value = CUS_ID;

            parm[1] = new SqlParameter("@CUS_Firstname", SqlDbType.NVarChar, 30);
            parm[1].Value = CUS_Firstname;

            parm[2] = new SqlParameter("@CUS_lastname", SqlDbType.NVarChar, 30);
            parm[2].Value = CUS_lastname;

            parm[3] = new SqlParameter("@CUS_Identity", SqlDbType.NVarChar, 30);
            parm[3].Value = CUS_Identity;

            parm[4] = new SqlParameter("@CUS_Age", SqlDbType.Int);
            parm[4].Value = CUS_Age;

            parm[5] = new SqlParameter("@CUS_Gender", SqlDbType.NVarChar, 30);
            parm[5].Value = CUS_Gender;

            parm[6] = new SqlParameter("@CUS_Degree", SqlDbType.NVarChar, 30);
            parm[6].Value = CUS_Degree;

            parm[7] = new SqlParameter("@CUS_Quan", SqlDbType.NVarChar, 30);
            parm[7].Value = CUS_Quan;

            parm[8] = new SqlParameter("@CUS_Note", SqlDbType.NVarChar, 30);
            parm[8].Value = CUS_Note;

            parm[9] = new SqlParameter("@CUS_Phone", SqlDbType.NVarChar,30);
            parm[9].Value = CUS_Phone;

            parm[10] = new SqlParameter("@CUS_Address", SqlDbType.NVarChar,30);
            parm[10].Value = CUS_Address;

            parm[11] = new SqlParameter("@Date_Register", SqlDbType.Date);
            parm[11].Value = Date_Register;

            parm[12] = new SqlParameter("@CUS_Image", SqlDbType.Image);
            parm[12].Value = CUS_Image;

            parm[13] = new SqlParameter("@DOC_1", SqlDbType.Image);
            parm[13].Value = DOC_1;

            parm[14] = new SqlParameter("@DOC_2", SqlDbType.Image);
            parm[14].Value = DOC_2;

            parm[15] = new SqlParameter("@DOC_3", SqlDbType.Image);
            parm[15].Value = DOC_3;

            parm[16] = new SqlParameter("@check", SqlDbType.NVarChar,30);
            parm[16].Value = check;

            

            DAL.ExecuteCommand("ADD_CUSTOMERS", parm);
            DAL.close();
        }

        // EDIT CUSTOMER DATA 
        public void EDIT_CUSTOMERS(int CUS_ID, string CUS_Firstname, string CUS_lastname, string CUS_Identity, int CUS_Age, string CUS_Gender,
            string CUS_Degree, string CUS_Quan, string CUS_Note, string CUS_Phone, string CUS_Address, DateTime Date_Register,
            byte[] CUS_Image, byte[] DOC_1, byte[] DOC_2, byte[] DOC_3, string check)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[17];

            parm[0] = new SqlParameter("@CUS_ID", SqlDbType.Int);
            parm[0].Value = CUS_ID;

            parm[1] = new SqlParameter("@CUS_Firstname", SqlDbType.NVarChar, 30);
            parm[1].Value = CUS_Firstname;

            parm[2] = new SqlParameter("@CUS_lastname", SqlDbType.NVarChar, 30);
            parm[2].Value = CUS_lastname;

            parm[3] = new SqlParameter("@CUS_Identity", SqlDbType.NVarChar, 30);
            parm[3].Value = CUS_Identity;

            parm[4] = new SqlParameter("@CUS_Age", SqlDbType.Int);
            parm[4].Value = CUS_Age;

            parm[5] = new SqlParameter("@CUS_Gender", SqlDbType.NVarChar, 30);
            parm[5].Value = CUS_Gender;

            parm[6] = new SqlParameter("@CUS_Degree", SqlDbType.NVarChar, 30);
            parm[6].Value = CUS_Degree;

            parm[7] = new SqlParameter("@CUS_Quan", SqlDbType.NVarChar, 30);
            parm[7].Value = CUS_Quan;

            parm[8] = new SqlParameter("@CUS_Note", SqlDbType.NVarChar, 30);
            parm[8].Value = CUS_Note;

            parm[9] = new SqlParameter("@CUS_Phone", SqlDbType.NVarChar, 30);
            parm[9].Value = CUS_Phone;

            parm[10] = new SqlParameter("@CUS_Address", SqlDbType.NVarChar, 30);
            parm[10].Value = CUS_Address;

            parm[11] = new SqlParameter("@Date_Register", SqlDbType.Date);
            parm[11].Value = Date_Register;

            parm[12] = new SqlParameter("@CUS_Image", SqlDbType.Image);
            parm[12].Value = CUS_Image;

            parm[13] = new SqlParameter("@DOC_1", SqlDbType.Image);
            parm[13].Value = DOC_1;

            parm[14] = new SqlParameter("@DOC_2", SqlDbType.Image);
            parm[14].Value = DOC_2;

            parm[15] = new SqlParameter("@DOC_3", SqlDbType.Image);
            parm[15].Value = DOC_3;

            parm[16] = new SqlParameter("@check", SqlDbType.NVarChar, 30);
            parm[16].Value = check;

            DAL.ExecuteCommand("EDIT_CUSTOMERS", parm);
            DAL.close();
        }

        public DataTable GeTCustomer_Data_ONE(int CUST_ID)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CUST_ID", SqlDbType.Int);
            param[0].Value = CUST_ID;

            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GeTCustomer_Data_ONE", param);
            DAL.close();
            return Dt;
        }

        // GET PAYMENT 
        public DataTable GET_ALL_PAYMENT_BY_CUSTOMER(int CUS_ID, int BILL_ID)
        {
            DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@CUS_ID", SqlDbType.Int);
            param[0].Value = CUS_ID;

            param[1] = new SqlParameter("@BILL_ID", SqlDbType.Int);
            param[1].Value = BILL_ID;

            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_ALL_PAYMENT_BY_CUSTOMER", param);
            DAL.close();
            return Dt;
        }

    }
}
