using DemoCarParking;
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

namespace ParkingManagement
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            CustomDesign();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CustomDesign()
        {
            MemberPanel.Visible = false;
            GuardPanel.Visible = false;
        }
        private void HideSubmenu()
        {
            if (MemberPanel.Visible == true)
            {
                MemberPanel.Visible = false;
            }
            if (GuardPanel.Visible == true)
            {
                GuardPanel.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void ManagerButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(MemberPanel);
        }

        private void AddManagerButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new AddManager());
            //Code
            HideSubmenu();
        }

        private void RemoveManagerButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new RemoveManager());
            //Code
            HideSubmenu();
        }

        private void UpdateManagerButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new UpdateManager());
            //Code
            HideSubmenu();
        }

        private void GuardButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(GuardPanel);
        }

        private void AddGuardButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new AddGuard());
            //Code
            HideSubmenu();
        }

        private void RemoveGuardButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new RemoveGuard());
            //Code
            HideSubmenu();
        }

        private void UpdateGuardButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new UpdateGuard());
            //Code
            HideSubmenu();
        }

        private void MemberDetailsButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new AllMembers());
            //Code
            HideSubmenu();
        }

        private void ParkingDetailsButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new ParkingDetails());
            //Code
            HideSubmenu();
        }

        private Form activeForm = null;
        private void OpenAnotherForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(childForm);
            ChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //open login form
            this.Hide();
            new Login().Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            AdminLogic al = new AdminLogic();
            al.GetAdmin(Login.usernameLogin, Login.password) ;
            welcomeLabel.Text += Login.usernameLogin;
            AdminNameLabel.Text +=" "+ al.GetAdminName();
            adminUserIDLabel.Text += " " + al.GetUserName();
            genderLabel.Text += " " + al.GetAdminGender();
            dateOfBirthLabel.Text += " " + al.GetAdminDateOfBirth();
            bloodGroupLabel.Text += " " + al.GetAdminBloodGroup();
            pictureBox1.Image = new Bitmap(al.GetAdminPicture());
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            phoneLabel.Text += " " + al.GetAdminPhone();
            emailLabel.Text += " " + al.GetAdminMail();
        }
    }
}

