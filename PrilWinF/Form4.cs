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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            int M = Convert.ToInt32(textBox1.Text), k;
            for(int i = 0; i < Data.n; i++)
            {
                textBox2.AppendText(Data.arr[i] + "  ");
            }
            for(int j = 0; j < M; j++)
            {
                k = Data.arr[0];
                for(int i = 0; i < (Data.n - 1); i++)
                {
                    Data.arr[i] = Data.arr[i + 1];
                }
                Data.arr[Data.n - 1] = k;
            }
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
