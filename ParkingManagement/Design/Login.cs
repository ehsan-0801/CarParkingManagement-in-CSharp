using GuardManagement;
using ParkingManagement;
using ParkingManagement.DataAccess;
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

namespace DemoCarParking
{
    public partial class Login : Form
    {
        public static string usernameLogin="";
        public static int IDLogin= 0;
        public static string password = "";
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userIdTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("User-Name cannot be empty");

            }
            else if (PasswordTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Password field cannot be empty");
            }
            else if (typeComboBox.Text.ToString().Equals("Select A Type"))
            {
                MessageBox.Show("Please Select An User Type");
            }
            else
            {
                if (typeComboBox.SelectedItem.ToString().Equals("Admin"))
                {
                    AdminLogic al = new AdminLogic();
                    al.GetAdmin(userIdTextBox.Text, PasswordTextBox.Text);
                    usernameLogin = al.GetUserName();
                    password = al.GetPassword();
                    IDLogin = al.GetAdminID();
                    if (userIdTextBox.Text.Equals(usernameLogin) && PasswordTextBox.Text.Equals(password))
                    {
                        this.Hide();
                        new Admin().Show();
                    }
                    else
                    {
                        MessageBox.Show("Username Or Password Not Found In The Database");
                    }
                }
                else if (typeComboBox.SelectedItem.ToString().Equals("Manager"))
                {
                    ManagerLogic ml = new ManagerLogic();
                    ml.GetManager(userIdTextBox.Text, PasswordTextBox.Text);
                    usernameLogin = ml.GetUserName();
                    password = ml.GetPassword();
                    IDLogin = ml.GetManagerID();
                    if (userIdTextBox.Text.Equals(usernameLogin) && PasswordTextBox.Text.Equals(password))
                    {
                        this.Hide();
                        new Manager().Show();
                    }
                    else
                    {
                        MessageBox.Show("Username Or Password Not Found In The Database");
                    }
                }
                else if (typeComboBox.SelectedItem.ToString().Equals("Guard"))
                {
                    GuardLogic gl = new GuardLogic();
                    gl.GetGuard(userIdTextBox.Text, PasswordTextBox.Text);
                    usernameLogin = gl.GetUserName();
                    password = gl.GetPassword();
                    IDLogin = gl.GetGuardID();
                    if (userIdTextBox.Text.Equals(usernameLogin) && PasswordTextBox.Text.Equals(password))
                    {
                        this.Hide();
                        new GuardForms().Show();
                    }
                    else
                    {
                        MessageBox.Show("Username Or Password Not Found In The Database");
                    }
                }

            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new ForgetPassword().Show();
        }
    }
}

