using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Laba4
{
    public partial class Form1 : Form
    {

        private RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(512);

        public Form1()
        {
            InitializeComponent();
        }

        private void ключиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            saveFileDialog2.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e) //открытый и секретный
        {
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate);
            StreamWriter w = new StreamWriter(fs);
            w.Write(RSA.ToXmlString(true));
            w.Flush();
            fs.Close();
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e) // открытый
        {
            FileStream fs = new FileStream(saveFileDialog2.FileName, FileMode.OpenOrCreate);
            StreamWriter w = new StreamWriter(fs);
            w.Write(RSA.ToXmlString(false));
            w.Flush();
            fs.Close();
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
            StreamReader fr = new StreamReader(fs);
            richTextBox1.Text = fr.ReadToEnd();
            fr.Close();
            fs.Close();
        }

        private void подписатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text;
            Byte[] signature;
            openFileDialog7.ShowDialog();
            FileStream fs = new FileStream(openFileDialog7.FileName, FileMode.Open);//text
            StreamReader r = new StreamReader(fs);
            text = r.ReadToEnd();
            r.Close();
            fs.Close();
            RSA = new RSACryptoServiceProvider();
            openFileDialog2.ShowDialog();
            fs = new FileStream(openFileDialog2.FileName, FileMode.Open);//key1
            r = new StreamReader(fs);
            RSA.FromXmlString(r.ReadToEnd());
            fs.Close();
            byte[] databytes = System.Text.Encoding.UTF8.GetBytes(text);
            signature = RSA.SignData(databytes, new MD5CryptoServiceProvider());
            saveFileDialog3.ShowDialog();
            fs = new FileStream(saveFileDialog3.FileName, FileMode.OpenOrCreate);//sign
            fs.Write(signature, 0, signature.Length);
            fs.Close();
        }

        private void открытьФайлToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void открытыйКлючToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(openFileDialog3.FileName, FileMode.Open);
            StreamReader r = new StreamReader(fs);
            RSA.FromXmlString(r.ReadToEnd());
            fs.Close();
        }

        private void верификацияПодписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
        }

        private void openFileDialog4_FileOk(object sender, CancelEventArgs e)
        {
            string text;
            Byte[] signature = new Byte[64];
            FileStream fs = new FileStream(openFileDialog4.FileName, FileMode.Open);//text
            StreamReader r = new StreamReader(fs);
            text = r.ReadToEnd();
            r.Close();
            fs.Close();
            RSA = new RSACryptoServiceProvider();
            openFileDialog5.ShowDialog();
            fs = new FileStream(openFileDialog5.FileName, FileMode.Open);//key2
            r = new StreamReader(fs);
            RSA.FromXmlString(r.ReadToEnd());
            fs.Close();
            byte[] databytes = System.Text.Encoding.UTF8.GetBytes(text);
            openFileDialog6.ShowDialog();
            fs = new FileStream(openFileDialog6.FileName, FileMode.Open);//sign
            fs.Read(signature, 0, signature.Length);
            fs.Close();
            if (RSA.VerifyData(databytes, new MD5CryptoServiceProvider(), signature))
            {
                label1.Text = "Подпись верна";
            }
            else
            {
                label1.Text = "Подпись не верна";
            }
        }
    }
}
