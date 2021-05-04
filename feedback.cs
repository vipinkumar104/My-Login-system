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
    public partial class feedback : Form
    {
        public feedback()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rohit\source\repos\DB\LoginInfo2.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd1;


        private void button3_Click(object sender, EventArgs e)
        {

        }
      
           
        public static string creative=string.Empty;
        public static string leadership= string.Empty;
        public static string hardwork= string.Empty;
        public static string punctual= string.Empty;
        public static string workexpreance= string.Empty;
        public static string coading=string.Empty;
       
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter the applicant name");
            }
            else
            {
                richTextBox1.AppendText(textBox1.Text + "\n");
            }
        }

       

       
       

      

      

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void feedback_Load(object sender, EventArgs e)
        {

        }

       
       

        private void button10_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Good")
            {
                richTextBox1.AppendText("Yoy are good creative thinker");
            }
            else
            {
                richTextBox1.AppendText("You are bad creative thinker");
            }
            }

          
       
        private void button11_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text=="Good")
            {
                richTextBox1.AppendText("Your leadership skills are good");
            }
            else
            {
                richTextBox1.AppendText("Yoy are bad at leadership");
            }
           
            

            //////////////////////////////////////////////////

            //////////////////////////////////////////
            ///
           
        }
      
        private void button12_Click(object sender, EventArgs e)
        {
            if(comboBox3.Text=="Good")
            {
                richTextBox1.AppendText("You are Hard Working");
            }
            else
            {
                richTextBox1.AppendText("Yoyare not a hard worker");
            }
            ////////////////////////
            ///
         
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(comboBox5.Text=="Good")
            {
                richTextBox1.AppendText("You have good working expirience");
            }
            else
            {
                richTextBox1.AppendText("You dont have working expirence");
            }
        }

      

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            
            ////////////////////////////////////////////////////////

            con.Open();
            cmd1 = new SqlCommand("INSERT INTO feedbk(nameuser,creative,leadership,hardwork,punctual, work,coding) VALUES (@nameuser,@creative,@leadership,@hardwork,@punctual,@work,@coding)", con);
            cmd1.Parameters.AddWithValue("@nameuser", textBox1.Text.ToString());
            cmd1.Parameters.AddWithValue("@creative", comboBox1.Text.ToString());
            cmd1.Parameters.AddWithValue("@Leadership", comboBox2.Text.ToString());
            cmd1.Parameters.AddWithValue("@hardwork", comboBox3.Text.ToString());
            cmd1.Parameters.AddWithValue("@punctual", comboBox4.Text.ToString());
            cmd1.Parameters.AddWithValue("@work", comboBox5.Text.ToString());
            cmd1.Parameters.AddWithValue("@coding", comboBox6.Text.ToString());
            cmd1.ExecuteNonQuery();
            con.Close();


            MessageBox.Show($"Applicant {textBox1.Text} Feedback saved");


            this.Hide();
            Show_feedback shfeed = new Show_feedback();
            shfeed.ShowDialog();
            this.Close();


        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(comboBox4.Text=="Good")
            {
                richTextBox1.AppendText("You are not punctual");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(comboBox6.Text=="Good")
            {
                richTextBox1.AppendText("You have good coading skills");
            }
            else
            {
                richTextBox1.AppendText("You have bad coading skills");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

