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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(textBox1.Text);
            int[] a = new int[n];
            Random r = new Random();
            for(int i = 0; i < n; i++)
            {
                a[i] = r.Next(-20, 20);
                textBox2.AppendText(a[i] + "  ");
            }
            int max = a[0];
            for(int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            textBox3.AppendText(Convert.ToString(max));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
