using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int red = 0, green = 0, blue = 0;
        char ch;

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            blue = hScrollBar3.Value;
            textBox3.Text = Convert.ToString(blue);
            colorChange(red, green, blue);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                red = Convert.ToInt32(textBox1.Text);
            }         
            if (red > 255)
            {
                red = 255;
                textBox1.Text = Convert.ToString(red);
            }
            hScrollBar1.Value = red;
            colorChange(red, green, blue);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                green = Convert.ToInt32(textBox2.Text);
            }          
            if (green > 255)
            {
                green = 255;
                textBox2.Text = Convert.ToString(green);
            }
            hScrollBar2.Value = green;
            colorChange(red, green, blue);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                blue = Convert.ToInt32(textBox3.Text);
            }      
            if (blue > 255)
            {
                blue = 255;
                textBox3.Text = Convert.ToString(blue);
            }
            hScrollBar3.Value = blue;
            colorChange(red, green, blue);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            green = hScrollBar2.Value;
            textBox2.Text = Convert.ToString(green);
            colorChange(red, green, blue);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            red = hScrollBar1.Value;
            textBox1.Text = Convert.ToString(red);
            colorChange(red, green, blue);
        }

        private void colorChange(int r,int g, int b)
        {
            button1.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
