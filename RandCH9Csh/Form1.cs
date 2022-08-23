using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandCH9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool player = true, flag1 = true, flag2 = true;
        Random rnd = new Random();
        int a11, a12, a13, a14, a21, a22, a23, a24, sum1 = 0, sum2 = 0, j = 3;

        private void button1_Click(object sender, EventArgs e)
        {
            a11 = rnd.Next(1, 7);
            button1.Text = Convert.ToString(a11);
            sum1 = a11 + a12 + a13 + a14;
            label6.Text = Convert.ToString(sum1);
            if (sum1 > 20)
            {
                EndOfGame(2);
            }
            else
            {
                if (flag1 != false && flag2 != false)
                {
                    Perdacha(false);
                }
            }
            Otschet();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            EndOfGame(-1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a12 = rnd.Next(1, 7);
            button2.Text = Convert.ToString(a12);
            sum1 = a11 + a12 + a13 + a14;
            label6.Text = Convert.ToString(sum1);
            if (sum1 > 20)
            {
                EndOfGame(2);
            }
            else
            {
                if (flag1 != false && flag2 != false)
                {
                    Perdacha(false);
                }
            }
            Otschet();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a13 = rnd.Next(1, 7);
            button3.Text = Convert.ToString(a13);
            sum1 = a11 + a12 + a13 + a14;
            label6.Text = Convert.ToString(sum1);
            if (sum1 > 20)
            {
                EndOfGame(2);
            }
            else
            {
                if (flag1 != false && flag2 != false)
                {
                    Perdacha(false);
                }
            }
            Otschet();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a14 = rnd.Next(1, 7);
            button4.Text = Convert.ToString(a14);
            sum1 = a11 + a12 + a13 + a14;
            label6.Text = Convert.ToString(sum1);
            if (sum1 > 20)
            {
                EndOfGame(2);
            }
            else
            {
                if (flag1 != false && flag2 != false)
                {
                    Perdacha(false);
                }
            }
            Otschet();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a21 = rnd.Next(1, 7);
            button5.Text = Convert.ToString(a21);
            sum2 = a21 + a22 + a23 + a24;
            label7.Text = Convert.ToString(sum2);
            if (sum2 > 20)
            {
                EndOfGame(1);
            }
            else
            {
                if (flag1 != false && flag2 != false)
                {
                    Perdacha(true);
                }
            }
            Otschet();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a22 = rnd.Next(1, 7);
            button6.Text = Convert.ToString(a22);
            sum2 = a21 + a22 + a23 + a24;
            label7.Text = Convert.ToString(sum2);
            if (sum2 > 20)
            {
                EndOfGame(1);
            }
            else
            {
                if (flag1 != false && flag2 != false)
                {
                    Perdacha(true);
                }
            }
            Otschet();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a23 = rnd.Next(1, 7);
            button7.Text = Convert.ToString(a23);
            sum2 = a21 + a22 + a23 + a24;
            label7.Text = Convert.ToString(sum2);
            if (sum2 > 20)
            {
                EndOfGame(1);
            }
            else
            {
                if (flag1 != false && flag2 != false)
                {
                    Perdacha(true);
                }
            }
            Otschet();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a24 = rnd.Next(1, 7);
            button8.Text = Convert.ToString(a24);
            sum2 = a21 + a22 + a23 + a24;
            label7.Text = Convert.ToString(sum2);
            if (sum2 > 20)
            {
                EndOfGame(1);
            }
            else
            {
                if (flag1 != false && flag2 != false)
                {
                    Perdacha(true);
                }
            }
            Otschet();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (player == true)
            {
                a11 = rnd.Next(1, 7);
                a12 = rnd.Next(1, 7);
                a13 = rnd.Next(1, 7);
                a14 = rnd.Next(1, 7);
                button1.Text = Convert.ToString(a11);
                button2.Text = Convert.ToString(a12);
                button3.Text = Convert.ToString(a13);
                button4.Text = Convert.ToString(a14);
                sum1 = a11 + a12 + a13 + a14;
                label6.Text = Convert.ToString(sum1);
                if (sum1 > 20)
                {
                    EndOfGame(2);
                }
                else
                {
                    if (flag1 != false && flag2 != false)
                    {
                        Perdacha(false);
                    }
                }
            }
            else
            {
                a21 = rnd.Next(1, 7);
                a22 = rnd.Next(1, 7);
                a23 = rnd.Next(1, 7);
                a24 = rnd.Next(1, 7);
                button5.Text = Convert.ToString(a21);
                button6.Text = Convert.ToString(a22);
                button7.Text = Convert.ToString(a23);
                button8.Text = Convert.ToString(a24);
                sum2 = a21 + a22 + a23 + a24;
                label7.Text = Convert.ToString(sum2);
                if (sum2 > 20)
                {
                    EndOfGame(1);
                }
                else
                {
                    if (flag1 != false && flag2 != false)
                    {
                        Perdacha(true);
                    }
                }
            }
            if (sum2 == 0)
            {
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
            }
            else
            {
                button10.Enabled = true;
            }
            Otschet();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (player == true)
            {
                flag1 = false;
                if (flag2 != false)
                {
                    Perdacha(false);
                }
            }
            else
            {
                flag2 = false;
                if (flag1 != false)
                {
                    Perdacha(true);
                }
            }
            if (flag1 == false && flag2 == false)
            {
                EndOfGame(0);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        void EndOfGame(int g)
        {
            switch (g)
            {
                case 0:
                    if (sum1 == sum2)
                    {
                        MessageBox.Show("Ничья");
                    }
                    else
                    {
                        if (sum1 > sum2)
                        {
                            MessageBox.Show("Выиграл первый игрок");
                        }
                        else
                        {
                            MessageBox.Show("Выиграл второй игрок");
                        }
                    }
                    break;
                case 1:
                    MessageBox.Show("Выиграл первый игрок");
                    break;
                case 2:
                    MessageBox.Show("Выиграл второй игрок");
                    break;
            }
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Black;
            player = true;
            flag1 = true;
            flag2 = true;
            sum1 = 0;
            sum2 = 0;
            j = 3;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            label6.Text = "0";
            label7.Text = "0";
            button10.Enabled = false;
        }
        void Perdacha(bool g)
        {
            if (g == true)
            {
                player = true;
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Black;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
            }
            else
            {
                player = false;
                label2.ForeColor = Color.Red;
                label1.ForeColor = Color.Black;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        void Otschet()
        {
            if (flag1 == false || flag2 == false)
            {
                j--;
            }
            if (j == 0)
            {
                EndOfGame(0);
            }
        }
    }
}