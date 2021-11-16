namespace ParkingManagement
{
    partial class Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.ParkingDetailsButton = new System.Windows.Forms.Button();
            this.MemberDetailsButton = new System.Windows.Forms.Button();
            this.GuardPanel = new System.Windows.Forms.Panel();
            this.UpdateGuardButton = new System.Windows.Forms.Button();
            this.RemoveGuardButton = new System.Windows.Forms.Button();
            this.AddGuardButton = new System.Windows.Forms.Button();
            this.GuardButton = new System.Windows.Forms.Button();
            this.MemberPanel = new System.Windows.Forms.Panel();
            this.UpdateManagerButton = new System.Windows.Forms.Button();
            this.RemoveManagerButton = new System.Windows.Forms.Button();
            this.AddManagerButton = new System.Windows.Forms.Button();
            this.ManagerButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.welcomeLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.managerEmailLabel = new System.Windows.Forms.Label();
            this.managerPhoneLabel = new System.Windows.Forms.Label();
            this.managerPictureBox1 = new System.Windows.Forms.PictureBox();
            this.managerbloodGroupLabel = new System.Windows.Forms.Label();
            this.managerDateOfBirthLabel = new System.Windows.Forms.Label();
            this.managerGenderLabel = new System.Windows.Forms.Label();
            this.managerUserIDLabel = new System.Windows.Forms.Label();
            this.managerNameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SideMenuPanel.SuspendLayout();
            this.GuardPanel.SuspendLayout();
            this.MemberPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ChildFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.AutoScroll = true;
            this.SideMenuPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SideMenuPanel.Controls.Add(this.button1);
            this.SideMenuPanel.Controls.Add(this.ParkingDetailsButton);
            this.SideMenuPanel.Controls.Add(this.MemberDetailsButton);
            this.SideMenuPanel.Controls.Add(this.GuardPanel);
            this.SideMenuPanel.Controls.Add(this.GuardButton);
            this.SideMenuPanel.Controls.Add(this.MemberPanel);
            this.SideMenuPanel.Controls.Add(this.ManagerButton);
            this.SideMenuPanel.Controls.Add(this.panel1);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(254, 755);
            this.SideMenuPanel.TabIndex = 0;
            this.SideMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SideMenuPanel_Paint);
            // 
            // ParkingDetailsButton
            // 
            this.ParkingDetailsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ParkingDetailsButton.FlatAppearance.BorderSize = 0;
            this.ParkingDetailsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ParkingDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParkingDetailsButton.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ParkingDetailsButton.Location = new System.Drawing.Point(0, 511);
            this.ParkingDetailsButton.Name = "ParkingDetailsButton";
            this.ParkingDetailsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ParkingDetailsButton.Size = new System.Drawing.Size(254, 45);
            this.ParkingDetailsButton.TabIndex = 6;
            this.ParkingDetailsButton.Text = "Parking Details";
            this.ParkingDetailsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ParkingDetailsButton.UseVisualStyleBackColor = true;
            this.ParkingDetailsButton.Click += new System.EventHandler(this.ParkingDetailsButton_Click);
            // 
            // MemberDetailsButton
            // 
            this.MemberDetailsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemberDetailsButton.FlatAppearance.BorderSize = 0;
            this.MemberDetailsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MemberDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberDetailsButton.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.MemberDetailsButton.Location = new System.Drawing.Point(0, 466);
            this.MemberDetailsButton.Name = "MemberDetailsButton";
            this.MemberDetailsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MemberDetailsButton.Size = new System.Drawing.Size(254, 45);
            this.MemberDetailsButton.TabIndex = 5;
            this.MemberDetailsButton.Text = "Member Details";
            this.MemberDetailsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MemberDetailsButton.UseVisualStyleBackColor = true;
            this.MemberDetailsButton.Click += new System.EventHandler(this.MemberDetailsButton_Click);
            // 
            // GuardPanel
            // 
            this.GuardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.GuardPanel.Controls.Add(this.UpdateGuardButton);
            this.GuardPanel.Controls.Add(this.RemoveGuardButton);
            this.GuardPanel.Controls.Add(this.AddGuardButton);
            this.GuardPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GuardPanel.Location = new System.Drawing.Point(0, 325);
            this.GuardPanel.Name = "GuardPanel";
            this.GuardPanel.Size = new System.Drawing.Size(254, 141);
            this.GuardPanel.TabIndex = 4;
            // 
            // UpdateGuardButton
            // 
            this.UpdateGuardButton.FlatAppearance.BorderSize = 0;
            this.UpdateGuardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UpdateGuardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.UpdateGuardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateGuardButton.ForeColor = System.Drawing.Color.LightGray;
            this.UpdateGuardButton.Location = new System.Drawing.Point(3, 86);
            this.UpdateGuardButton.Name = "UpdateGuardButton";
            this.UpdateGuardButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.UpdateGuardButton.Size = new System.Drawing.Size(250, 40);
            this.UpdateGuardButton.TabIndex = 2;
            this.UpdateGuardButton.Text = "Update Member";
            this.UpdateGuardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateGuardButton.UseVisualStyleBackColor = true;
            this.UpdateGuardButton.Click += new System.EventHandler(this.UpdateMemberButton_Click);
            // 
            // RemoveGuardButton
            // 
            this.RemoveGuardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveGuardButton.FlatAppearance.BorderSize = 0;
            this.RemoveGuardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RemoveGuardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.RemoveGuardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveGuardButton.ForeColor = System.Drawing.Color.LightGray;
            this.RemoveGuardButton.Location = new System.Drawing.Point(0, 40);
            this.RemoveGuardButton.Name = "RemoveGuardButton";
            this.RemoveGuardButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.RemoveGuardButton.Size = new System.Drawing.Size(254, 40);
            this.RemoveGuardButton.TabIndex = 1;
            this.RemoveGuardButton.Text = "Remove Member";
            this.RemoveGuardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveGuardButton.UseVisualStyleBackColor = true;
            this.RemoveGuardButton.Click += new System.EventHandler(this.RemoveMemberButton_Click);
            // 
            // AddGuardButton
            // 
            this.AddGuardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddGuardButton.FlatAppearance.BorderSize = 0;
            this.AddGuardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddGuardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.AddGuardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGuardButton.ForeColor = System.Drawing.Color.LightGray;
            this.AddGuardButton.Location = new System.Drawing.Point(0, 0);
            this.AddGuardButton.Name = "AddGuardButton";
            this.AddGuardButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.AddGuardButton.Size = new System.Drawing.Size(254, 40);
            this.AddGuardButton.TabIndex = 0;
            this.AddGuardButton.Text = "Add Member";
            this.AddGuardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddGuardButton.UseVisualStyleBackColor = true;
            this.AddGuardButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // GuardButton
            // 
            this.GuardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.GuardButton.FlatAppearance.BorderSize = 0;
            this.GuardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.GuardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardButton.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.GuardButton.Location = new System.Drawing.Point(0, 280);
            this.GuardButton.Name = "GuardButton";
            this.GuardButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.GuardButton.Size = new System.Drawing.Size(254, 45);
            this.GuardButton.TabIndex = 3;
            this.GuardButton.Text = "Member";
            this.GuardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardButton.UseVisualStyleBackColor = true;
            this.GuardButton.Click += new System.EventHandler(this.GuardButton_Click);
            // 
            // MemberPanel
            // 
            this.MemberPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.MemberPanel.Controls.Add(this.UpdateManagerButton);
            this.MemberPanel.Controls.Add(this.RemoveManagerButton);
            this.MemberPanel.Controls.Add(this.AddManagerButton);
            this.MemberPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemberPanel.Location = new System.Drawing.Point(0, 145);
            this.MemberPanel.Name = "MemberPanel";
            this.MemberPanel.Size = new System.Drawing.Size(254, 135);
            this.MemberPanel.TabIndex = 2;
            // 
            // UpdateManagerButton
            // 
            this.UpdateManagerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateManagerButton.FlatAppearance.BorderSize = 0;
            this.UpdateManagerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UpdateManagerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.UpdateManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateManagerButton.ForeColor = System.Drawing.Color.LightGray;
            this.UpdateManagerButton.Location = new System.Drawing.Point(0, 80);
            this.UpdateManagerButton.Name = "UpdateManagerButton";
            this.UpdateManagerButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.UpdateManagerButton.Size = new System.Drawing.Size(254, 40);
            this.UpdateManagerButton.TabIndex = 2;
            this.UpdateManagerButton.Text = "Update Guard";
            this.UpdateManagerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateManagerButton.UseVisualStyleBackColor = true;
            this.UpdateManagerButton.Click += new System.EventHandler(this.UpdateGuardButton_Click);
            // 
            // RemoveManagerButton
            // 
            this.RemoveManagerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveManagerButton.FlatAppearance.BorderSize = 0;
            this.RemoveManagerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RemoveManagerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.RemoveManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveManagerButton.ForeColor = System.Drawing.Color.LightGray;
            this.RemoveManagerButton.Location = new System.Drawing.Point(0, 40);
            this.RemoveManagerButton.Name = "RemoveManagerButton";
            this.RemoveManagerButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.RemoveManagerButton.Size = new System.Drawing.Size(254, 40);
            this.RemoveManagerButton.TabIndex = 1;
            this.RemoveManagerButton.Text = "Remove Guard";
            this.RemoveManagerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveManagerButton.UseVisualStyleBackColor = true;
            this.RemoveManagerButton.Click += new System.EventHandler(this.RemoveGuardButton_Click);
            // 
            // AddManagerButton
            // 
            this.AddManagerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddManagerButton.FlatAppearance.BorderSize = 0;
            this.AddManagerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddManagerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.AddManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddManagerButton.ForeColor = System.Drawing.Color.LightGray;
            this.AddManagerButton.Location = new System.Drawing.Point(0, 0);
            this.AddManagerButton.Name = "AddManagerButton";
            this.AddManagerButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.AddManagerButton.Size = new System.Drawing.Size(254, 40);
            this.AddManagerButton.TabIndex = 0;
            this.AddManagerButton.Text = "Add Guard";
            this.AddManagerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddManagerButton.UseVisualStyleBackColor = true;
            this.AddManagerButton.Click += new System.EventHandler(this.AddGuardButton_Click);
            // 
            // ManagerButton
            // 
            this.ManagerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagerButton.FlatAppearance.BorderSize = 0;
            this.ManagerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ManagerButton.Location = new System.Drawing.Point(0, 100);
            this.ManagerButton.Name = "ManagerButton";
            this.ManagerButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ManagerButton.Size = new System.Drawing.Size(254, 45);
            this.ManagerButton.TabIndex = 1;
            this.ManagerButton.Text = "Guard";
            this.ManagerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagerButton.UseVisualStyleBackColor = true;
            this.ManagerButton.Click += new System.EventHandler(this.MemberButton_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 100);
            this.panel1.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.BackColor = System.Drawing.Color.Crimson;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Location = new System.Drawing.Point(802, 25);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 43);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.welcomeLabel1);
            this.panel2.Controls.Add(this.logoutButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(254, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 100);
            this.panel2.TabIndex = 2;
            // 
            // welcomeLabel1
            // 
            this.welcomeLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel1.ForeColor = System.Drawing.Color.LawnGreen;
            this.welcomeLabel1.Location = new System.Drawing.Point(444, 13);
            this.welcomeLabel1.Name = "welcomeLabel1";
            this.welcomeLabel1.Size = new System.Drawing.Size(328, 60);
            this.welcomeLabel1.TabIndex = 3;
            this.welcomeLabel1.Text = "Welcome";
            this.welcomeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomeLabel1.Click += new System.EventHandler(this.WelcomeLabel1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(297, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 60);
            this.label2.TabIndex = 4;
            this.label2.Text = "Manager";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ChildFormPanel.Controls.Add(this.managerEmailLabel);
            this.ChildFormPanel.Controls.Add(this.managerPhoneLabel);
            this.ChildFormPanel.Controls.Add(this.managerPictureBox1);
            this.ChildFormPanel.Controls.Add(this.managerbloodGroupLabel);
            this.ChildFormPanel.Controls.Add(this.managerDateOfBirthLabel);
            this.ChildFormPanel.Controls.Add(this.managerGenderLabel);
            this.ChildFormPanel.Controls.Add(this.managerUserIDLabel);
            this.ChildFormPanel.Controls.Add(this.managerNameLabel);
            this.ChildFormPanel.Controls.Add(this.label7);
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(254, 100);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(889, 655);
            this.ChildFormPanel.TabIndex = 3;
            this.ChildFormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChildFormPanel_Paint);
            // 
            // managerEmailLabel
            // 
            this.managerEmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managerEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerEmailLabel.ForeColor = System.Drawing.Color.Aqua;
            this.managerEmailLabel.Location = new System.Drawing.Point(150, 555);
            this.managerEmailLabel.Name = "managerEmailLabel";
            this.managerEmailLabel.Size = new System.Drawing.Size(346, 60);
            this.managerEmailLabel.TabIndex = 46;
            this.managerEmailLabel.Text = "Email : ";
            this.managerEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // managerPhoneLabel
            // 
            this.managerPhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managerPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerPhoneLabel.ForeColor = System.Drawing.Color.Aqua;
            this.managerPhoneLabel.Location = new System.Drawing.Point(150, 495);
            this.managerPhoneLabel.Name = "managerPhoneLabel";
            this.managerPhoneLabel.Size = new System.Drawing.Size(346, 60);
            this.managerPhoneLabel.TabIndex = 47;
            this.managerPhoneLabel.Text = "Phone : ";
            this.managerPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // managerPictureBox1
            // 
            this.managerPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.managerPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.managerPictureBox1.Location = new System.Drawing.Point(598, 85);
            this.managerPictureBox1.Name = "managerPictureBox1";
            this.managerPictureBox1.Size = new System.Drawing.Size(198, 177);
            this.managerPictureBox1.TabIndex = 45;
            this.managerPictureBox1.TabStop = false;
            // 
            // managerbloodGroupLabel
            // 
            this.managerbloodGroupLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managerbloodGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerbloodGroupLabel.ForeColor = System.Drawing.Color.Aqua;
            this.managerbloodGroupLabel.Location = new System.Drawing.Point(150, 422);
            this.managerbloodGroupLabel.Name = "managerbloodGroupLabel";
            this.managerbloodGroupLabel.Size = new System.Drawing.Size(346, 60);
            this.managerbloodGroupLabel.TabIndex = 44;
            this.managerbloodGroupLabel.Text = "Blood Group : ";
            this.managerbloodGroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // managerDateOfBirthLabel
            // 
            this.managerDateOfBirthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managerDateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerDateOfBirthLabel.ForeColor = System.Drawing.Color.Aqua;
            this.managerDateOfBirthLabel.Location = new System.Drawing.Point(150, 347);
            this.managerDateOfBirthLabel.Name = "managerDateOfBirthLabel";
            this.managerDateOfBirthLabel.Size = new System.Drawing.Size(357, 60);
            this.managerDateOfBirthLabel.TabIndex = 43;
            this.managerDateOfBirthLabel.Text = "DateOfBirth : ";
            this.managerDateOfBirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // managerGenderLabel
            // 
            this.managerGenderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managerGenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerGenderLabel.ForeColor = System.Drawing.Color.Aqua;
            this.managerGenderLabel.Location = new System.Drawing.Point(150, 261);
            this.managerGenderLabel.Name = "managerGenderLabel";
            this.managerGenderLabel.Size = new System.Drawing.Size(338, 60);
            this.managerGenderLabel.TabIndex = 42;
            this.managerGenderLabel.Text = "Gender :";
            this.managerGenderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // managerUserIDLabel
            // 
            this.managerUserIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managerUserIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerUserIDLabel.ForeColor = System.Drawing.Color.Aqua;
            this.managerUserIDLabel.Location = new System.Drawing.Point(150, 182);
            this.managerUserIDLabel.Name = "managerUserIDLabel";
            this.managerUserIDLabel.Size = new System.Drawing.Size(346, 60);
            this.managerUserIDLabel.TabIndex = 41;
            this.managerUserIDLabel.Text = "User ID : ";
            this.managerUserIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // managerNameLabel
            // 
            this.managerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerNameLabel.ForeColor = System.Drawing.Color.Aqua;
            this.managerNameLabel.Location = new System.Drawing.Point(150, 106);
            this.managerNameLabel.Name = "managerNameLabel";
            this.managerNameLabel.Size = new System.Drawing.Size(313, 60);
            this.managerNameLabel.TabIndex = 40;
            this.managerNameLabel.Text = "Name : ";
            this.managerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(298, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 60);
            this.label7.TabIndex = 10;
            this.label7.Text = "Manager Information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Location = new System.Drawing.Point(0, 556);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(254, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Contact Guard";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 755);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SideMenuPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manager";
            this.Text = "Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Manager_Load);
            this.SideMenuPanel.ResumeLayout(false);
            this.GuardPanel.ResumeLayout(false);
            this.MemberPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ChildFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.managerPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Panel MemberPanel;
        private System.Windows.Forms.Button UpdateManagerButton;
        private System.Windows.Forms.Button RemoveManagerButton;
        private System.Windows.Forms.Button AddManagerButton;
        private System.Windows.Forms.Button ManagerButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ParkingDetailsButton;
        private System.Windows.Forms.Button MemberDetailsButton;
        private System.Windows.Forms.Panel GuardPanel;
        private System.Windows.Forms.Button UpdateGuardButton;
        private System.Windows.Forms.Button RemoveGuardButton;
        private System.Windows.Forms.Button AddGuardButton;
        private System.Windows.Forms.Button GuardButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label welcomeLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label managerEmailLabel;
        private System.Windows.Forms.Label managerPhoneLabel;
        private System.Windows.Forms.PictureBox managerPictureBox1;
        private System.Windows.Forms.Label managerbloodGroupLabel;
        private System.Windows.Forms.Label managerDateOfBirthLabel;
        private System.Windows.Forms.Label managerGenderLabel;
        private System.Windows.Forms.Label managerUserIDLabel;
        private System.Windows.Forms.Label managerNameLabel;
        private System.Windows.Forms.Button button1;
    }
}

