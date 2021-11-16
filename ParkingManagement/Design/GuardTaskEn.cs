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
    public partial class GuardTaskEn : Form
    {
        public GuardTaskEn()
        {
            InitializeComponent();
        }

        private void GuardTaskEn_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (MemberNametextBox.Text.Equals(string.Empty) || MemberIDtextBox.Text.Equals(string.Empty) || VehicleNumbertextBox.Text.Equals(string.Empty) || AllocatedSpaceNoTextbox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Field can not be empty");
            }
            else
            {
                int id = int.Parse(MemberIDtextBox.Text);
                int space = int.Parse(AllocatedSpaceNoTextbox.Text);
                DbAccess db = new DbAccess();
                SqlDataReader sd = db.Query("SELECT * FROM Member");
                bool memberExists = false;
                while (sd.Read())
                {
                    int _memberid = (int)sd.GetValue(sd.GetOrdinal("Id"));
                    if (id == _memberid)
                    {
                        memberExists = true;
                        Program.memberId = (int)sd.GetValue(sd.GetOrdinal("Id"));
                        break;
                    }
                }
                if (memberExists)
                {
                    if ((CarRadioButton.Checked == false) && (BikeRadioButton.Checked == false) && (OthersRadioButton.Checked == false))
                    {
                        MessageBox.Show("Please select vehicle type");
                    }
                    else
                    {
                        try
                        {
                            DbAccess db3 = new DbAccess();
                            string sql = "SELECT * FROM Slots";
                            SqlCommand cmd = new SqlCommand(sql, db3.con);
                            DataTable dt = new DataTable();
                            dt.Load(cmd.ExecuteReader());
                            if (dt.Rows[0]["AllocatedSpaceNo"].ToString().Equals(AllocatedSpaceNoTextbox.Text))
                            {
                                MessageBox.Show("Space already been taken");
                                db3.CloseConnection();
                            }
                        }
                        catch 
                        {
                            string memberId, entryTime, exitTime, vehicleNo, vehicleType, allocatedSpaceNo, price;
                            memberId = Program.memberId.ToString();
                            entryTime = EntryDateTimePicker.Value.ToString();
                            exitTime = null;
                            vehicleNo = VehicleNumbertextBox.Text;
                            if (CarRadioButton.Checked)
                                vehicleType = "Car";
                            else if (BikeRadioButton.Checked)
                                vehicleType = "Bike";
                            else
                                vehicleType = "Others";
                            allocatedSpaceNo = AllocatedSpaceNoTextbox.Text;
                            price = null;
                            DbAccess db2 = new DbAccess();
                            int i = db2.AddEntry(memberId, entryTime, exitTime, vehicleNo, vehicleType, allocatedSpaceNo, price);
                            if (i == 1)
                            {
                                MessageBox.Show("Entry added successfully");
                                this.Hide();
                            }
                            db2.CloseConnection();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Member Not Found");
                }
            }
        }
    }
}
