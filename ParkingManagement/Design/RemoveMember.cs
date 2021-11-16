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
    public partial class RemoveMember : Form
    {
        public RemoveMember()
        {
            InitializeComponent();
        }

        private void CloseButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RemoveMember_Load(object sender, EventArgs e)
        {
            DbAccess db = new DbAccess();
            membersDataGridView.DataSource = db.GetAllValue("Member");
            db.CloseConnection();
        }

        private void removeUserIDButton_Click(object sender, EventArgs e)
        {
            DbAccess db = new DbAccess();
            int x = db.Delete("Member", Convert.ToInt32(iDTextBox.Text));
            if (x == 1)
            {
                MessageBox.Show("Member Removed Succesfully");
                this.Hide();
            }
        }
    }
}
