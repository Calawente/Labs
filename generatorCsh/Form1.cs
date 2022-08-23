using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = comboBox1.Items.Count;
            comboBox1.SelectedIndex = rnd.Next(0, n);
            n = comboBox2.Items.Count;
            comboBox2.SelectedIndex = rnd.Next(0, n); 
            n = comboBox3.Items.Count;
            comboBox3.SelectedIndex = rnd.Next(0, n); 
            n = comboBox4.Items.Count;
            comboBox4.SelectedIndex = rnd.Next(0, n);
            textBox1.Text = comboBox3.Text + " " + comboBox1.Text + " " + comboBox2.Text + " " + comboBox4.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = comboBox3.Text + " " + comboBox1.Text + " " + comboBox2.Text + " " + comboBox4.Text;
        }
    }
}
