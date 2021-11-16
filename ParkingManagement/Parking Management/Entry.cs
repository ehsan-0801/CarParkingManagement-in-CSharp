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
    class Entry
    {
        private int memberId;
        private string entryTime;
        private string exitTime;
        private string vehicleNo;
        private string vehicleType;
        private int allocatedSpaceNo;
        private string price;

        public void GetEntry(int id)
        {
            DbAccess da = new DbAccess();
            string sql = "SELECT * FROM Slots WHERE MemberId= '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, da.con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            try
            {
                memberId = Convert.ToInt32(dt.Rows[0]["MemberId"]);
                entryTime = dt.Rows[0]["EntryTime"].ToString();
                exitTime = dt.Rows[0]["ExitTime"].ToString();
                vehicleNo = dt.Rows[0]["VehicleNo"].ToString();
                vehicleType = dt.Rows[0]["VehicleType"].ToString();
                allocatedSpaceNo = Convert.ToInt32(dt.Rows[0]["AllocatedSpaceNo"]);
                price = dt.Rows[0]["Price"].ToString();
            }
            catch (Exception)
            {
                price = dt.Rows[0]["Price"].ToString();
            }
            da.CloseConnection();
        }

        public int getMemberId()
        {
            return memberId;
        }
        public string getEntryTime()
        {
            return entryTime;
        }
        public string getExitTime()
        {
            return exitTime;
        }
        public string getVehicleNo()
        {
            return vehicleNo;
        }
        public string getVehicleType()
        {
            return vehicleType;
        }

        public int getAllocatedSpaceNo()
        {
            return allocatedSpaceNo;
        }
        public string getPrice()
        {
            return price;
        }
    }
}
