using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Form1 nf1 = new Form1();
                    nf1.Show();
                    break;
                case 1:
                    Form3 nf2 = new Form3();
                    nf2.Show();
                    break;
                case 2:
                    Form4 nf3 = new Form4();
                    nf3.Show();
                    break;
                case 3:
                    Form5 nf4 = new Form5();
                    nf4.Show();
                    break;
            }
        }
    }
}
