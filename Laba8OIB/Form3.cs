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

namespace Laba3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(512);
        private TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();

        private void ключиRSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            RSA = new RSACryptoServiceProvider(512);
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate);
            // Записать в файл информацию об открытом и секретном ключах
            StreamWriter w = new StreamWriter(fs);
            w.Write(RSA.ToXmlString(true));
            w.Flush();
            fs.Close();
            saveFileDialog2.ShowDialog();
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(saveFileDialog2.FileName, FileMode.OpenOrCreate);
            // Записать в другой файл информацию об открытом ключе
            StreamWriter w = new StreamWriter(fs);
            w.Write(RSA.ToXmlString(false));
            w.Flush();
            fs.Close();
        }

        private void выбратьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
            // выбор текстового файла и отображение данных из него в элементе управления RicTextBox.
            StreamReader fr = new StreamReader(fs);
            richTextBox1.Text = fr.ReadToEnd();
            fr.Close();
            fs.Close();
        }

        private void зашифроватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(openFileDialog2.FileName, FileMode.Open);
            // Получить информацию об открытом ключе из файла
            StreamReader r = new StreamReader(fs);
            RSA.FromXmlString(r.ReadToEnd());
            fs.Close();

            string text;
            text = richTextBox1.Text;
            saveFileDialog3.ShowDialog();
            fs = new FileStream(saveFileDialog3.FileName, FileMode.Create);
            DES = new TripleDESCryptoServiceProvider();
            byte[] EncrypKey = RSA.Encrypt(DES.Key, false);
            byte[] EncrypIV = RSA.Encrypt(DES.IV, false);
            fs.Write(EncrypKey, 0, EncrypKey.Length);
            fs.Write(EncrypIV, 0, EncrypIV.Length);
            ICryptoTransform transform = DES.CreateEncryptor();
            CryptoStream cs = new CryptoStream(fs, transform, CryptoStreamMode.Write);
            StreamWriter w = new StreamWriter(cs);
            w.Write(text);
            w.Flush();
            cs.FlushFinalBlock();
            w.Close();
            fs.Close();
            //openFileDialog3.ShowDialog();
            fs = new FileStream(saveFileDialog3.FileName, FileMode.Open);
            Int32 KeyBlockSize = System.Convert.ToInt32(RSA.KeySize / 8);
            DES = new TripleDESCryptoServiceProvider();
            EncrypKey = new Byte[KeyBlockSize];
            EncrypIV = new Byte[KeyBlockSize];
            fs.Read(EncrypKey, 0, EncrypKey.Length);
            fs.Read(EncrypIV, 0, EncrypIV.Length);
            r = new StreamReader(fs);
            richTextBox2.Text = r.ReadToEnd();
            r.Close();
            fs.Close();
        }

        private void выбратьФайлToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
        }

        private void openFileDialog4_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(openFileDialog4.FileName, FileMode.Open);
            Int32 KeyBlockSize = System.Convert.ToInt32(RSA.KeySize / 8);
            Byte[] EncrypKey = new Byte[KeyBlockSize];
            Byte[] EncrypIV = new Byte[KeyBlockSize];
            fs.Read(EncrypKey, 0, EncrypKey.Length);
            fs.Read(EncrypIV, 0, EncrypIV.Length);
            StreamReader r = new StreamReader(fs);
            richTextBox1.Text = r.ReadToEnd();
            r.Close();
            fs.Close();
        }

        private void расшифроватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            openFileDialog5.ShowDialog();
            openFileDialog6.ShowDialog();
        }

        private void openFileDialog5_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(openFileDialog5.FileName, FileMode.Open);
            StreamReader r = new StreamReader(fs);
            RSA.FromXmlString(r.ReadToEnd());
            r.Close();
            fs.Close();
        }

        private void openFileDialog6_FileOk(object sender, CancelEventArgs e)
        {
            // Открытие зашифрованного файла для чтения
            FileStream fs = new FileStream(openFileDialog6.FileName, FileMode.Open);
            // Вычисление числа байт в зашифрованном блок,
            // которое равно размеру ключа
            Int32 KeyBlockSize = System.Convert.ToInt32(RSA.KeySize / 8);
            // Получение зашифрованного симметричного ключа и
            // вектора инициализации            
            Byte[] EncrypKey = new Byte[KeyBlockSize];
            Byte[] EncrypIV = new Byte[KeyBlockSize];

            fs.Read(EncrypKey, 0, EncrypKey.Length);
            fs.Read(EncrypIV, 0, EncrypIV.Length);
            DES.KeySize = KeyBlockSize;
            DES.Key = RSA.Decrypt(EncrypKey, false);
            DES.IV = RSA.Decrypt(EncrypIV, false);
            // Чтение оставшейся части файла с помощью симметричного ключа
            ICryptoTransform transform = DES.CreateDecryptor();
            CryptoStream cs = new CryptoStream(fs, transform, CryptoStreamMode.Read);
            StreamReader r = new StreamReader(cs);
            richTextBox2.Text = r.ReadToEnd();
            r.Close();
        }
    }
}
