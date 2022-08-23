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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Random rand = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = rand.Next(0, this.Width/2), y = rand.Next(0, this.Height/2);
            button2.Location = new Point(x, y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
                button2.Text = "Продолжить?";
            }
            else
            {
                timer1.Start();
                button2.Text = "поймай меня";
            }
        }
    }
}
