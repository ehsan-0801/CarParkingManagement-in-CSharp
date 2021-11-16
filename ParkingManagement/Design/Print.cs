using ParkingManagement.Parking_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagement.Design
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        private void Print_Load(object sender, EventArgs e)
        {
            Entry e1 = new Entry();
            e1.GetEntry(Program.memberId);
            MemberIDLabel.Text += " "+e1.getMemberId();
            EntryTimeLabel.Text += " "+e1.getEntryTime();
            ExitTimeLabel.Text += " " + e1.getExitTime();
            VehicleNoLabel.Text += " " + e1.getVehicleNo();
            VehicleTypeLabel.Text += " " + e1.getVehicleType();
            PriceLabel.Text += " " + e1.getPrice();
        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
