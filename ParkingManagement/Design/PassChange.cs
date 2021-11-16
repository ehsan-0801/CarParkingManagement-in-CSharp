using DemoCarParking;
using ParkingManagement.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagement
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != textBox3.Text)
            {
                MessageBox.Show("Password didn't match");
            }
            else if (textBox2.Text.Equals(string.Empty))
            {
                MessageBox.Show("Field cannot be empty");
            }
            else
            {
                if (comboBox1.SelectedItem.ToString().Equals("Admin"))
                {
                    DbAccess db = new DbAccess();
                    string sql = "UPDATE Admin SET Password='" + textBox1.Text + "'WHERE Username='" + textBox2.Text + "'";
                    SqlCommand command = new SqlCommand(sql, db.con);
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    MessageBox.Show("Admin Password Updated successfully");
                    db.CloseConnection();

                }
                else if (comboBox1.SelectedItem.ToString().Equals("Manager"))
                {
                    DbAccess db = new DbAccess();
                    string sql = "UPDATE Manager SET Password='" + textBox1.Text + "'WHERE Username='" + textBox2.Text + "'";
                    SqlCommand command = new SqlCommand(sql, db.con);
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    MessageBox.Show("Manager Password Updated successfully");
                    db.CloseConnection();
                }
                else if (comboBox1.SelectedItem.ToString().Equals("Guard"))
                {
                    DbAccess db = new DbAccess();
                    string sql = "UPDATE Guard SET Password='" + textBox1.Text + "'WHERE Username='" + textBox2.Text + "'";
                    SqlCommand command = new SqlCommand(sql, db.con);
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    MessageBox.Show("Guard Password Updated successfully");
                    db.CloseConnection();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
        
}

