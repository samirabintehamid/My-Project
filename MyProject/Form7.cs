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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();

            f.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (label3.Left < 600)
            {
                label3.Left = label3.Left + 1;
            }
            else
            {
                label3.Left = -label3.Width;
            }
        }
    }
}
