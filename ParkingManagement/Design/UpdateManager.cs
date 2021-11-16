using ParkingManagement.DataAccess;
using ParkingManagement.Parking_Management;
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
    public partial class UpdateManager : Form
    {
        public UpdateManager()
        {
            InitializeComponent();
        }

        private void CloseButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateManager_Load(object sender, EventArgs e)
        {
            DbAccess db = new DbAccess();
            managerDataGridView.DataSource = db.GetAllValue("Manager");
            db.CloseConnection();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Equals(string.Empty) || nameTextBox.Text.Equals(string.Empty) || bloodGroupComboBox.SelectedItem == null)
            {
                MessageBox.Show("Fields can not be empty");
            }
            else
            {
                try
                {
                    DbAccess db = new DbAccess();
                    string sql = "UPDATE Manager SET Username='" + usernameTextBox.Text + "',Name='" + nameTextBox.Text + "',BloodGroup='" + bloodGroupComboBox.SelectedItem.ToString() +"',DateOfBirth='" + dateOfBirthPicker.Value.Date.ToString() + "',Picture='" + path  +"'WHERE Id=" + Convert.ToInt32(iDTextBox.Text);
                    SqlCommand command = new SqlCommand(sql, db.con);
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    MessageBox.Show("Manager Updated successfully");
                    this.Close();
                    db.CloseConnection();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Updating Manager");
                }
            }
        }
        string path;
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

        private void fullDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                DbAccess db = new DbAccess();
                string sql = "SELECT * FROM Manager WHERE Id=" + Convert.ToInt32(iDTextBox.Text);
                SqlCommand cmd = new SqlCommand(sql, db.con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                usernameTextBox.Text = dt.Rows[0]["Username"].ToString();
                nameTextBox.Text = dt.Rows[0]["Name"].ToString();
                dateOfBirthPicker.Value = Convert.ToDateTime(dt.Rows[0]["DateOfBirth"].ToString());
                bloodGroupComboBox.SelectedText = dt.Rows[0]["BloodGroup"].ToString();
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
    }
}
