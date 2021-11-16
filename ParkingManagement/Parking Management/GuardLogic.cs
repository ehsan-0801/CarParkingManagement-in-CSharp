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
    class GuardLogic
    {
        private string username;
        private string password;
        private int guardId;
        private string guardName;
        private string guardGender;
        private string guardDateOfBirth;
        private string guardBloodGroup;
        private string guardPicture;
        private string guardPhone;
        private string guardEmail;
        public void GetGuard(string uname, string pass)
        {
            DbAccess da = new DbAccess();
            string sql = "SELECT * FROM Guard WHERE Username='" + uname + "'AND Password='" + pass + "'";
            SqlCommand cmd = new SqlCommand(sql, da.con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            try
            {
                username = dt.Rows[0]["Username"].ToString();
                password = dt.Rows[0]["Password"].ToString();
                guardId = Convert.ToInt32(dt.Rows[0]["Id"]);
                guardName = dt.Rows[0]["Name"].ToString();
                guardGender = dt.Rows[0]["Gender"].ToString();
                guardDateOfBirth = dt.Rows[0]["DateOfBirth"].ToString();
                guardPhone = dt.Rows[0]["Phone"].ToString();
                guardEmail = dt.Rows[0]["Email"].ToString();
                guardBloodGroup = dt.Rows[0]["BloodGroup"].ToString();
                guardPicture = dt.Rows[0]["Picture"].ToString();
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
        public int GetGuardID()
        {
            return guardId;
        }
        public string GetGuardName()
        {
            return guardName;
        }
        public string GetGuardGender()
        {
            return guardGender;
        }
        public string GetGuardDateOfBirth()
        {
            return guardDateOfBirth;
        }
        public string GetGuardPhone()
        {
            return guardPhone;
        }
        public string GetGuardEmail()
        {
            return guardEmail;
        }
        public string GetGuardBloodGroup()
        {
            return guardBloodGroup;
        }
        public string GetGuardPicture()
        {
            return guardPicture;
        }
    }
}
