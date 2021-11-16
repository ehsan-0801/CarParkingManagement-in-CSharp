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

namespace ParkingManagement.Design
{
    public partial class MemberDetails : Form
    {
        public MemberDetails()
        {
            InitializeComponent();
        }

        private void CloseButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MemberDetails_Load(object sender, EventArgs e)
        {
            DbAccess db = new DbAccess();
            guardDataGridView.DataSource = db.GetAllValue("Guard");
            membersDataGridView.DataSource = db.GetAllValue("Member");
            db.CloseConnection();
        }
    }
}
