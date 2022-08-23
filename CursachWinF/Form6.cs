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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k;
            for (int i = 0; i < Data.n; i++)
            {
                textBox1.AppendText(Data.arr[i] + "  ");
            }
            for(int j = 0; j < (Data.n - 1); j++)
            {
                for(int i = 0; i < (Data.n - j - 1); i++)
                {
                    if (Data.arr[i] > Data.arr[i + 1])
                    {
                        k = Data.arr[i];
                        Data.arr[i] = Data.arr[i + 1];
                        Data.arr[i + 1] = k;
                    }
                }
            }
            for (int i = 0; i < Data.n; i++)
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
