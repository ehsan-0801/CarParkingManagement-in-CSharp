using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingManagement;
using DemoCarParking;
using ParkingManagement.DataAccess;
using System.Data.SqlClient;

namespace GuardManagement
{
    public partial class GuardTaskOff : Form
    {
        public GuardTaskOff()
        {
            InitializeComponent();
        }

        private void BackOffButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (VehicleNoTextBox.Text.Equals(string.Empty) || AllocatedSpaceNoTextbox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Field can not be empty");
            }
            else
            {
                string vNo = VehicleNoTextBox.Text;
                int sNo = int.Parse(AllocatedSpaceNoTextbox.Text);
                DbAccess db = new DbAccess();
                SqlDataReader sd = db.Query("SELECT * FROM Officials");
                bool vehicleExists = false;
                while (sd.Read())
                {
                    string _vNo = (string)sd.GetValue(sd.GetOrdinal("VehicleNo"));
                    if (vNo == _vNo)
                    {
                        vehicleExists = true;
                        Program.vehicleNo = (string) sd.GetValue(sd.GetOrdinal("VehicleNo"));
                        break;
                    }
                }
                if (vehicleExists)
                {
                    try
                    {
                        DbAccess db3 = new DbAccess();
                        string sql = "SELECT * FROM Officials";
                        SqlCommand cmd = new SqlCommand(sql, db3.con);
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        if (dt.Rows[0]["AllocatedSpaceNo"].ToString().Equals(AllocatedSpaceNoTextbox.Text))
                        {
                            MessageBox.Show("Space already been taken");
                            db3.CloseConnection();
                        }
                        else 
                        {
                            string entryTime, exitTime, vehicleNo, vehicleType, allocatedSpaceNo;
                            vehicleNo = Program.vehicleNo;
                            entryTime = EntryDateTimePicker.Value.ToString();
                            exitTime = null;
                            allocatedSpaceNo = AllocatedSpaceNoTextbox.Text;
                            DbAccess db2 = new DbAccess();
                            int i = db2.AddOfficialEntry(entryTime, allocatedSpaceNo);
                            if (i == 1)
                            {
                                MessageBox.Show("Entry added successfully");
                                this.Hide();
                            }
                            db2.CloseConnection();
                        }
                    }
                    catch
                    {
                        //string entryTime, exitTime, vehicleNo, vehicleType, allocatedSpaceNo;
                        //vehicleNo = Program.vehicleNo;
                        //entryTime = EntryDateTimePicker.Value.ToString();
                        //exitTime = null;
                        //allocatedSpaceNo = AllocatedSpaceNoTextbox.Text;
                        //DbAccess db2 = new DbAccess();
                        //int i = db2.AddOfficialEntry(entryTime, allocatedSpaceNo);
                        //if (i == 1)
                        //{
                        //    MessageBox.Show("Entry added successfully");
                        //    this.Hide();
                        //}
                        //db2.CloseConnection();
                    }                    
                }
                else
                {
                    MessageBox.Show("Vehicle Not Found");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EntryDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AllocatedSpaceNoTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VehicleNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VehicleNoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
