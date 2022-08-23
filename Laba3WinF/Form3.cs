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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            int max = Data.massiv[0], k = 0;
            int[] arr = new int[Data.n - 1];
            for(int i = 0; i < Data.n; i++)
            {
                textBox1.AppendText(Data.massiv[i] + "  ");
                if (Data.massiv[i] > max)
                {
                    max = Data.massiv[i];
                    k = i;
                }
            }
            textBox2.AppendText(Convert.ToString(max));
            Array.Copy(Data.massiv, arr, k);
            for(int i = k; i < Data.n - 1; i++)
            {
                arr[i] = Data.massiv[i + 1];
            }
            Data.n--;
            Data.massiv = new int[Data.n];
            Array.Copy(arr, Data.massiv, Data.n);
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
