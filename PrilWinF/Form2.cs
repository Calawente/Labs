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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            int[] a = new int[Data.n - 1];
            int max = Data.arr[0], maxI = 0;
            for(int i = 0; i < Data.n; i++)
            {
                textBox1.AppendText(Data.arr[i] + "  ");
                if (Data.arr[i] > max)
                {
                    max = Data.arr[i];
                    maxI = i;
                }
            }
            Array.Copy(Data.arr, a, maxI);
            Data.n--;
            for(int i = maxI; i < Data.n; i++)
            {
                a[i] = Data.arr[i + 1];
            }
            Data.arr = new int[Data.n];
            Array.Copy(a, Data.arr, Data.n);
            for(int i = 0; i < Data.n; i++)
            {
                textBox2.AppendText(Data.arr[i] + "  ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
