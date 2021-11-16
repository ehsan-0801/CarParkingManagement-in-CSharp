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
using ParkingManagement.Design;

namespace GuardManagement
{
    public partial class GuardExitNormal : Form
    {
        public GuardExitNormal()
        {
            InitializeComponent();
        }

        private void BackExNormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (MemberIdTextbox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please provide Member ID");
            }
            else 
            {
                int id = int.Parse(MemberIdTextbox.Text);
                DbAccess db = new DbAccess();
                SqlDataReader sd = db.Query("SELECT * FROM Slots");
                bool memberExists = false;
                while (sd.Read())
                {
                    int _memberid = (int)sd.GetValue(sd.GetOrdinal("MemberId"));
                    if (id == _memberid)
                    {
                        memberExists = true;
                        Program.memberId = (int)sd.GetValue(sd.GetOrdinal("MemberId"));
                        break;
                    }
                }
                if (memberExists)
                {
                    if (PriceComboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Please calculate and provide price");
                    }
                    else
                    {
                        string memberId, exitTime, price, allocatedSpaceNo;
                        memberId = Program.memberId.ToString();
                        exitTime = ExitDateTimePicker.Value.ToString();
                        price = PriceComboBox.SelectedItem.ToString();
                        allocatedSpaceNo = null;
                        DbAccess db2 = new DbAccess();
                        int i = db2.Exit(memberId, exitTime, price, allocatedSpaceNo);
                        if (i == 1)
                        {
                            MessageBox.Show("Entry updated successfully");
                        }
                        db2.CloseConnection();
                    }
                }
                else
                {
                    MessageBox.Show("Member is not present");
                }
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            new Print().Show();
        }
    }
}
