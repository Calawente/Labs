using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Albom11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
        }

        private void пустыняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\__Doc\Liza\Desktop\Инфа\C#\Albom11\pustynya-pesok-nebo-5dba69e.jpg");
        }

        private void маякToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\__Doc\Liza\Desktop\Инфа\C#\Albom11\fzmf3qon.jpg");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void пустыняToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\__Doc\Liza\Desktop\Инфа\C#\Albom11\pustynya-pesok-nebo-5dba69e.jpg");
        }

        private void маякToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\__Doc\Liza\Desktop\Инфа\C#\Albom11\fzmf3qon.jpg");
        }
    }
}
