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
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();

            timer1.Start();
            timer2.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();

            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form7 f = new Form7();

            f.ShowDialog();

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
            if(label1.Left<600)
            {
                label1.Left = label1.Left + 1;
            }
            else
            {
                label1.Left = -label1.Width;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form5 f = new Form5();

            f.ShowDialog();
        }
    }
}
