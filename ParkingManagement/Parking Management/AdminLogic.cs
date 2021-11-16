using ParkingManagement.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.Parking_Management
{
    class AdminLogic
    {
        private string username;
        private string password;
        private int adminId;
        private string adminName;
        private string adminGender;
        private string adminDateOfBirth;
        private string adminBloodGroup;
        private string adminPhone;
        private string adminMail;
        private string adminPicture;
        public void GetAdmin(string uname, string pass)
        {
            DbAccess da = new DbAccess();
            string sql = "SELECT * FROM Admin WHERE Username='" + uname + "'AND Password='" + pass + "'";
            SqlCommand cmd = new SqlCommand(sql, da.con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            try
            {
                username = dt.Rows[0]["Username"].ToString();
                password = dt.Rows[0]["Password"].ToString();
                adminId = Convert.ToInt32(dt.Rows[0]["Id"]);
                adminName = dt.Rows[0]["Name"].ToString();
                adminGender = dt.Rows[0]["Gender"].ToString();
                adminDateOfBirth = dt.Rows[0]["DateOfBirth"].ToString();
                adminBloodGroup = dt.Rows[0]["BloodGroup"].ToString();
                adminPicture = dt.Rows[0]["Picture"].ToString();
                adminPhone = dt.Rows[0]["Phone"].ToString();
                adminMail = dt.Rows[0]["Email"].ToString();
            }
            catch (Exception)
            {
                username = null;
                password = null;
            }

            da.CloseConnection();
        }
        public string GetUserName()
        {
            return username;
        }
        public string GetPassword()
        {
            return password;
        }
        public int GetAdminID()
        {
            return adminId;
        }
        public string GetAdminName()
        {
            return adminName;
        }
        public string GetAdminGender()
        {
            return adminGender;
        }
        public string GetAdminDateOfBirth()
        {
            return adminDateOfBirth;
        }
        public string GetAdminBloodGroup()
        {
            return adminBloodGroup;
        }
        public string GetAdminPicture()
        {
            return adminPicture;
        }
        public string GetAdminPhone()
        {
            return adminPhone;
        }
        public string GetAdminMail()
        {
            return adminMail;
        }
    }
}
