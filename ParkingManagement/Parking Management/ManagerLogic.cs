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
    class ManagerLogic
    {
        private string username;
        private string password;
        private int managerId;
        private string managerName;
        private string managerGender;
        private string managerDateOfBirth;
        private string managerBloodGroup;
        private string managerPhone;
        private string managerEmail;
        private string managerPicture;
        public void GetManager(string uname, string pass)
        {
            DbAccess da = new DbAccess();
            string sql = "SELECT * FROM Manager WHERE Username='" + uname + "'AND Password='" + pass + "'";
            SqlCommand cmd = new SqlCommand(sql, da.con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            try
            {
                username = dt.Rows[0]["Username"].ToString();
                password = dt.Rows[0]["Password"].ToString();
                managerId = Convert.ToInt32(dt.Rows[0]["Id"]);
                managerName = dt.Rows[0]["Name"].ToString();
                managerGender = dt.Rows[0]["Gender"].ToString();
                managerDateOfBirth = dt.Rows[0]["DateOfBirth"].ToString();
                managerBloodGroup = dt.Rows[0]["BloodGroup"].ToString();
                managerPicture = dt.Rows[0]["Picture"].ToString();
                managerPhone = dt.Rows[0]["Phone"].ToString();
                managerEmail = dt.Rows[0]["Email"].ToString();
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
        public int GetManagerID()
        {
            return managerId;
        }
        public string GetManagerName()
        {
            return managerName;
        }
        public string GetManagerGender()
        {
            return managerGender;
        }
        public string GetManagerDateOfBirth()
        {
            return managerDateOfBirth;
        }
        public string GetManagerBloodGroup()
        {
            return managerBloodGroup;
        }
        public string GetManagerPicture()
        {
            return managerPicture;
        }
        public string GetManagerPhone()
        {
            return managerPhone;
        }
        public string GetManagerEmail()
        {
            return managerEmail;
        }
    }
}
