namespace ParkingManagement.Design
{
    partial class Print
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
            this.ReceiptLabel = new System.Windows.Forms.Label();
            this.VehicleNoLabel = new System.Windows.Forms.Label();
            this.ExitTimeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.VehicleTypeLabel = new System.Windows.Forms.Label();
            this.EntryTimeLabel = new System.Windows.Forms.Label();
            this.MemberIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReceiptLabel
            // 
            this.ReceiptLabel.AutoSize = true;
            this.ReceiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReceiptLabel.Location = new System.Drawing.Point(349, 98);
            this.ReceiptLabel.Name = "ReceiptLabel";
            this.ReceiptLabel.Size = new System.Drawing.Size(112, 32);
            this.ReceiptLabel.TabIndex = 0;
            this.ReceiptLabel.Text = "Receipt";
            // 
            // VehicleNoLabel
            // 
            this.VehicleNoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VehicleNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleNoLabel.ForeColor = System.Drawing.Color.Aqua;
            this.VehicleNoLabel.Location = new System.Drawing.Point(127, 403);
            this.VehicleNoLabel.Name = "VehicleNoLabel";
            this.VehicleNoLabel.Size = new System.Drawing.Size(390, 60);
            this.VehicleNoLabel.TabIndex = 30;
            this.VehicleNoLabel.Text = "Vehicle No :";
            this.VehicleNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExitTimeLabel
            // 
            this.ExitTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ExitTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitTimeLabel.ForeColor = System.Drawing.Color.Aqua;
            this.ExitTimeLabel.Location = new System.Drawing.Point(127, 337);
            this.ExitTimeLabel.Name = "ExitTimeLabel";
            this.ExitTimeLabel.Size = new System.Drawing.Size(590, 60);
            this.ExitTimeLabel.TabIndex = 29;
            this.ExitTimeLabel.Text = "Exit Time :";
            this.ExitTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.Aqua;
            this.PriceLabel.Location = new System.Drawing.Point(127, 519);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(590, 117);
            this.PriceLabel.TabIndex = 27;
            this.PriceLabel.Text = "Price :";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PriceLabel.Click += new System.EventHandler(this.PriceLabel_Click);
            // 
            // VehicleTypeLabel
            // 
            this.VehicleTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VehicleTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleTypeLabel.ForeColor = System.Drawing.Color.Aqua;
            this.VehicleTypeLabel.Location = new System.Drawing.Point(127, 468);
            this.VehicleTypeLabel.Name = "VehicleTypeLabel";
            this.VehicleTypeLabel.Size = new System.Drawing.Size(390, 60);
            this.VehicleTypeLabel.TabIndex = 26;
            this.VehicleTypeLabel.Text = "Vehicle Type :";
            this.VehicleTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EntryTimeLabel
            // 
            this.EntryTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EntryTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryTimeLabel.ForeColor = System.Drawing.Color.Aqua;
            this.EntryTimeLabel.Location = new System.Drawing.Point(127, 257);
            this.EntryTimeLabel.Name = "EntryTimeLabel";
            this.EntryTimeLabel.Size = new System.Drawing.Size(390, 60);
            this.EntryTimeLabel.TabIndex = 25;
            this.EntryTimeLabel.Text = "Entry Time :";
            this.EntryTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemberIDLabel
            // 
            this.MemberIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MemberIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDLabel.ForeColor = System.Drawing.Color.Aqua;
            this.MemberIDLabel.Location = new System.Drawing.Point(127, 182);
            this.MemberIDLabel.Name = "MemberIDLabel";
            this.MemberIDLabel.Size = new System.Drawing.Size(390, 60);
            this.MemberIDLabel.TabIndex = 24;
            this.MemberIDLabel.Text = "Member ID :";
            this.MemberIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(829, 821);
            this.Controls.Add(this.VehicleNoLabel);
            this.Controls.Add(this.ExitTimeLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.VehicleTypeLabel);
            this.Controls.Add(this.EntryTimeLabel);
            this.Controls.Add(this.MemberIDLabel);
            this.Controls.Add(this.ReceiptLabel);
            this.Name = "Print";
            this.Text = "Member ID : ";
            this.Load += new System.EventHandler(this.Print_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReceiptLabel;
        private System.Windows.Forms.Label VehicleNoLabel;
        private System.Windows.Forms.Label ExitTimeLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label VehicleTypeLabel;
        private System.Windows.Forms.Label EntryTimeLabel;
        private System.Windows.Forms.Label MemberIDLabel;
    }
}