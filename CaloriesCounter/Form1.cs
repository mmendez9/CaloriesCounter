using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriesCounter
{
    public partial class Form1 : Form
    {
        double total = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = total.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double banana = 115;
            total = total + banana;
            textBox1.Text = total.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            double apple = 80;
            total = total + apple;
            textBox1.Text = total.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            double orange = 90;
            total = total + orange;
            textBox1.Text = total.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            double pear = 120;
            total = total + pear;
            textBox1.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            total = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
