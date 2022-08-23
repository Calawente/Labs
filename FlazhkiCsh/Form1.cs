using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flazhki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool[] arr = new bool[5] { false, false, false, false, false };
        bool flag = true;

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (arr[1] == false)
            {
                arr[1] = true;
                button2.BackColor = Color.Red;
            }
            else
            {
                arr[1] = false;
                button2.BackColor = Color.White;
            }
            prov();
        }
        private void prov()
        {
            flag = true;
            for(int i = 0; i < 5; i++)
            {
                if (arr[i] == false)
                {
                    flag = false;
                }
            }
            if (flag == true)
            {
                MessageBox.Show("Победа");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (arr[0] == false)
            {
                arr[0] = true;
                button1.BackColor = Color.Red;
            }
            else
            {
                arr[0] = false;
                button1.BackColor = Color.White;
            }
            if (arr[2] == false)
            {
                arr[2] = true;
                button3.BackColor = Color.Red;
            }
            else
            {
                arr[2] = false;
                button3.BackColor = Color.White;
            }
            prov();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (arr[1] == false)
            {
                arr[1] = true;
                button2.BackColor = Color.Red;
            }
            else
            {
                arr[1] = false;
                button2.BackColor = Color.White;
            }
            if (arr[3] == false)
            {
                arr[3] = true;
                button4.BackColor = Color.Red;
            }
            else
            {
                arr[3] = false;
                button4.BackColor = Color.White;
            }
            prov();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (arr[2] == false)
            {
                arr[2] = true;
                button3.BackColor = Color.Red;
            }
            else
            {
                arr[2] = false;
                button3.BackColor = Color.White;
            }
            if (arr[4] == false)
            {
                arr[4] = true;
                button5.BackColor = Color.Red;
            }
            else
            {
                arr[4] = false;
                button5.BackColor = Color.White;
            }
            prov();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (arr[3] == false)
            {
                arr[3] = true;
                button4.BackColor = Color.Red;
            }
            else
            {
                arr[3] = false;
                button4.BackColor = Color.White;
            }
            prov();
        }
    }
}
