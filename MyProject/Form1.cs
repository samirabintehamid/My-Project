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
    public partial class Form1 : Form
    {
        public string gender;
        public Form1()
        {
            InitializeComponent();

            timer1.Start();
            timer2.Start();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string loc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\CSE\MyProject\MyProject\Database1.mdf;Integrated Security=True";

                SqlConnection con = new SqlConnection(loc);

                con.Open();

                string query = "insert into customerinfo(name,mobile,refno,adderss,country,gender,profession,nidno) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5 + "', '" +gender + "' , '" + textBox6.Text + "','" + textBox7.Text + "' ) ;  ";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Sucessfully Saved");


                this.Hide();
                Form4 secondForm = new Form4();
                secondForm.ShowDialog();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Refresh ");
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form0 f = new Form0();

            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Text =="Male")
            {
                gender = "Male";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Text == "Female")
            {
                gender = "Female";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
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
    }
}
