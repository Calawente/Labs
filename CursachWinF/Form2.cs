using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursachWinF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            int k = Convert.ToInt32(textBox1.Text);
            int[] a = new int[Data.n - 1];
            for(int i = 0; i < Data.n; i++)
            {
                textBox2.AppendText(Data.arr[i] + "  ");
            }
            Array.Copy(Data.arr, a, k);
            for(int i = k; i < (Data.n - 1); i++)
            {
                a[i] = Data.arr[i + 1];
            }
            Data.n--;
            Data.arr = new int[Data.n];
            Array.Copy(a, Data.arr, Data.n);
            for(int i = 0; i < Data.n; i++)
            {
                textBox3.AppendText(Data.arr[i] + "  ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
