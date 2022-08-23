using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "hello world";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
        }
        Form2 form2 = new Form2();
        private void button4_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
        Form3 form3 = new Form3();
        private void button5_Click(object sender, EventArgs e)
        {
            form3.Show();
        }
        bool flag = true;
        private void button6_Click(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath Form_path = new System.Drawing.Drawing2D.GraphicsPath();
            Form_path.AddEllipse(0, 0, this.Width, this.Height);
            Region Form_region_el = new Region(Form_path);
            System.Drawing.Drawing2D.GraphicsPath Form_path1 = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle r = new Rectangle(0, 0, this.Width, this.Height);
            Form_path1.AddRectangle(r);
            Region Form_region_rec = new Region(Form_path1);
            if (flag==true)
            {
                this.Region = Form_region_el;
                flag = false;
            }
            else
            {
                this.Region = Form_region_rec;
                flag = true;
            }

        }
        Form4 form4 = new Form4();
        private void button7_Click(object sender, EventArgs e)
        {
            form4.Show();
        }
    }
}
