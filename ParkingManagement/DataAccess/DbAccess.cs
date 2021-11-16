using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.DataAccess
{
    class DbAccess
    {
        public SqlConnection con;
        SqlCommand command;
        public DbAccess()
        {
            this.con = new SqlConnection("Data Source=.;Initial Catalog=CarParking;Integrated Security=True");
            this.con.Open();
        }
        public void CloseConnection()
        {
            this.con.Close();
        }
        public int AddManager(params string[] inputs)
        {
            string sql = "INSERT INTO Manager(Name,Username,Password,Gender,DateOfBirth,Phone,Email,BloodGroup,Picture) VALUES('" + inputs[0] + "','" + inputs[1] + "','" + inputs[2] + "','" + inputs[3] + "','" + inputs[4] + "','" + inputs[5] + "','" + inputs[6] + "','"+ inputs[7]+"','"+ inputs[8] +"')";                                    
            command = new SqlCommand(sql, con);
            int result = command.ExecuteNonQuery();
            return result;
        }
        public int AddGuard(params string[] inputs)
        {
            string sql = "INSERT INTO Guard(Name,Username,Password,Gender,DateOfBirth,Phone,Email,BloodGroup,Picture) VALUES('" + inputs[0] + "','" + inputs[1] + "','" + inputs[2] + "','" + inputs[3] + "','" + inputs[4] + "','" + inputs[5] + "','" + inputs[6] + "','" + inputs[7] + "','" + inputs[8] + "')";
            command = new SqlCommand(sql, con);
            int result = command.ExecuteNonQuery();
            return result;
        }
        public int AddMember(params string[] inputs)
        {
            string sql = "INSERT INTO Member(Username,Gender,DateOfBirth,Bloodgroup,Phone,Email,VehicleType,VehicleNo,Picture) VALUES('" + inputs[0] + "','" + inputs[1] + "','" + inputs[2] + "','" + inputs[3] + "','" + inputs[4] + "','" + inputs[5] + "','" + inputs[6] + "','" + inputs[7] + "','" + inputs[8] + "')";
            command = new SqlCommand(sql, con);
            int result = command.ExecuteNonQuery();
            return result;
        }
        public DataTable GetAllValue(string tableName)
        {
            string sql = "SELECT * FROM " + tableName;
            SqlCommand cmd = new SqlCommand(sql, this.con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public int Delete(string tableName, int id)
        {
            string sql = "DELETE FROM " + tableName+ " WHERE Id="+id;
            SqlCommand cmd = new SqlCommand(sql, this.con);
            return cmd.ExecuteNonQuery();
        }
        public int SetValue(string tableName, int id, string columnname, string value)
        {
            string sql = "UPDATE "+tableName+
                          " SET "+columnname+ "="+ value +
                                "WHERE Id=" + id;
            SqlCommand cmd = new SqlCommand(sql, this.con);
            return cmd.ExecuteNonQuery();
        }

        public SqlDataReader Query(string sql)

        {

            return (new SqlCommand(sql, con)).ExecuteReader();

        }

        public int AddOfficialEntry(params string[] inputs)

        {

            string sql = "UPDATE Officials SET EntryTime='" + inputs[0] + "',AllocatedSpaceNo='" + inputs[1] + "' where VehicleNo='" + Program.vehicleNo + "'";

            command = new SqlCommand(sql, con);

            int result = command.ExecuteNonQuery();

            return result;

        }
        public int Exit(params string[] inputs)

        {

            string sql = "UPDATE Slots SET ExitTime='" + inputs[1] + "',AllocatedSpaceNo=NULL,Price='" + inputs[2] + "' WHERE MemberId='" + inputs[0] + "'";

            command = new SqlCommand(sql, con);

            int result = command.ExecuteNonQuery();

            return result;

        }


        public int AddEntry(params string[] inputs)

        {

            string sql = "INSERT INTO Slots(MemberId,EntryTime,ExitTime,VehicleNo,VehicleType,AllocatedSpaceNo,Price,SpaceHistory)VALUES('" + inputs[0] + "','" + inputs[1] + "','" + inputs[2] + "','" + inputs[3] + "','" + inputs[4] + "','" + inputs[5] + "','" + inputs[6] + "','" + inputs[5] + "')";

            command = new SqlCommand(sql, con);

            int result = command.ExecuteNonQuery();

            return result;

        }


        public int OfficialExit(params string[] inputs)

        {

            string sql = "UPDATE Officials SET ExitTime='" + inputs[0] + "',AllocatedSpaceNo=NULL WHERE VehicleNo='" + Program.vehicleNo + "'";

            command = new SqlCommand(sql, con);

            int result = command.ExecuteNonQuery();

            return result;

        }

    }
}