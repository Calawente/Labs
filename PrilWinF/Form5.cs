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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            bool key = false;
            for (int i = 0; i < Data.n; i++)
            {
                textBox1.AppendText(Data.arr[i] + "  ");
            }
            for (int i = 0; i < Data.n; i++)
            {
                if (Data.arr[i] < 0)
                {
                    a = Data.arr[i];
                    b = i;
                    key = true;
                    break;
                }
            }
            if (key == true)
            {
                textBox2.AppendText(Convert.ToString(a));
                textBox3.AppendText(Convert.ToString(b));
            }
            else
            {
                textBox2.AppendText("Эл. отсутствует");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
