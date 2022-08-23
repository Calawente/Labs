using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3WinF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            F.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 F = new Form3();
            F.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 F = new Form4();
            F.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
