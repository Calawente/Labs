using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagKvadrat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[,] arr = new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
        private int[] sum = new int[6] { 3, 3, 3, 3, 3, 3 };

        private void game()
        {
            bool flag = true;
            for (int i = 0; i < 6; i++)
            {
                if (sum[i] != 10)
                {
                    flag = false;
                }
            }
            if (flag == true)
            {
                MessageBox.Show("Победа!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && Convert.ToInt32(textBox1.Text) > 0 && Convert.ToInt32(textBox1.Text) < 9)
            {
                arr[0, 0] = Convert.ToInt32(textBox1.Text);
                sum[0] = arr[0, 0] + arr[1, 0] + arr[2, 0];
                label1.Text = Convert.ToString(sum[0]);
                sum[3] = arr[0, 0] + arr[0, 1] + arr[0, 2];
                label4.Text = Convert.ToString(sum[3]);
            }
            else
            {
                textBox1.Text = "1";
            }
            game();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && Convert.ToInt32(textBox2.Text) > 0 && Convert.ToInt32(textBox2.Text) < 9)
            {
                arr[0, 1] = Convert.ToInt32(textBox2.Text);
                sum[1] = arr[0, 1] + arr[1, 1] + arr[2, 1];
                label2.Text = Convert.ToString(sum[1]);
                sum[3] = arr[0, 0] + arr[0, 1] + arr[0, 2];
                label4.Text = Convert.ToString(sum[3]);
            }
            else
            {
                textBox2.Text = "1";
            }
            game();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && Convert.ToInt32(textBox3.Text) > 0 && Convert.ToInt32(textBox3.Text) < 9)
            {
                arr[0, 2] = Convert.ToInt32(textBox3.Text);
                sum[2] = arr[0, 2] + arr[1, 2] + arr[2, 2];
                label3.Text = Convert.ToString(sum[2]);
                sum[3] = arr[0, 0] + arr[0, 1] + arr[0, 2];
                label4.Text = Convert.ToString(sum[3]);
            }
            else
            {
                textBox3.Text = "1";
            }
            game();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && Convert.ToInt32(textBox5.Text) > 0 && Convert.ToInt32(textBox5.Text) < 9)
            {
                arr[1, 0] = Convert.ToInt32(textBox5.Text);
                sum[0] = arr[0, 0] + arr[1, 0] + arr[2, 0];
                label1.Text = Convert.ToString(sum[0]);
                sum[4] = arr[1, 0] + arr[1, 1] + arr[1, 2];
                label5.Text = Convert.ToString(sum[4]);
            }
            else
            {
                textBox5.Text = "1";
            }
            game();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "" && Convert.ToInt32(textBox6.Text) > 0 && Convert.ToInt32(textBox6.Text) < 9)
            {
                arr[1, 1] = Convert.ToInt32(textBox6.Text);
                sum[1] = arr[0, 1] + arr[1, 1] + arr[2, 1];
                label2.Text = Convert.ToString(sum[1]);
                sum[4] = arr[1, 0] + arr[1, 1] + arr[1, 2];
                label5.Text = Convert.ToString(sum[4]);
            }
            else
            {
                textBox6.Text = "1";
            }
            game();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "" && Convert.ToInt32(textBox7.Text) > 0 && Convert.ToInt32(textBox7.Text) < 9)
            {
                arr[1, 2] = Convert.ToInt32(textBox7.Text);
                sum[2] = arr[0, 2] + arr[1, 2] + arr[2, 2];
                label3.Text = Convert.ToString(sum[2]);
                sum[4] = arr[1, 0] + arr[1, 1] + arr[1, 2];
                label5.Text = Convert.ToString(sum[4]);
            }
            else
            {
                textBox7.Text = "1";
            }
            game();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != "" && Convert.ToInt32(textBox9.Text) > 0 && Convert.ToInt32(textBox9.Text) < 9)
            {
                arr[2, 0] = Convert.ToInt32(textBox9.Text);
                sum[0] = arr[0, 0] + arr[1, 0] + arr[2, 0];
                label1.Text = Convert.ToString(sum[0]);
                sum[5] = arr[2, 0] + arr[2, 1] + arr[2, 2];
                label6.Text = Convert.ToString(sum[5]);
            }
            else
            {
                textBox9.Text = "1";
            }
            game();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != "" && Convert.ToInt32(textBox10.Text) > 0 && Convert.ToInt32(textBox10.Text) < 9)
            {
                arr[2, 1] = Convert.ToInt32(textBox10.Text);
                sum[1] = arr[0, 1] + arr[1, 1] + arr[2, 1];
                label2.Text = Convert.ToString(sum[1]);
                sum[5] = arr[2, 0] + arr[2, 1] + arr[2, 2];
                label6.Text = Convert.ToString(sum[5]);
            }
            else
            {
                textBox10.Text = "1";
            }
            game();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != "" && Convert.ToInt32(textBox11.Text) > 0 && Convert.ToInt32(textBox11.Text) < 9)
            {
                arr[2, 2] = Convert.ToInt32(textBox11.Text);
                sum[2] = arr[0, 2] + arr[1, 2] + arr[2, 2];
                label3.Text = Convert.ToString(sum[2]);
                sum[5] = arr[2, 0] + arr[2, 1] + arr[2, 2];
                label6.Text = Convert.ToString(sum[5]);
            }
            else
            {
                textBox11.Text = "1";
            }
            game();
        }
    }
}
