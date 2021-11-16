namespace GuardManagement
{
    partial class GuardTaskEn
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
            this.GuardTaskPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.OthersRadioButton = new System.Windows.Forms.RadioButton();
            this.BikeRadioButton = new System.Windows.Forms.RadioButton();
            this.CarRadioButton = new System.Windows.Forms.RadioButton();
            this.VehicleNumbertextBox = new System.Windows.Forms.TextBox();
            this.MemberIDtextBox = new System.Windows.Forms.TextBox();
            this.MemberNametextBox = new System.Windows.Forms.TextBox();
            this.AllocatedSpacelabel = new System.Windows.Forms.Label();
            this.VehicleTypeLabel = new System.Windows.Forms.Label();
            this.VehicleNumberLabel = new System.Windows.Forms.Label();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.NormalVehicleEnLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.AllocatedSpaceNoTextbox = new System.Windows.Forms.TextBox();
            this.EntryTimeLabel = new System.Windows.Forms.Label();
            this.EntryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GuardTaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuardTaskPanel
            // 
            this.GuardTaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GuardTaskPanel.Controls.Add(this.EntryDateTimePicker);
            this.GuardTaskPanel.Controls.Add(this.EntryTimeLabel);
            this.GuardTaskPanel.Controls.Add(this.AllocatedSpaceNoTextbox);
            this.GuardTaskPanel.Controls.Add(this.SubmitButton);
            this.GuardTaskPanel.Controls.Add(this.BackButton);
            this.GuardTaskPanel.Controls.Add(this.OthersRadioButton);
            this.GuardTaskPanel.Controls.Add(this.BikeRadioButton);
            this.GuardTaskPanel.Controls.Add(this.CarRadioButton);
            this.GuardTaskPanel.Controls.Add(this.VehicleNumbertextBox);
            this.GuardTaskPanel.Controls.Add(this.MemberIDtextBox);
            this.GuardTaskPanel.Controls.Add(this.MemberNametextBox);
            this.GuardTaskPanel.Controls.Add(this.AllocatedSpacelabel);
            this.GuardTaskPanel.Controls.Add(this.VehicleTypeLabel);
            this.GuardTaskPanel.Controls.Add(this.VehicleNumberLabel);
            this.GuardTaskPanel.Controls.Add(this.UserIdLabel);
            this.GuardTaskPanel.Controls.Add(this.UserNameLabel);
            this.GuardTaskPanel.Location = new System.Drawing.Point(24, 86);
            this.GuardTaskPanel.Name = "GuardTaskPanel";
            this.GuardTaskPanel.Size = new System.Drawing.Size(826, 359);
            this.GuardTaskPanel.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Crimson;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackButton.Location = new System.Drawing.Point(669, 271);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(126, 42);
            this.BackButton.TabIndex = 26;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OthersRadioButton
            // 
            this.OthersRadioButton.AutoSize = true;
            this.OthersRadioButton.Location = new System.Drawing.Point(511, 161);
            this.OthersRadioButton.Name = "OthersRadioButton";
            this.OthersRadioButton.Size = new System.Drawing.Size(72, 21);
            this.OthersRadioButton.TabIndex = 24;
            this.OthersRadioButton.TabStop = true;
            this.OthersRadioButton.Text = "Others";
            this.OthersRadioButton.UseVisualStyleBackColor = true;
            // 
            // BikeRadioButton
            // 
            this.BikeRadioButton.AutoSize = true;
            this.BikeRadioButton.Location = new System.Drawing.Point(375, 161);
            this.BikeRadioButton.Name = "BikeRadioButton";
            this.BikeRadioButton.Size = new System.Drawing.Size(56, 21);
            this.BikeRadioButton.TabIndex = 23;
            this.BikeRadioButton.TabStop = true;
            this.BikeRadioButton.Text = "Bike";
            this.BikeRadioButton.UseVisualStyleBackColor = true;
            // 
            // CarRadioButton
            // 
            this.CarRadioButton.AutoSize = true;
            this.CarRadioButton.Location = new System.Drawing.Point(225, 161);
            this.CarRadioButton.Name = "CarRadioButton";
            this.CarRadioButton.Size = new System.Drawing.Size(51, 21);
            this.CarRadioButton.TabIndex = 22;
            this.CarRadioButton.TabStop = true;
            this.CarRadioButton.Text = "Car";
            this.CarRadioButton.UseVisualStyleBackColor = true;
            // 
            // VehicleNumbertextBox
            // 
            this.VehicleNumbertextBox.Location = new System.Drawing.Point(197, 124);
            this.VehicleNumbertextBox.Name = "VehicleNumbertextBox";
            this.VehicleNumbertextBox.Size = new System.Drawing.Size(396, 22);
            this.VehicleNumbertextBox.TabIndex = 21;
            // 
            // MemberIDtextBox
            // 
            this.MemberIDtextBox.Location = new System.Drawing.Point(197, 58);
            this.MemberIDtextBox.Name = "MemberIDtextBox";
            this.MemberIDtextBox.Size = new System.Drawing.Size(396, 22);
            this.MemberIDtextBox.TabIndex = 20;
            // 
            // MemberNametextBox
            // 
            this.MemberNametextBox.Location = new System.Drawing.Point(197, 27);
            this.MemberNametextBox.Name = "MemberNametextBox";
            this.MemberNametextBox.Size = new System.Drawing.Size(396, 22);
            this.MemberNametextBox.TabIndex = 19;
            // 
            // AllocatedSpacelabel
            // 
            this.AllocatedSpacelabel.AutoSize = true;
            this.AllocatedSpacelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.AllocatedSpacelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllocatedSpacelabel.ForeColor = System.Drawing.Color.White;
            this.AllocatedSpacelabel.Location = new System.Drawing.Point(39, 192);
            this.AllocatedSpacelabel.Name = "AllocatedSpacelabel";
            this.AllocatedSpacelabel.Size = new System.Drawing.Size(140, 20);
            this.AllocatedSpacelabel.TabIndex = 18;
            this.AllocatedSpacelabel.Text = "Allocated Space :";
            // 
            // VehicleTypeLabel
            // 
            this.VehicleTypeLabel.AutoSize = true;
            this.VehicleTypeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.VehicleTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleTypeLabel.ForeColor = System.Drawing.Color.White;
            this.VehicleTypeLabel.Location = new System.Drawing.Point(69, 160);
            this.VehicleTypeLabel.Name = "VehicleTypeLabel";
            this.VehicleTypeLabel.Size = new System.Drawing.Size(110, 20);
            this.VehicleTypeLabel.TabIndex = 17;
            this.VehicleTypeLabel.Text = "Vehicle type :";
            // 
            // VehicleNumberLabel
            // 
            this.VehicleNumberLabel.AutoSize = true;
            this.VehicleNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.VehicleNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleNumberLabel.ForeColor = System.Drawing.Color.White;
            this.VehicleNumberLabel.Location = new System.Drawing.Point(36, 124);
            this.VehicleNumberLabel.Name = "VehicleNumberLabel";
            this.VehicleNumberLabel.Size = new System.Drawing.Size(143, 20);
            this.VehicleNumberLabel.TabIndex = 16;
            this.VehicleNumberLabel.Text = "Vehicle Number  :";
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.UserIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdLabel.ForeColor = System.Drawing.Color.White;
            this.UserIdLabel.Location = new System.Drawing.Point(62, 58);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(117, 20);
            this.UserIdLabel.TabIndex = 15;
            this.UserIdLabel.Text = "Member ID    :";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.White;
            this.UserNameLabel.Location = new System.Drawing.Point(50, 27);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(129, 20);
            this.UserNameLabel.TabIndex = 14;
            this.UserNameLabel.Text = "Member Name :";
            // 
            // NormalVehicleEnLabel
            // 
            this.NormalVehicleEnLabel.AutoSize = true;
            this.NormalVehicleEnLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NormalVehicleEnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalVehicleEnLabel.ForeColor = System.Drawing.Color.Orange;
            this.NormalVehicleEnLabel.Location = new System.Drawing.Point(180, 23);
            this.NormalVehicleEnLabel.Name = "NormalVehicleEnLabel";
            this.NormalVehicleEnLabel.Size = new System.Drawing.Size(392, 44);
            this.NormalVehicleEnLabel.TabIndex = 4;
            this.NormalVehicleEnLabel.Text = "Normal vehicle Entry";
            // 
            // SubmitButton
            // 
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubmitButton.Location = new System.Drawing.Point(288, 271);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(147, 38);
            this.SubmitButton.TabIndex = 27;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // AllocatedSpaceNoTextbox
            // 
            this.AllocatedSpaceNoTextbox.Location = new System.Drawing.Point(197, 192);
            this.AllocatedSpaceNoTextbox.Name = "AllocatedSpaceNoTextbox";
            this.AllocatedSpaceNoTextbox.Size = new System.Drawing.Size(50, 22);
            this.AllocatedSpaceNoTextbox.TabIndex = 28;
            // 
            // EntryTimeLabel
            // 
            this.EntryTimeLabel.AutoSize = true;
            this.EntryTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.EntryTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryTimeLabel.ForeColor = System.Drawing.Color.White;
            this.EntryTimeLabel.Location = new System.Drawing.Point(69, 89);
            this.EntryTimeLabel.Name = "EntryTimeLabel";
            this.EntryTimeLabel.Size = new System.Drawing.Size(110, 20);
            this.EntryTimeLabel.TabIndex = 29;
            this.EntryTimeLabel.Text = "Entry Time   :";
            // 
            // EntryDateTimePicker
            // 
            this.EntryDateTimePicker.Location = new System.Drawing.Point(197, 89);
            this.EntryDateTimePicker.Name = "EntryDateTimePicker";
            this.EntryDateTimePicker.Size = new System.Drawing.Size(234, 22);
            this.EntryDateTimePicker.TabIndex = 35;
            // 
            // GuardTaskEn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(871, 487);
            this.Controls.Add(this.NormalVehicleEnLabel);
            this.Controls.Add(this.GuardTaskPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "GuardTaskEn";
            this.Text = "Vehicle Entry For member";
            this.Load += new System.EventHandler(this.GuardTaskEn_Load);
            this.GuardTaskPanel.ResumeLayout(false);
            this.GuardTaskPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GuardTaskPanel;
        private System.Windows.Forms.RadioButton OthersRadioButton;
        private System.Windows.Forms.RadioButton BikeRadioButton;
        private System.Windows.Forms.RadioButton CarRadioButton;
        private System.Windows.Forms.TextBox VehicleNumbertextBox;
        private System.Windows.Forms.TextBox MemberIDtextBox;
        private System.Windows.Forms.TextBox MemberNametextBox;
        private System.Windows.Forms.Label AllocatedSpacelabel;
        private System.Windows.Forms.Label VehicleTypeLabel;
        private System.Windows.Forms.Label VehicleNumberLabel;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label NormalVehicleEnLabel;
        private System.Windows.Forms.TextBox AllocatedSpaceNoTextbox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label EntryTimeLabel;
        private System.Windows.Forms.DateTimePicker EntryDateTimePicker;
    }
}