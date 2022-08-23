using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrilWinF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.n = Convert.ToInt32(textBox1.Text);
            Random R = new Random();
            textBox2.Clear();
            Data.arr = new int[Data.n];
            for(int i = 0; i < Data.n; i++)
            {
                Data.arr[i] = R.Next(-20, 20);
                textBox2.AppendText(Data.arr[i] + "  ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            F.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 F = new Form3();
            F.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 F = new Form4();
            F.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 F = new Form5();
            F.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 F = new Form6();
            F.Show();
        }
    }
}
