using DemoCarParking;
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
    public partial class RemoveManager : Form
    {
        public RemoveManager()
        {
            InitializeComponent();
        }

        private void CloseButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveManager_Load(object sender, EventArgs e)
        {
            DbAccess db = new DbAccess();
            managerDataGridView.DataSource = db.GetAllValue("Manager");
            db.CloseConnection();
        }

        private void removeUserIDButton_Click(object sender, EventArgs e)
        {
            DbAccess db = new DbAccess();
            int x = db.Delete("Manager",Convert.ToInt32(iDTextBox.Text));
            if(x == 1)
            {
                MessageBox.Show("Manager Removed Succesfully");
                this.Hide();
            }
        }
    }
}
