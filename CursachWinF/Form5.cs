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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            bool key = false;
            for (int i = 0; i < Data.n; i++)
            {
                textBox1.AppendText(Data.arr[i] + "  ");
                if ((key == false) && (Data.arr[i] % 2 == 0))
                {
                    key = true;
                    textBox2.AppendText(Convert.ToString(Data.arr[i]));
                    textBox3.AppendText(Convert.ToString(i));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
