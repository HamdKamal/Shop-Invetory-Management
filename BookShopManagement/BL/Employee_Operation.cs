using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ShopInvetoryManagement.BL
{
    class Employee_Operation
    {
        DAL.DATAACCESSLAYER DAL = new DAL.DATAACCESSLAYER();
        // get employee id 
        public DataTable GET_EMP_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_EMP_ID", param);
            DAL.close();
            return Dt;
        }

        // DELETE EMPLOYEE DATA 
        public void DELETE_EMP(int EMP_ID)
        {
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@EMP_ID", SqlDbType.Int);
            parm[0].Value = @EMP_ID;

            DAL.ExecuteCommand("DELETE_EMP", parm);
            DAL.close();
        }

        // GET ALL EMPLOYEE DATA (GRID VIEW)
        public DataTable GET_ALL_EMPLOYEE()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_ALL_EMPLOYEE", param);
            DAL.close();
            return Dt;
        }

        // ADD EMPLOYEE DATA 
        public void ADD_EMPLOYEE(int Emp_ID, string EMP_Firstname, string EMP_lastname, string EMP_Identity, int EMP_Age, string EMP_Gender,
            string EMP_Status,string EMP_Job,string EMP_Note,string EMP_Salary,string EMP_Phone,string EMP_Address,DateTime Date_Hair,
            byte[] EMP_Image, byte[] DOC_1, byte[] DOC_2, byte[] DOC_3, byte[] DOC_4, byte[] DOC_5, byte[] DOC_6, string check)
        {
          
            DAL.open();
            SqlParameter[] parm = new SqlParameter[21];

            parm[0] = new SqlParameter("@Emp_ID", SqlDbType.Int);
            parm[0].Value = Emp_ID;

            parm[1] = new SqlParameter("@EMP_Firstname", SqlDbType.NVarChar, 30);
            parm[1].Value = EMP_Firstname;

            parm[2] = new SqlParameter("@EMP_lastname", SqlDbType.NVarChar, 30);
            parm[2].Value = EMP_lastname;

            parm[3] = new SqlParameter("@EMP_Identity", SqlDbType.NVarChar , 30);
            parm[3].Value = EMP_Identity;

            parm[4] = new SqlParameter("@EMP_Age", SqlDbType.Int);
            parm[4].Value = EMP_Age;

            parm[5] = new SqlParameter("@EMP_Gender", SqlDbType.NVarChar,30);
            parm[5].Value = EMP_Gender;

            parm[6] = new SqlParameter("@EMP_Status", SqlDbType.NVarChar, 30);
            parm[6].Value = EMP_Status;

            parm[7] = new SqlParameter("@EMP_Job", SqlDbType.NVarChar, 30);
            parm[7].Value = EMP_Job;

            parm[8] = new SqlParameter("@EMP_Note", SqlDbType.NVarChar, 30);
            parm[8].Value = EMP_Note;

            parm[9] = new SqlParameter("@EMP_Salary", SqlDbType.NVarChar, 35);
            parm[9].Value = EMP_Salary;

            parm[10] = new SqlParameter("@EMP_Phone", SqlDbType.NVarChar,35);
            parm[10].Value = EMP_Phone;

            parm[11] = new SqlParameter("@EMP_Address", SqlDbType.NVarChar, 30);
            parm[11].Value = EMP_Address;

            parm[12] = new SqlParameter("@Date_Hair", SqlDbType.DateTime);
            parm[12].Value = Date_Hair;

            parm[13] = new SqlParameter("@EMP_Image", SqlDbType.Image);
            parm[13].Value = EMP_Image;

            parm[14] = new SqlParameter("@DOC_1", SqlDbType.Image);
            parm[14].Value = DOC_1;

            parm[15] = new SqlParameter("@DOC_2", SqlDbType.Image);
            parm[15].Value = DOC_2;

            parm[16] = new SqlParameter("@DOC_3", SqlDbType.Image);
            parm[16].Value = DOC_3;

            parm[17] = new SqlParameter("@DOC_4", SqlDbType.Image);
            parm[17].Value = DOC_4;

            parm[18] = new SqlParameter("@DOC_5", SqlDbType.Image);
            parm[18].Value = DOC_5;

            parm[19] = new SqlParameter("@DOC_6", SqlDbType.Image);
            parm[19].Value = DOC_6;

            parm[20] = new SqlParameter("@check", SqlDbType.NVarChar, 30);
            parm[20].Value = check;

            DAL.ExecuteCommand("ADD_EMPLOYEE", parm);
            DAL.close();
        }


        // EDITE EMPLOYEE DATA 
        public void UPDATE_EMPLOYEE(int Emp_ID, string EMP_Firstname, string EMP_lastname, string EMP_Identity, int EMP_Age, string EMP_Gender, string EMP_Status,
            string EMP_Job, string EMP_Note, string EMP_Salary, string EMP_Phone, string EMP_Address, DateTime Date_Hair,
            byte[] EMP_Image, byte[] DOC_1, byte[] DOC_2, byte[] DOC_3, byte[] DOC_4, byte[] DOC_5, byte[] DOC_6, string check)
        {

            DAL.open();
            SqlParameter[] parm = new SqlParameter[21];

            parm[0] = new SqlParameter("@Emp_ID", SqlDbType.Int);
            parm[0].Value = Emp_ID;

            parm[1] = new SqlParameter("@EMP_Firstname", SqlDbType.NVarChar, 30);
            parm[1].Value = EMP_Firstname;

            parm[2] = new SqlParameter("@EMP_Lastname", SqlDbType.NVarChar, 30);
            parm[2].Value = EMP_lastname;

            parm[3] = new SqlParameter("@EMP_Identity", SqlDbType.NVarChar, 30);
            parm[3].Value = EMP_Identity;

            parm[4] = new SqlParameter("@EMP_Age", SqlDbType.Int);
            parm[4].Value = EMP_Age;

            parm[5] = new SqlParameter("@EMP_Gender", SqlDbType.NVarChar, 30);
            parm[5].Value = EMP_Gender;

            parm[6] = new SqlParameter("@EMP_Status", SqlDbType.NVarChar, 30);
            parm[6].Value = EMP_Status;

            parm[7] = new SqlParameter("@EMP_Job", SqlDbType.NVarChar, 30);
            parm[7].Value = EMP_Job;

            parm[8] = new SqlParameter("@EMP_Note", SqlDbType.NVarChar, 30);
            parm[8].Value = EMP_Note;

            parm[9] = new SqlParameter("@EMP_Salary", SqlDbType.NVarChar, 35);
            parm[9].Value = EMP_Salary;

            parm[10] = new SqlParameter("@EMP_Phone", SqlDbType.NVarChar, 35);
            parm[10].Value = EMP_Phone;

            parm[11] = new SqlParameter("@EMP_Address", SqlDbType.NVarChar, 30);
            parm[11].Value = EMP_Address;

            parm[12] = new SqlParameter("@Date_Hair", SqlDbType.DateTime);
            parm[12].Value = Date_Hair;

            parm[13] = new SqlParameter("@EMP_Image", SqlDbType.Image);
            parm[13].Value = EMP_Image;

            parm[14] = new SqlParameter("@DOC_1", SqlDbType.Image);
            parm[14].Value = DOC_1;

            parm[15] = new SqlParameter("@DOC_2", SqlDbType.Image);
            parm[15].Value = DOC_2;

            parm[16] = new SqlParameter("@DOC_3", SqlDbType.Image);
            parm[16].Value = DOC_3;

            parm[17] = new SqlParameter("@DOC_4", SqlDbType.Image);
            parm[17].Value = DOC_4;

            parm[18] = new SqlParameter("@DOC_5", SqlDbType.Image);
            parm[18].Value = DOC_5;

            parm[19] = new SqlParameter("@DOC_6", SqlDbType.Image);
            parm[19].Value = DOC_6;

            parm[20] = new SqlParameter("@check", SqlDbType.NVarChar, 30);
            parm[20].Value = check;

            DAL.ExecuteCommand("UPDATE_EMPLOYEE", parm);
            DAL.close();
        }
    }
}
