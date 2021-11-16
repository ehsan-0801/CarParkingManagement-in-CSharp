namespace GuardManagement
{
    partial class GuardExitOfficial
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
            this.ExitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.BackOffButton = new System.Windows.Forms.Button();
            this.VehicleNoTextBox = new System.Windows.Forms.TextBox();
            this.VehicleNoLabel = new System.Windows.Forms.Label();
            this.OfficialVehicleEnLabel = new System.Windows.Forms.Label();
            this.GuardTaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuardTaskPanel
            // 
            this.GuardTaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GuardTaskPanel.Controls.Add(this.ExitDateTimePicker);
            this.GuardTaskPanel.Controls.Add(this.label1);
            this.GuardTaskPanel.Controls.Add(this.SubmitButton);
            this.GuardTaskPanel.Controls.Add(this.BackOffButton);
            this.GuardTaskPanel.Controls.Add(this.VehicleNoTextBox);
            this.GuardTaskPanel.Controls.Add(this.VehicleNoLabel);
            this.GuardTaskPanel.Location = new System.Drawing.Point(12, 116);
            this.GuardTaskPanel.Name = "GuardTaskPanel";
            this.GuardTaskPanel.Size = new System.Drawing.Size(826, 359);
            this.GuardTaskPanel.TabIndex = 2;
            // 
            // ExitDateTimePicker
            // 
            this.ExitDateTimePicker.Location = new System.Drawing.Point(340, 78);
            this.ExitDateTimePicker.Name = "ExitDateTimePicker";
            this.ExitDateTimePicker.Size = new System.Drawing.Size(255, 22);
            this.ExitDateTimePicker.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Exit Time :";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Crimson;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubmitButton.Location = new System.Drawing.Point(379, 147);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(113, 42);
            this.SubmitButton.TabIndex = 43;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // BackOffButton
            // 
            this.BackOffButton.BackColor = System.Drawing.Color.Crimson;
            this.BackOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackOffButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackOffButton.Location = new System.Drawing.Point(676, 287);
            this.BackOffButton.Name = "BackOffButton";
            this.BackOffButton.Size = new System.Drawing.Size(113, 42);
            this.BackOffButton.TabIndex = 42;
            this.BackOffButton.Text = "Back";
            this.BackOffButton.UseVisualStyleBackColor = false;
            // 
            // VehicleNoTextBox
            // 
            this.VehicleNoTextBox.Location = new System.Drawing.Point(340, 38);
            this.VehicleNoTextBox.Name = "VehicleNoTextBox";
            this.VehicleNoTextBox.Size = new System.Drawing.Size(255, 22);
            this.VehicleNoTextBox.TabIndex = 41;
            // 
            // VehicleNoLabel
            // 
            this.VehicleNoLabel.AutoSize = true;
            this.VehicleNoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.VehicleNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleNoLabel.ForeColor = System.Drawing.Color.White;
            this.VehicleNoLabel.Location = new System.Drawing.Point(199, 38);
            this.VehicleNoLabel.Name = "VehicleNoLabel";
            this.VehicleNoLabel.Size = new System.Drawing.Size(84, 17);
            this.VehicleNoLabel.TabIndex = 40;
            this.VehicleNoLabel.Text = "Vehicle No :";
            // 
            // OfficialVehicleEnLabel
            // 
            this.OfficialVehicleEnLabel.AutoSize = true;
            this.OfficialVehicleEnLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OfficialVehicleEnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfficialVehicleEnLabel.ForeColor = System.Drawing.Color.Orange;
            this.OfficialVehicleEnLabel.Location = new System.Drawing.Point(135, 46);
            this.OfficialVehicleEnLabel.Name = "OfficialVehicleEnLabel";
            this.OfficialVehicleEnLabel.Size = new System.Drawing.Size(291, 36);
            this.OfficialVehicleEnLabel.TabIndex = 28;
            this.OfficialVehicleEnLabel.Text = "Official Vehicle Exit";
            // 
            // GuardExitOfficial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(871, 487);
            this.Controls.Add(this.OfficialVehicleEnLabel);
            this.Controls.Add(this.GuardTaskPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "GuardExitOfficial";
            this.Text = "GuardExitOfficial";
            this.Load += new System.EventHandler(this.GuardExitOfficial_Load);
            this.GuardTaskPanel.ResumeLayout(false);
            this.GuardTaskPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GuardTaskPanel;
        private System.Windows.Forms.Label OfficialVehicleEnLabel;
        private System.Windows.Forms.DateTimePicker ExitDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button BackOffButton;
        private System.Windows.Forms.TextBox VehicleNoTextBox;
        private System.Windows.Forms.Label VehicleNoLabel;
    }
}