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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void CloseButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //string x = textBox1.Text;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        string path;
        static int count = 0;

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                count++;
                pictureBox1.Image = new Bitmap(fd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                path = Path.GetFullPath("PictureData") + @"\"+ count + ".jpg";
                File.Copy(fd.FileName, path, true);
            }


        }
        
        private void browseButton_Click(object sender, EventArgs e)
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
            if ( usernameTextBox.Text.Equals(string.Empty) || memberPhonetextBox1.Text.Equals(string.Empty) || memberEmailtextBox2.Text.Equals(string.Empty))
            {
                MessageBox.Show("Field can not be empty");
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
                        string username, gender, dob, bg, pic, phone, email,vehicleType,vehicleNo;
                        
                        username = usernameTextBox.Text;
                        
                        if (maleRadioButton.Checked)
                            gender = "Male";
                        else
                            gender = "Female";
                        dob = dateOfBirthPicker.Value.Date.ToString();
                        bg = bloodGroupComboBox.SelectedItem.ToString();
                        pic = path;
                        phone = memberPhonetextBox1.Text;
                        email = memberEmailtextBox2.Text;
                        vehicleType = vehicleTypeComboBox1.SelectedItem.ToString();
                        vehicleNo = memberVehicletextBox3.Text;

                        DbAccess db2 = new DbAccess();
                        int i = db2.AddMember(username, gender, dob, bg, phone, email, vehicleType,vehicleNo, pic);
                        if (i == 1)
                        {
                            MessageBox.Show("Member added successfully");
                            this.Hide();
                        }
                        db2.CloseConnection();
                    }
              
            }
        }
    }
 }

