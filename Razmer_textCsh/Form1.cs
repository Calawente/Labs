using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Razmer_text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelSize = label1.Font.Size;
            textBoxSize = textBox1.Font.Size;

        }
        float labelSize, textBoxSize;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (label1.Font.Size <= 20)
                {
                    labelSize += 2;
                    label1.Font = new Font(label1.Font.Name, labelSize, label1.Font.Style);
                }
                else
                {
                    button1.Enabled = false;
                }
                if (label1.Font.Size >= 3)
                {
                    button2.Enabled = true;
                }
            }
            if (radioButton2.Checked == true)
            {
                if(textBox1.Font.Size<=20)
                {
                    textBoxSize += 2;
                    textBox1.Font = new Font(textBox1.Font.Name, textBoxSize, textBox1.Font.Style);
                }
                else
                {
                    button1.Enabled = false;
                }
                if (textBox1.Font.Size >= 3)
                {
                    button2.Enabled = true;
                }
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (label1.Font.Size >= 3)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
            if (label1.Font.Size <= 20)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (textBox1.Font.Size >= 3)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
            if (textBox1.Font.Size <= 20)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (label1.Font.Size >= 3)
                {
                    labelSize -= 2;
                    label1.Font = new Font(label1.Font.Name, labelSize, label1.Font.Style);
                }
                else
                {
                    button2.Enabled = false;
                }
                if (label1.Font.Size <= 20)
                {
                    button1.Enabled = true;
                }
            }
            if (radioButton2.Checked == true)
            {
                if (textBox1.Font.Size >= 3)
                {
                    textBoxSize -= 2;
                    textBox1.Font = new Font(textBox1.Font.Name, textBoxSize, textBox1.Font.Style);
                }
                else
                {
                    button2.Enabled = false;
                }
                if (textBox1.Font.Size <= 20)
                {
                    button1.Enabled = true;
                }
            }
        }
    }
}
