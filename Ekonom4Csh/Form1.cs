using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekonom4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int flag = 1;
        int years, per, nach, kon;
        double yeard, kond, perd, nachd;

        private void button1_Click(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 1:
                    years = Convert.ToInt32(textBox2.Text);
                    per = Convert.ToInt32(textBox3.Text);
                    kon = Convert.ToInt32(textBox4.Text);
                    if (checkBox1.Checked == true)
                    {
                        kond = Convert.ToDouble(kon);
                        perd = Convert.ToDouble(per);
                        for(int i = 0; i < years; i++)
                        {
                            kond = kond / (1 + (perd / 100));
                        }
                        nach = Convert.ToInt32(kond);
                    }
                    else
                    {
                        double a = Convert.ToDouble(kon) / (1 + Convert.ToDouble(per * years) / 100);
                        nach = Convert.ToInt32(a);
                    }
                    textBox1.Text = Convert.ToString(nach);
                    break;
                case 2:
                    nachd = Convert.ToDouble(textBox1.Text);
                    perd = Convert.ToDouble(textBox3.Text);
                    kond = Convert.ToDouble(textBox4.Text);
                    double nachh = nachd;
                    years = 0;
                    if (checkBox1.Checked == true)
                    {
                        while (kond > nachd)
                        {
                            nachd = nachd + nachd * perd / 100;
                            years++;
                        }
                    }
                    else
                    {
                        while (kond > nachd)
                        {
                            years++;
                            nachd = nachh + nachd * perd * years / 100;
                        }
                    }
                    textBox2.Text = Convert.ToString(years);
                    break;
                case 3:
                    nachd = Convert.ToInt32(textBox1.Text);
                    yeard = Convert.ToInt32(textBox2.Text);
                    kond = Convert.ToInt32(textBox4.Text);
                    if (checkBox1.Checked == true)
                    {
                        perd = 100 * (Math.Pow(kond / nachd, 1 / yeard) - 1);
                    }
                    else
                    {
                        perd = (kond / nachd - 1) * 100 / yeard;
                    }
                    per = Convert.ToInt32(perd);
                    textBox3.Text = Convert.ToString(per);
                    break;
                case 4:
                    nach = Convert.ToInt32(textBox1.Text);
                    years = Convert.ToInt32(textBox2.Text);
                    per = Convert.ToInt32(textBox3.Text);
                    if (checkBox1.Checked == true)
                    {
                        for(int i = 0; i < years; i++)
                        {
                            nach = nach + nach * per / 100;
                        }
                        kon = nach;
                    }
                    else
                    {
                        kon = nach + nach * per * years / 100;
                    }
                    textBox4.Text = Convert.ToString(kon);
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox1.Clear();
            flag = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox2.Clear();
            flag = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox4.Enabled = true;
            textBox3.Clear();
            flag = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = false;
            textBox4.Clear();
            flag = 4;
        }
    }
}
