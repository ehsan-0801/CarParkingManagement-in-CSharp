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
    public partial class GuardExitOfficial : Form
    {
        public GuardExitOfficial()
        {
            InitializeComponent();
        }

        private void BackExOffButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (VehicleNoTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please provide vehicle no");
            }
            else
            {
                string vNo = VehicleNoTextBox.Text;
                DbAccess db = new DbAccess();
                SqlDataReader sd = db.Query("SELECT * FROM Officials");
                bool vehicleExists = false;
                while (sd.Read())
                {
                    string _vNo = (string)sd.GetValue(sd.GetOrdinal("VehicleNo"));
                    if (vNo == _vNo)
                    {
                        vehicleExists = true;
                        Program.vehicleNo = (string)sd.GetValue(sd.GetOrdinal("VehicleNo"));
                        break;
                    }
                }
                if (vehicleExists)
                {

                    string exitTime, vehicleNo;
                    vehicleNo = Program.vehicleNo;
                    exitTime = ExitDateTimePicker.Value.ToString();
                    DbAccess db2 = new DbAccess();
                    int i = db2.OfficialExit(exitTime);
                    if (i == 1)
                    {
                        MessageBox.Show("Entry updated successfully");
                        this.Hide();
                    }
                    db2.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Vehicle Not Found");
                }
            }
        }

        private void GuardExitOfficial_Load(object sender, EventArgs e)
        {

        }
    }
}
