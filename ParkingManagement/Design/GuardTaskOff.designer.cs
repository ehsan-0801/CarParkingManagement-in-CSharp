namespace GuardManagement
{
    partial class GuardTaskOff
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
            this.BackOffButton = new System.Windows.Forms.Button();
            this.OfficialVehicleEnLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.EntryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.VehicleNoLabel = new System.Windows.Forms.Label();
            this.VehicleNoTextBox = new System.Windows.Forms.TextBox();
            this.AllocatedSpaceNoTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GuardTaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuardTaskPanel
            // 
            this.GuardTaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GuardTaskPanel.Controls.Add(this.AllocatedSpaceNoTextbox);
            this.GuardTaskPanel.Controls.Add(this.label2);
            this.GuardTaskPanel.Controls.Add(this.EntryDateTimePicker);
            this.GuardTaskPanel.Controls.Add(this.label1);
            this.GuardTaskPanel.Controls.Add(this.SubmitButton);
            this.GuardTaskPanel.Controls.Add(this.BackOffButton);
            this.GuardTaskPanel.Controls.Add(this.VehicleNoTextBox);
            this.GuardTaskPanel.Controls.Add(this.VehicleNoLabel);
            this.GuardTaskPanel.Location = new System.Drawing.Point(12, 96);
            this.GuardTaskPanel.Name = "GuardTaskPanel";
            this.GuardTaskPanel.Size = new System.Drawing.Size(826, 359);
            this.GuardTaskPanel.TabIndex = 1;
            // 
            // BackOffButton
            // 
            this.BackOffButton.BackColor = System.Drawing.Color.Crimson;
            this.BackOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackOffButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackOffButton.Location = new System.Drawing.Point(686, 291);
            this.BackOffButton.Name = "BackOffButton";
            this.BackOffButton.Size = new System.Drawing.Size(113, 42);
            this.BackOffButton.TabIndex = 26;
            this.BackOffButton.Text = "Back";
            this.BackOffButton.UseVisualStyleBackColor = false;
            this.BackOffButton.Click += new System.EventHandler(this.BackOffButton_Click);
            // 
            // OfficialVehicleEnLabel
            // 
            this.OfficialVehicleEnLabel.AutoSize = true;
            this.OfficialVehicleEnLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OfficialVehicleEnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfficialVehicleEnLabel.ForeColor = System.Drawing.Color.Orange;
            this.OfficialVehicleEnLabel.Location = new System.Drawing.Point(163, 35);
            this.OfficialVehicleEnLabel.Name = "OfficialVehicleEnLabel";
            this.OfficialVehicleEnLabel.Size = new System.Drawing.Size(395, 44);
            this.OfficialVehicleEnLabel.TabIndex = 27;
            this.OfficialVehicleEnLabel.Text = "Official Vehicle Entry";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Crimson;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubmitButton.Location = new System.Drawing.Point(310, 176);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(113, 42);
            this.SubmitButton.TabIndex = 27;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // EntryDateTimePicker
            // 
            this.EntryDateTimePicker.Location = new System.Drawing.Point(254, 73);
            this.EntryDateTimePicker.Name = "EntryDateTimePicker";
            this.EntryDateTimePicker.Size = new System.Drawing.Size(255, 22);
            this.EntryDateTimePicker.TabIndex = 37;
            this.EntryDateTimePicker.ValueChanged += new System.EventHandler(this.EntryDateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Entry Time :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VehicleNoLabel
            // 
            this.VehicleNoLabel.AutoSize = true;
            this.VehicleNoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.VehicleNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleNoLabel.ForeColor = System.Drawing.Color.White;
            this.VehicleNoLabel.Location = new System.Drawing.Point(113, 33);
            this.VehicleNoLabel.Name = "VehicleNoLabel";
            this.VehicleNoLabel.Size = new System.Drawing.Size(100, 20);
            this.VehicleNoLabel.TabIndex = 14;
            this.VehicleNoLabel.Text = "Vehicle No :";
            this.VehicleNoLabel.Click += new System.EventHandler(this.VehicleNoLabel_Click);
            // 
            // VehicleNoTextBox
            // 
            this.VehicleNoTextBox.Location = new System.Drawing.Point(254, 33);
            this.VehicleNoTextBox.Name = "VehicleNoTextBox";
            this.VehicleNoTextBox.Size = new System.Drawing.Size(255, 22);
            this.VehicleNoTextBox.TabIndex = 19;
            this.VehicleNoTextBox.TextChanged += new System.EventHandler(this.VehicleNoTextBox_TextChanged);
            // 
            // AllocatedSpaceNoTextbox
            // 
            this.AllocatedSpaceNoTextbox.Location = new System.Drawing.Point(254, 116);
            this.AllocatedSpaceNoTextbox.Name = "AllocatedSpaceNoTextbox";
            this.AllocatedSpaceNoTextbox.Size = new System.Drawing.Size(255, 22);
            this.AllocatedSpaceNoTextbox.TabIndex = 39;
            this.AllocatedSpaceNoTextbox.TextChanged += new System.EventHandler(this.AllocatedSpaceNoTextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Allocated Space No :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // GuardTaskOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(871, 487);
            this.Controls.Add(this.OfficialVehicleEnLabel);
            this.Controls.Add(this.GuardTaskPanel);
            this.Name = "GuardTaskOff";
            this.Text = "Official Vehicle";
            this.GuardTaskPanel.ResumeLayout(false);
            this.GuardTaskPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GuardTaskPanel;
        private System.Windows.Forms.Button BackOffButton;
        private System.Windows.Forms.Label OfficialVehicleEnLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.DateTimePicker EntryDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VehicleNoTextBox;
        private System.Windows.Forms.Label VehicleNoLabel;
        private System.Windows.Forms.TextBox AllocatedSpaceNoTextbox;
        private System.Windows.Forms.Label label2;
    }
}