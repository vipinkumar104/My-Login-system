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
    public partial class Templates : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rohit\source\repos\DB\LoginInfo2.mdf;Integrated Security=True;Connect Timeout=30");
        public Templates()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            

         

            this.Close();
            feedback feed = new feedback();
            feed.ShowDialog();
            this.Close();
        }

        private void Templates_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into temp values('" + textBox1.Text.Trim() + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("The template for applicant " + textBox1.Text + " is created");
            con.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from temp";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = dt;

          
            con.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Menue mu = new Menue();
            mu.ShowDialog();
            this.Close();

        }
    }
}
