using ParkingManagement.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagement
{
    public partial class UpdateMember : Form
    {
        public UpdateMember()
        {
            InitializeComponent();
        }

        private void CloseButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateMember_Load(object sender, EventArgs e)
        {
            DbAccess db = new DbAccess();
            membersDataGridView.DataSource = db.GetAllValue("Member");
            db.CloseConnection();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Equals(string.Empty) || phoneTextBox.Text.Equals(string.Empty) || bloodGroupComboBox.SelectedItem == null)
            {
                MessageBox.Show("Fields can not be empty");
            }
            else
            {
                try
                {
                    DbAccess db = new DbAccess();
                    string sql = "UPDATE Member SET Username='" + usernameTextBox.Text + "',Phone='" + phoneTextBox.Text + "',BloodGroup='" + bloodGroupComboBox.SelectedItem.ToString() + "',DateOfBirth='" + dateOfBirthPicker.Value.Date.ToString() + "',Picture='" + path + "',Email='"+emailTextBox.Text.ToString()+ "',VehicleType='"+vehicleComboBox.SelectedItem.ToString()+ "',VehicleNo='"+vehicleNoTextBox.Text.ToString() + "'WHERE Id=" + Convert.ToInt32(iDTextBox.Text);
                    SqlCommand command = new SqlCommand(sql, db.con);
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    MessageBox.Show("Member Updated successfully");
                    this.Close();
                    db.CloseConnection();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Updating Member");
                }
            }
        }
        string path;
        private void fullDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                DbAccess db = new DbAccess();
                string sql = "SELECT * FROM Member WHERE Id=" + Convert.ToInt32(iDTextBox.Text);
                SqlCommand cmd = new SqlCommand(sql, db.con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                usernameTextBox.Text = dt.Rows[0]["Username"].ToString();
                phoneTextBox.Text = dt.Rows[0]["Phone"].ToString();
                dateOfBirthPicker.Value = Convert.ToDateTime(dt.Rows[0]["DateOfBirth"].ToString());
                bloodGroupComboBox.SelectedText = dt.Rows[0]["BloodGroup"].ToString();
                emailTextBox.Text = dt.Rows[0]["Email"].ToString();
                vehicleComboBox.SelectedText = dt.Rows[0]["VehicleType"].ToString();
                vehicleNoTextBox.Text = dt.Rows[0]["VehicleNo"].ToString();
                path = dt.Rows[0]["Picture"].ToString();
                pictureBox1.Image = new Bitmap(path);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                db.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("ID not Found");
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please Enter Username First");
            }
            else
            {
                OpenFileDialog fd = new OpenFileDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(fd.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    path = Path.GetFullPath("PictureData") + @"\" + usernameTextBox.Text + ".jpg";
                    File.Copy(fd.FileName, path, true);
                }
            }
        }
    }
}