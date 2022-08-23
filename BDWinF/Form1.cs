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

namespace BDWinF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StreamWriter writer;
        String s = @"D:\__Doc\Liza\Desktop\Инфа\BDWinF\data.txt";
        public class Record
        {
            public string city, depSt, depTime;
            public int trainNum, costK, costP, numK, numP, comm = 30, rCostK, rCostP, chCostK, chCostP;
        }
        public Collection<Record> records = new Collection<Record>();
        public Collection<Record> saverecords = new Collection<Record>();

        private void AddToTable(Record record)
        {
            records.Add(record);
            dataGridView1.Rows.Add(record.city, record.depSt, record.trainNum, record.depTime, record.costK, record.numK, 
                record.costP, record.numP, record.comm, record.rCostK, record.rCostP, record.chCostK, record.chCostP);
        }
        private void SaveToFile()
        {
            writer = new StreamWriter(s);
            for(int i = 0; i < records.Count; i++)
            {
                writer.WriteLine(records[i].city);
                writer.WriteLine(records[i].depSt);
                writer.WriteLine(records[i].trainNum);
                writer.WriteLine(records[i].depTime);
                writer.WriteLine(records[i].costK);
                writer.WriteLine(records[i].numK);
                writer.WriteLine(records[i].costP);
                writer.WriteLine(records[i].numP);
                writer.WriteLine(records[i].comm);
                writer.WriteLine(records[i].rCostK);
                writer.WriteLine(records[i].rCostP);
                writer.WriteLine(records[i].chCostK);
                writer.WriteLine(records[i].chCostP);
                writer.WriteLine("$");
            }
            writer.Close();
        }
        private void FilterRows()
        {
            DataGridViewRowCollection rows = dataGridView1.Rows;
            bool[] M = new bool[rows.Count - 1];
            for(int i = 0; i < rows.Count - 1; i++)
            {
                M[i] = true;
            }
            for(int i = 0; i < rows.Count - 1; i++)
            {
                if (comboBox1.Text.Equals("") || comboBox1.Text.Equals(null))
                {
                    break;
                }
                if(Convert.ToInt32(rows[i].Cells["NumK"].Value.ToString()) < 1 && comboBox1.Text.Equals("Купе"))
                {
                    M[i] = false;
                }
                if (Convert.ToInt32(rows[i].Cells["NumP"].Value.ToString()) < 1 && comboBox1.Text.Equals("Платцкарт"))
                {
                    M[i] = false;
                }
            }
            for (int i = 0; i < rows.Count - 1; i++)
            {
                if ((comboBox1.Text.Equals("") || comboBox1.Text.Equals(null)) && (Convert.ToInt32(numericUpDown1.Value) >
                    (Convert.ToInt32(rows[i].Cells["NumK"].Value.ToString()) + Convert.ToInt32(rows[i].Cells["NumP"].Value.ToString()))))
                {
                    M[i] = false;
                }
                if (comboBox1.Text.Equals("Купе") && Convert.ToInt32(rows[i].Cells["NumK"].Value.ToString()) < Convert.ToInt32(numericUpDown1.Value))
                {
                    M[i] = false;
                }
                if (comboBox1.Text.Equals("Платцкарт") && Convert.ToInt32(rows[i].Cells["NumP"].Value.ToString()) < Convert.ToInt32(numericUpDown1.Value))
                {
                    M[i] = false;
                }
            }
            for (int i = 0; i < rows.Count - 1; i++)
            {
                if (!(rows[i].Cells["City"].Value.ToString().Contains(textBox1.Text)))
                {
                    M[i] = false;
                }
            }
            for (int i = 0; i < rows.Count - 1; i++)
            {
                rows[i].Visible = M[i];
            }
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Record record = new Record
                {
                    city = row.Cells["City"].Value.ToString(),
                    depSt = row.Cells["DepSt"].Value.ToString(),
                    trainNum = Convert.ToInt32(row.Cells["TrainNum"].Value.ToString()),
                    depTime = row.Cells["DepTime"].Value.ToString(),
                    costK = Convert.ToInt32(row.Cells["CostK"].Value.ToString()),
                    numK = Convert.ToInt32(row.Cells["NumK"].Value.ToString()),
                    costP = Convert.ToInt32(row.Cells["CostP"].Value.ToString()),
                    numP = Convert.ToInt32(row.Cells["NumP"].Value.ToString()),
                    comm = 30
                };
                record.rCostK = record.costK + record.comm;
                record.rCostP = record.costP + record.comm;
                record.chCostK = record.costK / 2 + record.comm;
                record.chCostP = record.costP / 2 + record.comm;
                row.Cells["Comm"].Value = record.comm;
                row.Cells["RCostK"].Value = record.rCostK;
                row.Cells["RCostP"].Value = record.rCostP;
                row.Cells["ChCostK"].Value = record.chCostK;
                row.Cells["ChCostP"].Value = record.chCostP;
                if (dataGridView1.CurrentRow.Index >= records.Count)
                {
                    records.Add(record);
                }
                else
                {
                    records.Insert(dataGridView1.CurrentRow.Index, record);
                    records.RemoveAt(dataGridView1.CurrentRow.Index + 1);
                }
                SaveToFile();
            }
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index < records.Count)
            {
                records.RemoveAt(dataGridView1.CurrentRow.Index);
                saverecords.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            numericUpDown1.Value = 0;
            textBox1.Clear();
            for(int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selected = dataGridView1.SelectedRows;
            if (selected.Count > 0)
            {
                for(int i = 0; i < selected.Count; i++)
                {
                    var id = selected[i].Index;
                    dataGridView1.Rows.RemoveAt(id);
                    records.RemoveAt(id);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterRows();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            FilterRows();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FilterRows();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(s);
            while (!reader.EndOfStream)
            {
                Record rec = new Record
                {
                    city = reader.ReadLine(),
                    depSt = reader.ReadLine(),
                    trainNum = Convert.ToInt32(reader.ReadLine()),
                    depTime = reader.ReadLine(),
                    costK = Convert.ToInt32(reader.ReadLine()),
                    numK = Convert.ToInt32(reader.ReadLine()),
                    costP = Convert.ToInt32(reader.ReadLine()),
                    numP = Convert.ToInt32(reader.ReadLine()),
                    comm = Convert.ToInt32(reader.ReadLine()),
                    rCostK = Convert.ToInt32(reader.ReadLine()),
                    rCostP = Convert.ToInt32(reader.ReadLine()),
                    chCostK = Convert.ToInt32(reader.ReadLine()),
                    chCostP = Convert.ToInt32(reader.ReadLine())
                };
                reader.ReadLine();
                AddToTable(rec);
            }
            reader.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(s);
            for(int i = 0; i < records.Count; i++)
            {
                if (dataGridView1.Rows[i].Visible == true)
                {
                    writer.WriteLine(records[i].city);
                    writer.WriteLine(records[i].depSt);
                    writer.WriteLine(records[i].trainNum);
                    writer.WriteLine(records[i].depTime);
                    writer.WriteLine(records[i].costK);
                    writer.WriteLine(records[i].numK);
                    writer.WriteLine(records[i].costP);
                    writer.WriteLine(records[i].numP);
                    writer.WriteLine(records[i].comm);
                    writer.WriteLine(records[i].rCostK);
                    writer.WriteLine(records[i].rCostP);
                    writer.WriteLine(records[i].chCostK);
                    writer.WriteLine(records[i].chCostP);
                    writer.WriteLine("$");
                }
            }
            writer.Close();
        }
    }


}
