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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            int max = Data.arr[0], maxI = 0, min = Data.arr[0], minI = 0;
            for (int i = 0; i < Data.n; i++)
            {
                textBox1.AppendText(Data.arr[i] + "  ");
                if (Data.arr[i] > max)
                {
                    max = Data.arr[i];
                    maxI = i;
                }
                if (Data.arr[i] < min)
                {
                    min = Data.arr[i];
                    minI = i;
                }
            }
            Data.arr[maxI] = min;
            Data.arr[minI] = max;
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
