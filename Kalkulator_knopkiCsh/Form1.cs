using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_knopki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool flag = true;
        private int deystvie;
        private double x, y;

        private void vychisleniye()
        {
            x = Convert.ToDouble(textBox1.Text);
            switch (deystvie)
            {
                case 1:
                    y = x + y;
                    break;
                case 2:
                    y = y - x;
                    break;
                case 3:
                    y = x * y;
                    break;
                case 4:
                    if (x != 0)
                    {
                        y = y / x;
                    }
                    else
                    {
                        textBox1.Text = "На 0 делить нельзя!";
                    }
                    break;
            }
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '9';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * (-1));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                deystvie = 1;
                y = Convert.ToDouble(textBox1.Text);
                label1.Text = textBox1.Text + '+';
                textBox1.Text = "";
                flag = false;
            }
            else
            {
                if (textBox1.Text != "")
                {
                    x = Convert.ToDouble(textBox1.Text);
                    vychisleniye();
                    deystvie = 1;
                    label1.Text = Convert.ToString(y) + '+';
                    textBox1.Text = "";
                }
                else
                {
                    deystvie = 1;
                    label1.Text = Convert.ToString(y) + '+';
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                deystvie = 2;
                y = Convert.ToDouble(textBox1.Text);
                label1.Text = textBox1.Text + '-';
                textBox1.Text = "";
                flag = false;
            }
            else
            {
                if (textBox1.Text != "")
                {
                    x = Convert.ToDouble(textBox1.Text);
                    vychisleniye();
                    deystvie = 2;
                    label1.Text = Convert.ToString(y) + '-';
                    textBox1.Text = "";
                }
                else
                {
                    deystvie = 2;
                    label1.Text = Convert.ToString(y) + '-';
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                deystvie = 3;
                y = Convert.ToDouble(textBox1.Text);
                label1.Text = textBox1.Text + '*';
                textBox1.Text = "";
                flag = false;
            }
            else
            {
                if (textBox1.Text != "")
                {
                    x = Convert.ToDouble(textBox1.Text);
                    vychisleniye();
                    deystvie = 3;
                    label1.Text = Convert.ToString(y) + '*';
                    textBox1.Text = "";
                }
                else
                {
                    deystvie = 3;
                    label1.Text = Convert.ToString(y) + '*';
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                deystvie = 4;
                y = Convert.ToDouble(textBox1.Text);
                label1.Text = textBox1.Text + '/';
                textBox1.Text = "";
                flag = false;
            }
            else
            {
                if (textBox1.Text != "")
                {
                    x = Convert.ToDouble(textBox1.Text);
                    vychisleniye();
                    deystvie = 3;
                    label1.Text = Convert.ToString(y) + '/';
                    textBox1.Text = "";
                }
                else
                {
                    deystvie = 4;
                    label1.Text = Convert.ToString(y) + '/';
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text += ',';
            }
            else
            {
                textBox1.Text += "0,";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            flag = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                vychisleniye();
                textBox1.Text = Convert.ToString(y);
                label1.Text = "";
                flag = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                y = 1 / Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                label1.Text = Convert.ToString(y);
                flag = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(1 / Convert.ToDouble(textBox1.Text));
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                y = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                label1.Text = Convert.ToString(y);
                flag = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text));
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                y = Math.Sqrt(Convert.ToDouble(textBox1.Text));
                textBox1.Text = "";
                label1.Text = Convert.ToString(y);
                flag = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                textBox1.Text = Convert.ToString(y * Convert.ToDouble(textBox1.Text) / 100);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += '0';
            }
        }
    }
}
