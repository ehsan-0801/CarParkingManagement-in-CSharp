namespace ParkingManagement.Design
{
    partial class chat
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
            this.SendButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.MessageListBox = new System.Windows.Forms.ListBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ManagerGroupBox = new System.Windows.Forms.GroupBox();
            this.PortMTextBox = new System.Windows.Forms.TextBox();
            this.IpMTextBox = new System.Windows.Forms.TextBox();
            this.PortMLabel = new System.Windows.Forms.Label();
            this.IpMLabel = new System.Windows.Forms.Label();
            this.GuardGroupbox = new System.Windows.Forms.GroupBox();
            this.PortGTextBox = new System.Windows.Forms.TextBox();
            this.IpGTextBox = new System.Windows.Forms.TextBox();
            this.PortGLabel = new System.Windows.Forms.Label();
            this.IpGLabel = new System.Windows.Forms.Label();
            this.ManagerGroupBox.SuspendLayout();
            this.GuardGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.ForeColor = System.Drawing.Color.Aqua;
            this.SendButton.Location = new System.Drawing.Point(845, 668);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(97, 27);
            this.SendButton.TabIndex = 11;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageTextBox.Location = new System.Drawing.Point(18, 616);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(806, 79);
            this.MessageTextBox.TabIndex = 10;
            // 
            // MessageListBox
            // 
            this.MessageListBox.BackColor = System.Drawing.Color.Black;
            this.MessageListBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageListBox.ForeColor = System.Drawing.Color.Aqua;
            this.MessageListBox.FormattingEnabled = true;
            this.MessageListBox.ItemHeight = 32;
            this.MessageListBox.Location = new System.Drawing.Point(18, 232);
            this.MessageListBox.Name = "MessageListBox";
            this.MessageListBox.Size = new System.Drawing.Size(938, 356);
            this.MessageListBox.TabIndex = 9;
            // 
            // ConnectButton
            // 
            this.ConnectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButton.ForeColor = System.Drawing.Color.Aqua;
            this.ConnectButton.Location = new System.Drawing.Point(798, 110);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(106, 48);
            this.ConnectButton.TabIndex = 8;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ManagerGroupBox
            // 
            this.ManagerGroupBox.Controls.Add(this.PortMTextBox);
            this.ManagerGroupBox.Controls.Add(this.IpMTextBox);
            this.ManagerGroupBox.Controls.Add(this.PortMLabel);
            this.ManagerGroupBox.Controls.Add(this.IpMLabel);
            this.ManagerGroupBox.ForeColor = System.Drawing.Color.Aqua;
            this.ManagerGroupBox.Location = new System.Drawing.Point(385, 42);
            this.ManagerGroupBox.Name = "ManagerGroupBox";
            this.ManagerGroupBox.Size = new System.Drawing.Size(339, 153);
            this.ManagerGroupBox.TabIndex = 7;
            this.ManagerGroupBox.TabStop = false;
            this.ManagerGroupBox.Text = "Other";
            // 
            // PortMTextBox
            // 
            this.PortMTextBox.Location = new System.Drawing.Point(108, 85);
            this.PortMTextBox.Name = "PortMTextBox";
            this.PortMTextBox.Size = new System.Drawing.Size(212, 22);
            this.PortMTextBox.TabIndex = 5;
            // 
            // IpMTextBox
            // 
            this.IpMTextBox.Location = new System.Drawing.Point(108, 29);
            this.IpMTextBox.Name = "IpMTextBox";
            this.IpMTextBox.Size = new System.Drawing.Size(212, 22);
            this.IpMTextBox.TabIndex = 4;
            // 
            // PortMLabel
            // 
            this.PortMLabel.AutoSize = true;
            this.PortMLabel.Location = new System.Drawing.Point(60, 85);
            this.PortMLabel.Name = "PortMLabel";
            this.PortMLabel.Size = new System.Drawing.Size(42, 17);
            this.PortMLabel.TabIndex = 3;
            this.PortMLabel.Text = "Port :";
            // 
            // IpMLabel
            // 
            this.IpMLabel.AutoSize = true;
            this.IpMLabel.Location = new System.Drawing.Point(18, 29);
            this.IpMLabel.Name = "IpMLabel";
            this.IpMLabel.Size = new System.Drawing.Size(84, 17);
            this.IpMLabel.TabIndex = 2;
            this.IpMLabel.Text = "IP Address :";
            // 
            // GuardGroupbox
            // 
            this.GuardGroupbox.Controls.Add(this.PortGTextBox);
            this.GuardGroupbox.Controls.Add(this.IpGTextBox);
            this.GuardGroupbox.Controls.Add(this.PortGLabel);
            this.GuardGroupbox.Controls.Add(this.IpGLabel);
            this.GuardGroupbox.ForeColor = System.Drawing.Color.Aqua;
            this.GuardGroupbox.Location = new System.Drawing.Point(30, 42);
            this.GuardGroupbox.Name = "GuardGroupbox";
            this.GuardGroupbox.Size = new System.Drawing.Size(339, 153);
            this.GuardGroupbox.TabIndex = 6;
            this.GuardGroupbox.TabStop = false;
            this.GuardGroupbox.Text = "You";
            // 
            // PortGTextBox
            // 
            this.PortGTextBox.Location = new System.Drawing.Point(96, 94);
            this.PortGTextBox.Name = "PortGTextBox";
            this.PortGTextBox.Size = new System.Drawing.Size(212, 22);
            this.PortGTextBox.TabIndex = 7;
            // 
            // IpGTextBox
            // 
            this.IpGTextBox.Location = new System.Drawing.Point(96, 29);
            this.IpGTextBox.Name = "IpGTextBox";
            this.IpGTextBox.Size = new System.Drawing.Size(212, 22);
            this.IpGTextBox.TabIndex = 6;
            // 
            // PortGLabel
            // 
            this.PortGLabel.AutoSize = true;
            this.PortGLabel.Location = new System.Drawing.Point(48, 94);
            this.PortGLabel.Name = "PortGLabel";
            this.PortGLabel.Size = new System.Drawing.Size(42, 17);
            this.PortGLabel.TabIndex = 1;
            this.PortGLabel.Text = "Port :";
            // 
            // IpGLabel
            // 
            this.IpGLabel.AutoSize = true;
            this.IpGLabel.Location = new System.Drawing.Point(6, 29);
            this.IpGLabel.Name = "IpGLabel";
            this.IpGLabel.Size = new System.Drawing.Size(84, 17);
            this.IpGLabel.TabIndex = 0;
            this.IpGLabel.Text = "IP Address :";
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(981, 720);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.MessageListBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ManagerGroupBox);
            this.Controls.Add(this.GuardGroupbox);
            this.Name = "chat";
            this.Text = "Messenger";
            this.Load += new System.EventHandler(this.chat_Load);
            this.ManagerGroupBox.ResumeLayout(false);
            this.ManagerGroupBox.PerformLayout();
            this.GuardGroupbox.ResumeLayout(false);
            this.GuardGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.ListBox MessageListBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.GroupBox ManagerGroupBox;
        private System.Windows.Forms.TextBox PortMTextBox;
        private System.Windows.Forms.TextBox IpMTextBox;
        private System.Windows.Forms.Label PortMLabel;
        private System.Windows.Forms.Label IpMLabel;
        private System.Windows.Forms.GroupBox GuardGroupbox;
        private System.Windows.Forms.TextBox PortGTextBox;
        private System.Windows.Forms.TextBox IpGTextBox;
        private System.Windows.Forms.Label PortGLabel;
        private System.Windows.Forms.Label IpGLabel;
    }
}