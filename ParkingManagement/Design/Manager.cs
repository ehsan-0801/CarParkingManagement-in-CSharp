using DemoCarParking;
using ParkingManagement.Design;
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
    public partial class Manager : Form
    {
        public Manager()
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
            if(MemberPanel.Visible == true)
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
            if(subMenu.Visible == false)
            {
                HideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void MemberButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(MemberPanel);
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new AddMember());
            //Code
            HideSubmenu();
        }

        private void RemoveMemberButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new RemoveMember());
            //Code
            HideSubmenu();
        }

        private void UpdateMemberButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new UpdateMember());
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
            OpenAnotherForm(new MemberDetails());
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
            if(activeForm != null)
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

        private void ChildFormPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Manager_Load(object sender, EventArgs e)
        {
            ManagerLogic m1 = new ManagerLogic();
            m1.GetManager(Login.usernameLogin, Login.password);
            welcomeLabel1.Text +=" "+ Login.usernameLogin;
            managerNameLabel.Text += " " + m1.GetManagerName();
            managerUserIDLabel.Text += " " + m1.GetUserName();
            managerbloodGroupLabel.Text += " " + m1.GetManagerBloodGroup();
            managerDateOfBirthLabel.Text += " " + m1.GetManagerDateOfBirth();
            managerPhoneLabel.Text += " " + m1.GetManagerPhone();
            managerGenderLabel.Text += " " + m1.GetManagerGender();
            managerEmailLabel.Text += " " + m1.GetManagerGender();
            managerPictureBox1.Image = new Bitmap(m1.GetManagerPicture());
            managerPictureBox1.SizeMode= PictureBoxSizeMode.StretchImage;

        }

        private void SideMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WelcomeLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new chat().Show();
        }
    }
}
