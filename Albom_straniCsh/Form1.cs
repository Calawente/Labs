using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Albom_strani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int flag;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            comboBox1.Items.AddRange(new string[] { "Россия", "Германия", "Франция" });
            pictureBox1.Image = Image.FromFile(@"D:\__Doc\Liza\Desktop\Инфа\C#\Albom_strani\Europe.png");
            flag = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            comboBox1.Items.AddRange(new string[] { "Китай", "Япония", "Индия" });
            pictureBox1.Image = Image.FromFile(@"D:\__Doc\Liza\Desktop\Инфа\C#\Albom_strani\Asia.png");
            flag = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            comboBox1.Items.AddRange(new string[] { "Египет", "Нигерия", "ЮАР" });
            pictureBox1.Image = Image.FromFile(@"D:\__Doc\Liza\Desktop\Инфа\C#\Albom_strani\Africa.png");
            flag = 3;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 1:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            pictureBox1.Image = Image.FromFile(@"D:\__Doc\Liza\Desktop\Инфа\C#\Albom_strani\Russia.png");
                            break;
                        case 1:
                            pictureBox1.Image = Image.FromFile(@"D:\__Doc\Liza\Desktop\Инфа\C#\Albom_strani\Germany.png");
                            break;
                        case 2:
                            pictureBox1.Image = Image.FromFile(@"D:\__Doc\Liza\Desktop\Инфа\C#\Albom_strani\France.png");
                            break;
                    }
                    break;
                case 2:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            pictureBox1.Image = Image.FromFile(@"D:\__Doc\Liza\Desktop\Инфа\C#\Albom_strani\CHN.png");
                            break;
                        case 1:
                            pictureBox1.Image = Image.FromFile(@"D:\__Doc\Liza\Desktop\Инфа\C#\Albom_strani\Japan.png");
                            break;
                        case 2:
                            pictureBox1.Image = Image.FromFile(@"D:\__Doc\Liza\Desktop\Инфа\C#\Albom_strani\India.png");
                            break;
                    }
                    break;
                case 3:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            pictureBox1.Image = Image.FromFile(@"D:\__Doc\Liza\Desktop\Инфа\C#\Albom_strani\EGY.png");
                            break;
                        case 1:
                            pictureBox1.Image = Image.FromFile(@"D:\__Doc\Liza\Desktop\Инфа\C#\Albom_strani\Nigeria.png");
                            break;
                        case 2:
                            pictureBox1.Image = Image.FromFile(@"D:\__Doc\Liza\Desktop\Инфа\C#\Albom_strani\SouthAfrica.png");
                            break;
                    }
                    break;
            }
        }
    }
}
