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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k;
            for (int i = 0; i < Data.n; i++)
            {
                textBox1.AppendText(Data.massiv[i] + "  ");
            }
            k = Convert.ToInt32(textBox2.Text);
            int[] massiv1 = new int[Data.n + k];
            Random R = new Random();
            Array.Copy(Data.massiv, massiv1, Data.n);
            for(int i = Data.n; i < (Data.n + k); i++)
            {
                massiv1[i] = R.Next(-20, 20);
            }
            Data.n += k;
            Data.massiv = new int[Data.n];
            Array.Copy(massiv1, Data.massiv, Data.n);
            for(int i = 0; i < Data.n; i++)
            {
                textBox3.AppendText(Data.massiv[i] + "  ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
