using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loyd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool[] arr = new bool[10] { false, false, false, false, false, false, false, false, false, false };
        private int sum = 0;

        private void pr()
        {
            label1.Text = Convert.ToString(sum);
            if (sum == 50)
            {
                MessageBox.Show("Победа!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (arr[0] == false)
            {
                arr[0] = true;
                button1.BackColor = Color.Red;
                sum += 25;
            }
            else
            {
                arr[0] = false;
                button1.BackColor = Color.White;
                sum -= 25;
            }
            pr();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (arr[1] == false)
            {
                arr[1] = true;
                button2.BackColor = Color.Red;
                sum += 27;
            }
            else
            {
                arr[1] = false;
                button2.BackColor = Color.White;
                sum -= 27;
            }
            pr();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (arr[2] == false)
            {
                arr[2] = true;
                button3.BackColor = Color.Red;
                sum += 3;
            }
            else
            {
                arr[2] = false;
                button3.BackColor = Color.White;
                sum -= 3;
            }
            pr();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (arr[3] == false)
            {
                arr[3] = true;
                button4.BackColor = Color.Red;
                sum += 12;
            }
            else
            {
                arr[3] = false;
                button4.BackColor = Color.White;
                sum -= 12;
            }
            pr();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (arr[4] == false)
            {
                arr[4] = true;
                button5.BackColor = Color.Red;
                sum += 6;
            }
            else
            {
                arr[4] = false;
                button5.BackColor = Color.White;
                sum -= 6;
            }
            pr();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (arr[5] == false)
            {
                arr[5] = true;
                button6.BackColor = Color.Red;
                sum += 15;
            }
            else
            {
                arr[5] = false;
                button6.BackColor = Color.White;
                sum -= 15;
            }
            pr();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (arr[6] == false)
            {
                arr[6] = true;
                button7.BackColor = Color.Red;
                sum += 9;
            }
            else
            {
                arr[6] = false;
                button7.BackColor = Color.White;
                sum -= 9;
            }
            pr();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (arr[7] == false)
            {
                arr[7] = true;
                button8.BackColor = Color.Red;
                sum += 30;
            }
            else
            {
                arr[7] = false;
                button8.BackColor = Color.White;
                sum -= 30;
            }
            pr();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (arr[8] == false)
            {
                arr[8] = true;
                button9.BackColor = Color.Red;
                sum += 21;
            }
            else
            {
                arr[8] = false;
                button9.BackColor = Color.White;
                sum -= 21;
            }
            pr();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (arr[9] == false)
            {
                arr[9] = true;
                button10.BackColor = Color.Red;
                sum += 19;
            }
            else
            {
                arr[9] = false;
                button10.BackColor = Color.White;
                sum -= 19;
            }
            pr();
        }
    }
}
