using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            if (textBox1.Text != "" && textBox3.Text != "")
            {
                double eu = Convert.ToDouble(textBox1.Text), rub = Convert.ToDouble(textBox3.Text), euSum;
                euSum = rub / eu;
                textBox4.Text = Convert.ToString(euSum);
            }
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                double doll = Convert.ToDouble(textBox2.Text), rub1 = Convert.ToDouble(textBox3.Text), dollSum;
                dollSum = rub1 / doll;
                textBox5.Text = Convert.ToString(dollSum);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
