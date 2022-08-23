using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Massiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arr;
        int k, max, min, ind;
        bool flag;

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                max = arr[0];
                min = arr[0];
                for(int i = 0; i < k; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                textBox5.Text = "min = " + Convert.ToString(min) + ", max = " + Convert.ToString(max);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox2.Text != "")
            {
                flag = false;
                ind = Convert.ToInt32(textBox3.Text);
                for(int i = 0; i < k; i++)
                {
                    if (ind == arr[i])
                    {
                        flag = true;
                        textBox4.Text = "Индекс числа " + Convert.ToString(ind) + ": " + Convert.ToString(i);
                        break;
                    }
                }
                if (flag == false)
                {
                    textBox4.Text = "Совпадений нет";
                }
            }
        }

        Random rnd = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            if(textBox1.Text != "")
            {
                k = Convert.ToInt32(textBox1.Text);
                arr = new int[k];
                for(int i = 0; i < k; i++)
                {
                    arr[i] = rnd.Next(-20, 20);
                    textBox2.Text = textBox2.Text + Convert.ToString(arr[i]) + ", ";
                }
            }
        }
    }
}
