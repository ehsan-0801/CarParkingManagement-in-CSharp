using ParkingManagement.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagement
{
    public partial class ParkingDetails : Form
    {
        public ParkingDetails()
        {
            InitializeComponent();
        }

        private void CloseButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ParkingDetails_Load(object sender, EventArgs e)
        {
            DbAccess db = new DbAccess();
            parkindDetailsdataGridView.DataSource = db.GetAllValue("Slots");
            

            officialDataGridView1.DataSource = db.GetAllValue("Officials");
            db.CloseConnection();
        }
    }
}
