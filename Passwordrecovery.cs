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
    public partial class Passwordrecovery : Form
    {
        public Passwordrecovery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text))
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rohit\source\repos\DB\LoginInfo2.mdf;Integrated Security=True;Connect Timeout=30");
                string quary = "select * from account where email ='" + textBox1.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(quary, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    MessageBox.Show("The id OTP is send to " + textBox1.Text);
                }
                else
                {
                    MessageBox.Show("The ID is not valid");
                }
            }
            else
            {
                MessageBox.Show("Please fill the id");
            }
        }
    }
}
