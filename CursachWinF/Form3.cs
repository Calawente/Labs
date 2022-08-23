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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            for (int i = 0; i < Data.n; i++)
            {
                textBox2.AppendText(Data.arr[i] + "  ");
            }
            int k = Convert.ToInt32(textBox1.Text);
            int[] a = new int[Data.n + k];
            Array.Copy(Data.arr, a, Data.n);
            Random R = new Random();
            for(int i = Data.n; i < (Data.n + k); i++)
            {
                a[i] = R.Next(-20, 20);
            }
            Data.n += k;
            Data.arr = new int[Data.n];
            Array.Copy(a, Data.arr, Data.n);
            for (int i = 0; i < Data.n; i++)
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
