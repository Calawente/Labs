using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.ObjectModel;

namespace Laba4WinF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Collection<Record> records = new Collection<Record>();
        StreamReader reader;
        StreamWriter writer;

        String s = @"D:\__Doc\Liza\Desktop\Инфа\Laba4WinF\data.txt";
        internal Collection<Record> Records { get => records; set => records = value; }

        private void LoadFromFile()
        {
            Record record;
            reader = new StreamReader(s);
            while(!reader.EndOfStream) 
            {
                record = new Record();
                record.Name = reader.ReadLine();
                record.Fam = reader.ReadLine();
                record.Phone = reader.ReadLine();
                reader.ReadLine();
                records.Add(record);
            }
            reader.Close();
        }
        private void SaveToFile()
        {
            writer = new StreamWriter(s);
            for (int i = 0; i < records.Count; i++)
            {
                writer.WriteLine(records[i].Name);
                writer.WriteLine(records[i].Fam);
                writer.WriteLine(records[i].Phone);
                writer.WriteLine("$");
            }
            writer.Close();
        }
        private void FillListBox()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < records.Count; i++)
            {
                listBox1.Items.Add(records[i].Name + " " + records[i].Fam + " " + records[i].Phone);
            }
            listBox1.Items.Add("(новый)");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
            {
                Record record = new Record();
                record.Name = textBox2.Text;
                record.Fam = textBox1.Text;
                record.Phone = textBox3.Text;
                records.Add(record);
            }
            SaveToFile();
            FillListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < records.Count)
                records.Remove(records[listBox1.SelectedIndex]);
            SaveToFile();
            FillListBox();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadFromFile();
            FillListBox();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch;
            ch = e.KeyChar;
            string digit;
            digit = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            if (System.Char.IsControl(e.KeyChar))
            {
                return;
            }
            if (digit.IndexOf(System.Convert.ToString(ch)) == -1)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch;
            ch = e.KeyChar;
            string digit;
            digit = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            if (System.Char.IsControl(e.KeyChar))
            {
                return;
            }
            if (digit.IndexOf(System.Convert.ToString(ch)) == -1)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch;
            ch = e.KeyChar;
            string digit;
            digit = "0123456789";
            if (System.Char.IsControl(e.KeyChar))
            {
                return;
            }
            if (digit.IndexOf(System.Convert.ToString(ch)) == -1)
            {
                e.Handled = true;
            }
        }
    }
}
