using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chisla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int flag = 0, ch1, ch2, ch3;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ch2 = Convert.ToInt32(textBox2.Text);
            if (textBox1.Text == "")
            {
                textBox3.Text = "Введите оба числа";
            }
            else
            {
                ch1 = Convert.ToInt32(textBox1.Text);
                switch (flag)
                {
                    case 0:
                        textBox3.Text = "Выберите действие";
                        break;
                    case 1:
                        ch3 = ch1 + ch2;
                        textBox3.Text = Convert.ToString(ch3);
                        break;
                    case 2:
                        ch3 = ch1 - ch2;
                        textBox3.Text = Convert.ToString(ch3);
                        break;
                    case 3:
                        ch3 = ch1 * ch2;
                        textBox3.Text = Convert.ToString(ch3);
                        break;
                    case 4:
                        if (ch2 != 0)
                        {
                            ch3 = ch1 / ch2;
                            textBox3.Text = Convert.ToString(ch3);
                        }
                        else
                        {
                            textBox3.Text = "Делить на 0 нельзя";
                        }
                        break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.Text;
            switch (str)
            {
                case "Сложить":
                    label1.Text = "Слагаемое";
                    label2.Text = "Слагаемое";
                    label3.Text = "Сумма";
                    flag = 1;
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        ch3 = ch1 + ch2;
                        textBox3.Text = Convert.ToString(ch3);
                    }
                    break;
                case "Вычесть":
                    label1.Text = "Уменьшаемое";
                    label2.Text = "Вычитаемое";
                    label3.Text = "Разность";
                    flag = 2;
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        ch3 = ch1 - ch2;
                        textBox3.Text = Convert.ToString(ch3);
                    }
                    break;
                case "Умножить":
                    label1.Text = "Множитель";
                    label2.Text = "Множитель";
                    label3.Text = "Произведение";
                    flag = 3;
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        ch3 = ch1 * ch2;
                        textBox3.Text = Convert.ToString(ch3);
                    }
                    break;
                case "Разделить":
                    label1.Text = "Делимое";
                    label2.Text = "Делитель";
                    label3.Text = "Частное";
                    flag = 4;
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        if (ch2 != 0)
                        {
                            ch3 = ch1 / ch2;
                            textBox3.Text = Convert.ToString(ch3);
                        }
                        else
                        {
                            textBox3.Text = "Делить на 0 нельзя";
                        }
                    }
                    break;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ch1 = Convert.ToInt32(textBox1.Text);
            if (textBox2.Text == "")
            {
                textBox3.Text = "Введите оба числа";
            }
            else
            {
                ch2 = Convert.ToInt32(textBox2.Text);
                switch (flag)
                {
                    case 0:
                        textBox3.Text = "Выберите действие";
                        break;
                    case 1:
                        ch3 = ch1 + ch2;
                        textBox3.Text = Convert.ToString(ch3);
                        break;
                    case 2:
                        ch3 = ch1 - ch2;
                        textBox3.Text = Convert.ToString(ch3);
                        break;
                    case 3:
                        ch3 = ch1 * ch2;
                        textBox3.Text = Convert.ToString(ch3);
                        break;
                    case 4:
                        if (ch2 != 0)
                        {
                            ch3 = ch1 / ch2;
                            textBox3.Text = Convert.ToString(ch3);
                        }
                        else
                        {
                            textBox3.Text = "Делить на 0 нельзя";
                        }
                        break;
                }
            }
        }
    }

   
}
