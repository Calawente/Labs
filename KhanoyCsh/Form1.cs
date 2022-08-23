using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khanoy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool flag = true;
        private int znach1 = 1, znach2 = 5, znach3 = 5, //значение верхнего элемента башни
            verh1 = 1, verh2 = 5, verh3 = 5, // положение верхнего элемента башни
            per; //значение элемента изменяющего свое положение

        private void button3_Click(object sender, EventArgs e)
        {
            if (znach3 != 0)
            {
                if (flag == true)
                {
                    flag = false;
                    per = znach3;
                    if (verh3 == 1)
                    {
                        label9.Text = "0";
                        znach3 = Convert.ToInt32(label10.Text);
                    }
                    if (verh3 == 2)
                    {
                        label10.Text = "0";
                        znach3 = Convert.ToInt32(label11.Text);
                    }
                    if (verh3 == 3)
                    {
                        label11.Text = "0";
                        znach3 = Convert.ToInt32(label12.Text);
                    }
                    if (verh3 == 4)
                    {
                        label12.Text = "0";
                        znach3 = 5;
                    }
                    verh3++;
                }
                else
                {
                    if (per < znach3)
                    {
                        flag = true;
                        if (verh3 == 2)
                        {
                            label9.Text = Convert.ToString(per);
                        }
                        if (verh3 == 3)
                        {
                            label10.Text = Convert.ToString(per);
                        }
                        if (verh3 == 4)
                        {
                            label11.Text = Convert.ToString(per);
                        }
                        if (verh3 == 5)
                        {
                            label12.Text = Convert.ToString(per);
                        }
                        verh3--;
                        znach3 = per;
                    }
                }
                game();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (znach2 != 0)
            {
                if (flag == true)
                {
                    flag = false;
                    per = znach2;
                    if (verh2 == 1)
                    {
                        label5.Text = "0";
                        znach2 = Convert.ToInt32(label6.Text);
                    }
                    if (verh2 == 2)
                    {
                        label6.Text = "0";
                        znach2 = Convert.ToInt32(label7.Text);
                    }
                    if (verh2 == 3)
                    {
                        label7.Text = "0";
                        znach2 = Convert.ToInt32(label8.Text);
                    }
                    if (verh2 == 4)
                    {
                        label8.Text = "0";
                        znach2 = 5;
                    }
                    verh2++;
                }
                else
                {
                    if (per < znach2)
                    {
                        flag = true;
                        if (verh2 == 2)
                        {
                            label5.Text = Convert.ToString(per);
                        }
                        if (verh2 == 3)
                        {
                            label6.Text = Convert.ToString(per);
                        }
                        if (verh2 == 4)
                        {
                            label7.Text = Convert.ToString(per);
                        }
                        if (verh2 == 5)
                        {
                            label8.Text = Convert.ToString(per);
                        }
                        verh2--;
                        znach2 = per;
                    }
                }
                game();
            }
        }

        private void game()
        {
            if (verh2 == 1 || verh3 == 1)
            {
                MessageBox.Show("Победа!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (znach1 != 0)
            {
                if (flag == true)
                {
                    flag = false;
                    per = znach1;
                    if (verh1 == 1)
                    {
                        label1.Text = "0";
                        znach1 = Convert.ToInt32(label2.Text);
                    }
                    if (verh1 == 2)
                    {
                        label2.Text = "0";
                        znach1 = Convert.ToInt32(label3.Text);
                    }
                    if (verh1 == 3)
                    {
                        label3.Text = "0";
                        znach1 = Convert.ToInt32(label4.Text);
                    }
                    if (verh1 == 4)
                    {
                        label4.Text = "0";
                        znach1 = 5;
                    }
                    verh1++;
                }
                else
                {
                    if (per < znach1)
                    {
                        flag = true;
                        if (verh1 == 2)
                        {
                            label1.Text = Convert.ToString(per);
                        }
                        if (verh1 == 3)
                        {
                            label2.Text = Convert.ToString(per);
                        }
                        if (verh1 == 4)
                        {
                            label3.Text = Convert.ToString(per);
                        }
                        if (verh1 == 5)
                        {
                            label4.Text = Convert.ToString(per);
                        }
                        verh1--;
                        znach1 = per;
                    }
                }
                game();
            }
        }
    }
}
