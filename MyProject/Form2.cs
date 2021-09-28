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
namespace MyProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form0 firstForm = new Form0();
            firstForm.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                string loc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\CSE\MyProject\MyProject\Database1.mdf;Integrated Security=True";

                SqlConnection con = new SqlConnection(loc);

                con.Open();

                string query = "insert  into ticketinfo(trainname,trainsch,customarid,type,adult,child,date) values('" + comboBox1.Text + "','" + comboBox3.Text + "','" + textBox1.Text + "','" + comboBox2.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "'); ";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Sucessfully Saved");


                this.Hide();
                Form3 f = new Form3();
                f.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Form3 thirdForm = new Form3();
            thirdForm.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int one = r.Next(0, 225);
            int two = r.Next(0, 225);
            int three = r.Next(0, 225);
            int four = r.Next(0, 225);

            label1.ForeColor = Color.FromArgb(one, two, three, four);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (label1.Left < 600)
            {
                label1.Left = label1.Left + 1;
            }
            else
            {
                label1.Left = -label1.Width;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int one = r.Next(0, 225);
            int two = r.Next(0, 225);
            int three = r.Next(0, 225);
            int four = r.Next(0, 225);

            label10.ForeColor = Color.FromArgb(one, two, three, four);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            if (label10.Left < 600)
            {
                label10.Left = label10.Left + 1;
            }
            else
            {
                label10.Left = -label10.Width;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
