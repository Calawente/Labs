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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Error!");
            }
            else
            {
                string str = comboBox1.Text;
                int a = Convert.ToInt32(textBox1.Text), b = Convert.ToInt32(textBox2.Text), c;
                switch (str)
                {
                    case "+":
                        c = a + b;
                        textBox3.Text = Convert.ToString(c);
                        break;
                    case "-":
                        c = a - b;
                        textBox3.Text = Convert.ToString(c);
                        break;
                    case "*":
                        c = a * b;
                        textBox3.Text = Convert.ToString(c);
                        break;
                    case "/":
                        if (b == 0)
                        {
                            MessageBox.Show("Error!");
                        }
                        else
                        {
                            c = a / b;
                            textBox3.Text = Convert.ToString(c);
                        }
                        break;
                }

            }
        }
    }
}
