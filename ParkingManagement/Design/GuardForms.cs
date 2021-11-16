using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingManagement;
using DemoCarParking;
using ParkingManagement.Parking_Management;
using ParkingManagement.Design;


namespace GuardManagement
{
    public partial class GuardForms : Form
    {
        public GuardForms()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            EntryOpPanel.Visible = false;
            ExitOpPanel.Visible = false;
        }
        private void HideSubmenu()
        {
            if (EntryOpPanel.Visible == true)
                EntryOpPanel.Visible = false;
            if (ExitOpPanel.Visible == true)
                ExitOpPanel.Visible = false;

        }
        private void Showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true; 
            }
            else
            submenu.Visible = false;
        }



        private void GuardForms_Load(object sender, EventArgs e)
        {
            GuardLogic g1 = new GuardLogic();
            g1.GetGuard(Login.usernameLogin, Login.password);
            WelcomeLabel.Text += " " + Login.usernameLogin;
            GuardNameLabel.Text += " " + g1.GetGuardName();
            GuardUserIdLabel.Text += " " + g1.GetGuardID();
            GuardBloodGroupLabel.Text += " " + g1.GetGuardBloodGroup();
            GuardDateOfBirthLabel.Text += " " + g1.GetGuardDateOfBirth();
            GuardPhoneLabel.Text += " " + g1.GetGuardPhone();
            GuardEmailLabel.Text += " " + g1.GetGuardEmail();
            GuardGenderLabel.Text += " " + g1.GetGuardGender();
            GuardPictureBox.Image = new Bitmap(g1.GetGuardPicture());
            GuardPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ContactManagerbutton_Click(object sender, EventArgs e)
        {
            new chat().Show();
        }

        private void ParkingDetailsbutton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new ParkingDetails());
        }

        private void MemberDetailsbutton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new MemberDetails());
            //...
            HideSubmenu();
        }

        private void EntryOpbutton_Click(object sender, EventArgs e)
        {
            Showsubmenu(EntryOpPanel);
       
        }

        private void EntryOpPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OfficialsEnbutton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new GuardTaskOff());

        }

        private void NormalEnbutton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new GuardTaskEn());
         
        }

        private void ExitOpbutton_Click(object sender, EventArgs e)
        {
            Showsubmenu(ExitOpPanel);

        }

        private void OffcialsExbutton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new GuardExitOfficial());

        }

        private void NormalExbutton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new GuardExitNormal());

        }

        private void GuardForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
       

        private void ChildFormPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
