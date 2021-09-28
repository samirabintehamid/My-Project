using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 f = new Form2();

            f.ShowDialog();
        }
        public int price =10;
        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox2.Text == "Dhaka" && comboBox3.Text == "Sylhet")
            {
                price = 350;
              label9.Text=  price.ToString();

            }
           
        }

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label11.Left < 600)
            {
                label11.Left = label11.Left + 1;
            }
            else
            {
                label11.Left = -label11.Width;
            }
        }
    }
}
