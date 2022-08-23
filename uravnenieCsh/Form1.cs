using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace uravnenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text), b = Convert.ToDouble(textBox2.Text),
                c = Convert.ToDouble(textBox3.Text), x1, x2, d;
            d = b * b - 4 * a * c;
            if (a >= 0)
            {
                x1 = (b * (-1) + Math.Sqrt(d)) / (2 * a);
                x2 = (b * (-1) - Math.Sqrt(d)) / (2 * a);
                label1.Text = "x1 = " + Convert.ToString(x1);
                label2.Text = "x2 = " + Convert.ToString(x2);
            }
            else
            {
                label1.Text = "дискриминатн меньше 0";
            }
        }
    }
}
