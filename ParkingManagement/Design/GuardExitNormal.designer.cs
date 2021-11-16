namespace GuardManagement
{
    partial class GuardExitNormal
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
            this.PriceComboBox = new System.Windows.Forms.ComboBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ExitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.BackExNormButton = new System.Windows.Forms.Button();
            this.MemberIdTextbox = new System.Windows.Forms.TextBox();
            this.MemberIdLabel = new System.Windows.Forms.Label();
            this.NormalVehicleExLabel = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.GuardTaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuardTaskPanel
            // 
            this.GuardTaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GuardTaskPanel.Controls.Add(this.PrintButton);
            this.GuardTaskPanel.Controls.Add(this.PriceComboBox);
            this.GuardTaskPanel.Controls.Add(this.PriceLabel);
            this.GuardTaskPanel.Controls.Add(this.ExitDateTimePicker);
            this.GuardTaskPanel.Controls.Add(this.label1);
            this.GuardTaskPanel.Controls.Add(this.SubmitButton);
            this.GuardTaskPanel.Controls.Add(this.BackExNormButton);
            this.GuardTaskPanel.Controls.Add(this.MemberIdTextbox);
            this.GuardTaskPanel.Controls.Add(this.MemberIdLabel);
            this.GuardTaskPanel.Location = new System.Drawing.Point(12, 102);
            this.GuardTaskPanel.Name = "GuardTaskPanel";
            this.GuardTaskPanel.Size = new System.Drawing.Size(826, 359);
            this.GuardTaskPanel.TabIndex = 1;
            // 
            // PriceComboBox
            // 
            this.PriceComboBox.FormattingEnabled = true;
            this.PriceComboBox.Items.AddRange(new object[] {
            "1 Hour - 50 TK",
            "2 Hour - 100 TK",
            "3 Hour - 150 TK",
            "4 Hour - 200 TK",
            "5 Hour - 250 TK",
            "6 Hour - 300 TK",
            "7 Hour - 350 TK",
            "8 Hour - 400 TK"});
            this.PriceComboBox.Location = new System.Drawing.Point(293, 157);
            this.PriceComboBox.Name = "PriceComboBox";
            this.PriceComboBox.Size = new System.Drawing.Size(262, 24);
            this.PriceComboBox.TabIndex = 31;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.White;
            this.PriceLabel.Location = new System.Drawing.Point(210, 157);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(63, 20);
            this.PriceLabel.TabIndex = 30;
            this.PriceLabel.Text = "Price  :";
            // 
            // ExitDateTimePicker
            // 
            this.ExitDateTimePicker.Location = new System.Drawing.Point(293, 112);
            this.ExitDateTimePicker.Name = "ExitDateTimePicker";
            this.ExitDateTimePicker.Size = new System.Drawing.Size(262, 22);
            this.ExitDateTimePicker.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(174, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Exit Time   :";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Crimson;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubmitButton.Location = new System.Drawing.Point(340, 215);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(113, 42);
            this.SubmitButton.TabIndex = 27;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // BackExNormButton
            // 
            this.BackExNormButton.BackColor = System.Drawing.Color.Crimson;
            this.BackExNormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackExNormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackExNormButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackExNormButton.Location = new System.Drawing.Point(673, 293);
            this.BackExNormButton.Name = "BackExNormButton";
            this.BackExNormButton.Size = new System.Drawing.Size(113, 42);
            this.BackExNormButton.TabIndex = 26;
            this.BackExNormButton.Text = "Back";
            this.BackExNormButton.UseVisualStyleBackColor = false;
            this.BackExNormButton.Click += new System.EventHandler(this.BackExNormButton_Click);
            // 
            // MemberIdTextbox
            // 
            this.MemberIdTextbox.Location = new System.Drawing.Point(293, 73);
            this.MemberIdTextbox.Name = "MemberIdTextbox";
            this.MemberIdTextbox.Size = new System.Drawing.Size(262, 22);
            this.MemberIdTextbox.TabIndex = 20;
            // 
            // MemberIdLabel
            // 
            this.MemberIdLabel.AutoSize = true;
            this.MemberIdLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.MemberIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIdLabel.ForeColor = System.Drawing.Color.White;
            this.MemberIdLabel.Location = new System.Drawing.Point(156, 73);
            this.MemberIdLabel.Name = "MemberIdLabel";
            this.MemberIdLabel.Size = new System.Drawing.Size(117, 20);
            this.MemberIdLabel.TabIndex = 15;
            this.MemberIdLabel.Text = "Member ID    :";
            // 
            // NormalVehicleExLabel
            // 
            this.NormalVehicleExLabel.AutoSize = true;
            this.NormalVehicleExLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NormalVehicleExLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalVehicleExLabel.ForeColor = System.Drawing.Color.Orange;
            this.NormalVehicleExLabel.Location = new System.Drawing.Point(137, 25);
            this.NormalVehicleExLabel.Name = "NormalVehicleExLabel";
            this.NormalVehicleExLabel.Size = new System.Drawing.Size(366, 44);
            this.NormalVehicleExLabel.TabIndex = 5;
            this.NormalVehicleExLabel.Text = "Normal vehicle Exit";
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.Crimson;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PrintButton.Location = new System.Drawing.Point(459, 215);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(113, 42);
            this.PrintButton.TabIndex = 32;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // GuardExitNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(871, 487);
            this.Controls.Add(this.NormalVehicleExLabel);
            this.Controls.Add(this.GuardTaskPanel);
            this.Name = "GuardExitNormal";
            this.Text = "GuardExitNormal";
            this.GuardTaskPanel.ResumeLayout(false);
            this.GuardTaskPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GuardTaskPanel;
        private System.Windows.Forms.Button BackExNormButton;
        private System.Windows.Forms.TextBox MemberIdTextbox;
        private System.Windows.Forms.Label MemberIdLabel;
        private System.Windows.Forms.Label NormalVehicleExLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.DateTimePicker ExitDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PriceComboBox;
        private System.Windows.Forms.Button PrintButton;
    }
}