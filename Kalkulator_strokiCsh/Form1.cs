using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_stroki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private char ch;
        private double x, y;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ch = textBox1.Text[textBox1.Text.Length - 1];
            }
            if (textBox1.Text != "")
            {
                switch (ch)
                {

                    case '+':
                        if (label1.Text == "")
                        {
                            x = Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.Length - 1));
                            label1.Text = textBox1.Text;
                            textBox1.Text = "";
                        }
                        else
                        {
                            y = Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.Length - 1));
                            switch (label1.Text[label1.Text.Length - 1])
                            {
                                case '+':
                                    x = x + y;
                                    break;
                                case '-':
                                    x = x - y;
                                    break;
                                case '*':
                                    x = x * y;
                                    break;
                                case '/':
                                    x = x / y;
                                    break;
                            }
                            label1.Text = Convert.ToString(x) + '+';
                            textBox1.Text = "";
                        }
                        break;
                    case '-':
                        if (label1.Text == "")
                        {
                            x = Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.Length - 1));
                            label1.Text = textBox1.Text;
                            textBox1.Text = "";
                        }
                        else
                        {
                            y = Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.Length - 1));
                            switch (label1.Text[label1.Text.Length - 1])
                            {
                                case '+':
                                    x = x + y;
                                    break;
                                case '-':
                                    x = x - y;
                                    break;
                                case '*':
                                    x = x * y;
                                    break;
                                case '/':
                                    x = x / y;
                                    break;
                            }
                            label1.Text = Convert.ToString(x) + '-';
                            textBox1.Text = "";
                        }
                        break;
                    case '*':
                        if (label1.Text == "")
                        {
                            x = Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.Length - 1));
                            label1.Text = textBox1.Text;
                            textBox1.Text = "";
                        }
                        else
                        {
                            y = Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.Length - 1));
                            switch (label1.Text[label1.Text.Length - 1])
                            {
                                case '+':
                                    x = x + y;
                                    break;
                                case '-':
                                    x = x - y;
                                    break;
                                case '*':
                                    x = x * y;
                                    break;
                                case '/':
                                    x = x / y;
                                    break;
                            }
                            label1.Text = Convert.ToString(x) + '*';
                            textBox1.Text = "";
                        }
                        break;
                    case '/':
                        if (label1.Text == "")
                        {
                            x = Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.Length - 1));
                            label1.Text = textBox1.Text;
                            textBox1.Text = "";
                        }
                        else
                        {
                            y = Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.Length - 1));
                            switch (label1.Text[label1.Text.Length - 1])
                            {
                                case '+':
                                    x = x + y;
                                    break;
                                case '-':
                                    x = x - y;
                                    break;
                                case '*':
                                    x = x * y;
                                    break;
                                case '/':
                                    x = x / y;
                                    break;
                            }
                            label1.Text = Convert.ToString(x) + '/';
                            textBox1.Text = "";
                        }
                        break;
                    case '=':
                        y = Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.Length - 1));
                        switch (label1.Text[label1.Text.Length - 1])
                        {
                            case '+':
                                x = x + y;
                                break;
                            case '-':
                                x = x - y;
                                break;
                            case '*':
                                x = x * y;
                                break;
                            case '/':
                                x = x / y;
                                break;
                        }
                        label1.Text = "";
                        textBox1.Text = Convert.ToString(x);
                        break;
                }
            }
        }
    }
}
