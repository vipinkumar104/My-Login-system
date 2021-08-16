using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Loginsystem
{
    public partial class Account : Form
    {
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rohit\source\repos\DB\LoginInfo2.mdf;Integrated Security=True;Connect Timeout=30";
        public Account()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           DialogResult dl= MessageBox.Show("Do you want to leave the progress", " ", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                this.Hide();
                Form1 fi = new Form1();
                fi.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "" || comboBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("The fields are empty please recheck");
            }
            else if (textBox8.Text != textBox2.Text)
            {
                MessageBox.Show("The passord is not maching with conform password");

            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("adduser", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@Name", textBox1.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@gender", comboBox1.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@age", textBox3.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@contact", textBox4.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@email", textBox5.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@adress", textBox6.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@postcode", textBox7.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@password", textBox8.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    SqlCommand sqlcmd2 = new SqlCommand("insert into tbluser values('"+textBox1.Text+"','"+textBox8.Text+"')",sqlcon);
                    sqlcmd2.ExecuteNonQuery();
                    
                    MessageBox.Show("The user id has been created");
                }
            }

                MessageBox.Show("Account has been created");
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }
    }
}
