using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateAndTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text= DateTime.Now.ToString("yyyy.MM.dd");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString("HH.mm.ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH.mm.ss");
            label2.Text = "Сегодня " + DateTime.Now.ToString("yyyy.MM.dd");
        }
    }
}
