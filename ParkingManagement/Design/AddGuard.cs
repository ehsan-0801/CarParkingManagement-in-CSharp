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
    public partial class AddGuard : Form
    {
        public AddGuard()
        {
            InitializeComponent();
        }

        private void CloseButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            string usname = "";
            try
            {
                DbAccess db = new DbAccess();
                string sql = "SELECT * FROM Guard";
                SqlCommand cmd = new SqlCommand(sql, db.con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                usname = dt.Rows[0]["Username"].ToString();
                db.CloseConnection();
            }
            catch (Exception)
            {
            }
            if (nameTextBox.Text.Equals(string.Empty) || usernameTextBox.Text.Equals(string.Empty) || passwordTextBox.Text.Equals(string.Empty) || confirmPasswordTextBox.Text.Equals(string.Empty) || guardPhonetextBox1.Text.Equals(string.Empty) || guardPhonetextBox1.Text.Equals(string.Empty))                                                      
            {
                MessageBox.Show("Field can not be empty");
            }
            else
            {
                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and confirm password must match");
                }
                else
                {
                    if ((maleRadioButton.Checked == false) && (femaleRadioButton.Checked == false))
                    {
                        MessageBox.Show("Please select gender");
                    }
                    else if (dateOfBirthPicker.Value.Date == DateTime.Now.Date)
                    {
                        MessageBox.Show("Please select date of birth");
                    }
                    else if (bloodGroupComboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Please select blood group");
                    }
                    else if (conditionCheckBox.Checked == false)
                    {
                        MessageBox.Show("Please select the agreement");
                    }
                    else if (usname.Equals(usernameTextBox.Text))
                    {
                        MessageBox.Show("This Username Already Exist. Please Use Different Username");
                    }
                    else
                    {
                        string name, username, password, gender, dob, bg, pic, phone, email;
                        name = nameTextBox.Text;
                        username = usernameTextBox.Text;
                        password = passwordTextBox.Text;
                        if (maleRadioButton.Checked)
                            gender = "Male";
                        else
                            gender = "Female";
                        dob = dateOfBirthPicker.Value.Date.ToString();
                        bg = bloodGroupComboBox.SelectedItem.ToString();
                        pic = path;
                        phone = guardPhonetextBox1.Text;
                        email = guardEmailtextBox2.Text;
                        DbAccess db2 = new DbAccess();
                        int i = db2.AddGuard(name, username, password, gender, dob,phone,email, bg, pic);
                        if (i == 1)
                        {
                            MessageBox.Show("Guard added successfully");
                            this.Hide();
                        }
                        db2.CloseConnection();
                    }
                }
            }
        }

        private void AddGuard_Load(object sender, EventArgs e)
        {

        }
    }
}
