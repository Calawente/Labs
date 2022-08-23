using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uravnenie12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, D, x1, x2, x, y, p1, p2, h = 0.1;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                D = b * b - 4 * a * c;
                this.chart1.Series[0].Points.Clear();
                if (D < 0)
                {
                    label4.Text = "Корней нет";
                    p1 = (-1 * b / (2 * a)) - 5;
                    p2 = (-1 * b / (2 * a)) + 5;
                }
                else
                {
                    if (D == 0)
                    {
                        x1 = -1 * b / (2 * a);
                        label4.Text = "Ответ: x = " + Convert.ToString(x1);
                        p1 = x1 - 5;
                        p2 = x1 + 5;
                    }
                    else
                    {
                        x1 = (-1 * b - Math.Sqrt(D)) / (2 * a);
                        x2 = (-1 * b + Math.Sqrt(D)) / (2 * a);
                        if (x1 > x2)
                        {
                            p1 = x2 - 1;
                            p2 = x1 + 1;
                        }
                        else
                        {
                            p1 = x1 - 1;
                            p2 = x2 + 1;
                        }
                        label4.Text = "Ответ: x1 = " + x1.ToString("0.###") + ", x2 = " + x2.ToString("0.###");
                    }
                }
                x = p1;
                while (x <= p2)
                {
                    y = a * x * x + b * x + c;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += h;
                }
            }
            else
            {
                label4.Text = "Заполните все поля";
            }
        }
    }
}