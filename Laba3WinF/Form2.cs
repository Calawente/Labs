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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.n = Convert.ToInt32(textBox1.Text);
            Random R = new Random();
            textBox2.Clear();
            Data.massiv = new int[Data.n];
            for(int i = 0; i < Data.n; i++)
            {
                Data.massiv[i] = R.Next(-20, 20);
                textBox2.AppendText(Data.massiv[i] + "  ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
