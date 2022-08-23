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

namespace Laba1
{
    public partial class Form4 : Form
    {
        private RC2CryptoServiceProvider DES = new RC2CryptoServiceProvider();
        public Form4()
        {
            InitializeComponent();
        }

        private void создатьКлючToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs1 = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate);
            fs1.Write(DES.Key, 0, DES.Key.Length);
            fs1.Close();
        }

        private void зашифроватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            ICryptoTransform transform = DES.CreateEncryptor();
            string text;
            FileStream fs2 = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate);
            StreamReader fr2 = new StreamReader(fs2);
            StreamWriter fw2 = new StreamWriter(fs2);
            text = fr2.ReadToEnd();
            fr2.Close();
            fs2.Close();
            saveFileDialog2.ShowDialog();
            FileStream fs3 = new FileStream(saveFileDialog2.FileName, FileMode.OpenOrCreate);
            fs3.Write(DES.IV, 0, DES.IV.Length);
            CryptoStream cs = new CryptoStream(fs3, transform, CryptoStreamMode.Write);
            StreamWriter fw3 = new StreamWriter(cs);
            fw3.Write(text);
            fw3.Flush();
            cs.FlushFinalBlock();
            fw3.Close();
            fs3.Close();
        }

        private void отобразитьШифрованнуюИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs4 = new FileStream(openFileDialog2.FileName, FileMode.Open);
            fs4.Seek(DES.IV.Length, SeekOrigin.Begin);
            StreamReader sr = new StreamReader(fs4);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
            fs4.Close();
        }

        private void прочестьИнформациюОКлючеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs5 = new FileStream(openFileDialog3.FileName, FileMode.Open);
            byte[] key = new byte[DES.Key.Length];
            fs5.Read(key, 0, key.Length);
            DES.Key = key;
            fs5.Close();
        }

        private void расшифроватьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
        }

        private void openFileDialog4_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs6 = new FileStream(openFileDialog4.FileName, FileMode.Open);
            Byte[] iv = new byte[DES.IV.Length];
            fs6.Read(iv, 0, iv.Length);
            DES.IV = iv;
            ICryptoTransform transform = DES.CreateDecryptor();
            CryptoStream cs = new CryptoStream(fs6, transform, CryptoStreamMode.Read);
            StreamReader fr1 = new StreamReader(cs);
            richTextBox2.Text = fr1.ReadToEnd();
            fr1.Close();
            fs6.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    DES.Mode = CipherMode.CBC;
                    break;
                case 1:
                    DES.Mode = CipherMode.CFB;
                    break;
                case 2:
                    DES.Mode = CipherMode.CTS;
                    break;
                case 3:
                    DES.Mode = CipherMode.ECB;
                    break;
                case 4:
                    DES.Mode = CipherMode.OFB;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    DES.Padding = PaddingMode.ANSIX923;
                    break;
                case 1:
                    DES.Padding = PaddingMode.ISO10126;
                    break;
                case 2:
                    DES.Padding = PaddingMode.None;
                    break;
                case 3:
                    DES.Padding = PaddingMode.PKCS7;
                    break;
                case 4:
                    DES.Padding = PaddingMode.Zeros;
                    break;
            }
        }
    }
}
