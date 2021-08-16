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
    public partial class Setting : Form
    {
       
       public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rohit\source\repos\DB\LoginInfo2.mdf;Integrated Security=True;Connect Timeout=30");
        public Setting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update from temp where name='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            displaydata();
            MessageBox.Show("The template for applicant " + textBox1.Text + " is created");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menue mu = new Menue();
            mu.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           


            
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            displaydata();
        }
        public  void displaydata()
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
            con.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from temp where name='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            displaydata();
            MessageBox.Show("The template for applicant " +textBox1.Text + " is created");
            
        }
    }
}
