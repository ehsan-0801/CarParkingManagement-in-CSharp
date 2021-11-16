namespace ParkingManagement
{
    partial class ParkingDetails
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
            this.label7 = new System.Windows.Forms.Label();
            this.CloseButton1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.parkindDetailsdataGridView = new System.Windows.Forms.DataGridView();
            this.officialDataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkindDetailsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officialDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(415, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 60);
            this.label7.TabIndex = 11;
            this.label7.Text = "Parking Details";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton1
            // 
            this.CloseButton1.BackColor = System.Drawing.Color.Firebrick;
            this.CloseButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseButton1.Location = new System.Drawing.Point(58, 53);
            this.CloseButton1.Name = "CloseButton1";
            this.CloseButton1.Size = new System.Drawing.Size(75, 23);
            this.CloseButton1.TabIndex = 12;
            this.CloseButton1.Text = "X";
            this.CloseButton1.UseVisualStyleBackColor = false;
            this.CloseButton1.Click += new System.EventHandler(this.CloseButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.officialDataGridView1);
            this.panel1.Controls.Add(this.parkindDetailsdataGridView);
            this.panel1.Location = new System.Drawing.Point(25, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 486);
            this.panel1.TabIndex = 13;
            // 
            // parkindDetailsdataGridView
            // 
            this.parkindDetailsdataGridView.AllowUserToAddRows = false;
            this.parkindDetailsdataGridView.AllowUserToDeleteRows = false;
            this.parkindDetailsdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parkindDetailsdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.parkindDetailsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parkindDetailsdataGridView.Location = new System.Drawing.Point(27, 3);
            this.parkindDetailsdataGridView.Name = "parkindDetailsdataGridView";
            this.parkindDetailsdataGridView.ReadOnly = true;
            this.parkindDetailsdataGridView.RowHeadersWidth = 51;
            this.parkindDetailsdataGridView.RowTemplate.Height = 24;
            this.parkindDetailsdataGridView.Size = new System.Drawing.Size(914, 185);
            this.parkindDetailsdataGridView.TabIndex = 65;
            // 
            // officialDataGridView1
            // 
            this.officialDataGridView1.AllowUserToAddRows = false;
            this.officialDataGridView1.AllowUserToDeleteRows = false;
            this.officialDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.officialDataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.officialDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.officialDataGridView1.Location = new System.Drawing.Point(33, 252);
            this.officialDataGridView1.Name = "officialDataGridView1";
            this.officialDataGridView1.ReadOnly = true;
            this.officialDataGridView1.RowHeadersWidth = 51;
            this.officialDataGridView1.RowTemplate.Height = 24;
            this.officialDataGridView1.Size = new System.Drawing.Size(914, 185);
            this.officialDataGridView1.TabIndex = 65;
            // 
            // ParkingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1007, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CloseButton1);
            this.Controls.Add(this.label7);
            this.Name = "ParkingDetails";
            this.Text = "Parking Details";
            this.Load += new System.EventHandler(this.ParkingDetails_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parkindDetailsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officialDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CloseButton1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView parkindDetailsdataGridView;
        public System.Windows.Forms.DataGridView officialDataGridView1;
    }
}