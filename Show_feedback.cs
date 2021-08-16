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
    public partial class Show_feedback : Form
    {
        public Show_feedback()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rohit\source\repos\DB\LoginInfo2.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter da;


        private void button1_Click(object sender, EventArgs e)
        {
            Menue menu = new Menue();
            menu.Show();
            
          

        }
        public void copydata()
        {
            dataGridView2.Rows.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value)==true)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = dataGridView1.Rows[n].Cells[1].Value.ToString();
                    dataGridView2.Rows[n].Cells[1].Value = dataGridView1.Rows[n].Cells[2].Value.ToString();
                    dataGridView2.Rows[n].Cells[2].Value = dataGridView1.Rows[n].Cells[3].Value.ToString();
                    dataGridView2.Rows[n].Cells[3].Value = dataGridView1.Rows[n].Cells[4].Value.ToString();
                    dataGridView2.Rows[n].Cells[4].Value = dataGridView1.Rows[n].Cells[5].Value.ToString();
                    dataGridView2.Rows[n].Cells[5].Value = dataGridView1.Rows[n].Cells[6].Value.ToString();
                    dataGridView2.Rows[n].Cells[6].Value = dataGridView1.Rows[n].Cells[7].Value.ToString();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            copydata();



            /////////////////////////////////////////
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rohit\source\repos\DB\LoginInfo2.mdf;Integrated Security=True;Connect Timeout=30");
            //SqlDataAdapter sda = new SqlDataAdapter("select * from feedbk",con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView2.Rows.Clear();
            //foreach (DataGridViewRow item in dataGridView1.Rows)
            //{
            //    if ((bool)item.Cells[0].Value == true)
            //    {
            //        int n = dataGridView2.Rows.Add();
            //        dataGridView2.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
            //        dataGridView2.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
            //        dataGridView2.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
            //        dataGridView2.Rows[n].Cells[3].Value = item.Cells[4].Value.ToString();
            //        dataGridView2.Rows[n].Cells[4].Value = item.Cells[5].Value.ToString();
            //        dataGridView2.Rows[n].Cells[5].Value = item.Cells[6].Value.ToString();
            //        dataGridView2.Rows[n].Cells[6].Value = item.Cells[7].Value.ToString();
            //    }
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to selected applicant's", "ok ",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Hide();
                MessageBox.Show("The feedback is sent");
                Menue menu = new Menue();
                menu.ShowDialog();
                this.Close();
            }
        }

        private void Show_feedback_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from feedbk", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[1].Value = item["nameuser"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["creative"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["leadership"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["hardwork"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["punctual"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["work"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["coding"].ToString();

            }
        }
    }
}
