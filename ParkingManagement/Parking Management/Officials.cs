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
    class Officials
    {
        private string vehicleNo;
        private string entryTime;
        private string exitTime;
        private int allocatedSpaceNo;
        private string vehicleType;

        public void GetOfficialEntry(string vehicleNo)
        {
            DbAccess da = new DbAccess();
            string sql = "SELECT * FROM Officials WHERE VehicleNo= '" + vehicleNo + "'";
            SqlCommand cmd = new SqlCommand(sql, da.con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            try
            {
                vehicleNo = dt.Rows[0]["VehicleNo"].ToString();
                entryTime = dt.Rows[0]["EntryTime"].ToString();
                exitTime = dt.Rows[0]["ExitTime"].ToString();
                allocatedSpaceNo = int.Parse(dt.Rows[0]["AllocatedSpaceNo"].ToString());
                vehicleType = dt.Rows[0]["VehicleType"].ToString();

            }
            catch (Exception)
            {
            }
            da.CloseConnection();
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
    }
}
