using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1and2WF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            double a, x, y;
            a = Convert.ToDouble(textBox1.Text);
            x = Convert.ToDouble(textBox2.Text);
            y = a * a + Convert.ToInt32(Math.Sqrt(a + x));
            textBox3.AppendText(Convert.ToString(y));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
