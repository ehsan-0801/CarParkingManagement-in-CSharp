namespace ParkingManagement.Design
{
    partial class MemberDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.membersDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.guardDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseButton1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(2, 2);
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.membersDataGridView);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.guardDataGridView);
            this.panel1.Location = new System.Drawing.Point(26, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 460);
            this.panel1.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(245, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 46);
            this.label4.TabIndex = 66;
            this.label4.Text = "Members";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // membersDataGridView
            // 
            this.membersDataGridView.AllowUserToAddRows = false;
            this.membersDataGridView.AllowUserToDeleteRows = false;
            this.membersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.membersDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.membersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersDataGridView.Location = new System.Drawing.Point(0, 270);
            this.membersDataGridView.Name = "membersDataGridView";
            this.membersDataGridView.ReadOnly = true;
            this.membersDataGridView.RowHeadersWidth = 51;
            this.membersDataGridView.RowTemplate.Height = 24;
            this.membersDataGridView.Size = new System.Drawing.Size(749, 161);
            this.membersDataGridView.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(245, -6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 46);
            this.label3.TabIndex = 64;
            this.label3.Text = "Guards";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guardDataGridView
            // 
            this.guardDataGridView.AllowUserToAddRows = false;
            this.guardDataGridView.AllowUserToDeleteRows = false;
            this.guardDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guardDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.guardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guardDataGridView.Location = new System.Drawing.Point(3, 49);
            this.guardDataGridView.Name = "guardDataGridView";
            this.guardDataGridView.ReadOnly = true;
            this.guardDataGridView.RowHeadersWidth = 51;
            this.guardDataGridView.RowTemplate.Height = 24;
            this.guardDataGridView.Size = new System.Drawing.Size(743, 169);
            this.guardDataGridView.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(271, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 60);
            this.label2.TabIndex = 49;
            this.label2.Text = "Members ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton1
            // 
            this.CloseButton1.BackColor = System.Drawing.Color.Firebrick;
            this.CloseButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseButton1.Location = new System.Drawing.Point(26, 74);
            this.CloseButton1.Name = "CloseButton1";
            this.CloseButton1.Size = new System.Drawing.Size(75, 23);
            this.CloseButton1.TabIndex = 48;
            this.CloseButton1.Text = "X";
            this.CloseButton1.UseVisualStyleBackColor = false;
            this.CloseButton1.Click += new System.EventHandler(this.CloseButton1_Click);
            // 
            // MemberDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseButton1);
            this.Name = "MemberDetails";
            this.Text = "MemberDetails";
            this.Load += new System.EventHandler(this.MemberDetails_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView membersDataGridView;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView guardDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CloseButton1;
    }
}