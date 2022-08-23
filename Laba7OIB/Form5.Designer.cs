namespace Laba1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дешифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочестьИнформациюОКлючеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расшифроватьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ANSIX923",
            "ISO10126",
            "None",
            "PKCS7",
            "Zeros"});
            this.comboBox2.Location = new System.Drawing.Point(531, 123);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Режим сцепления блоков шифра",
            "Режим обратной связи по шифру",
            "Режим захвата зашифрованного текста",
            "Режим электронной кодовой книги",
            "Режим выходной обратной связи"});
            this.comboBox1.Location = new System.Drawing.Point(531, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(282, 145);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(173, 177);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(65, 145);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(173, 177);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шифрованиеToolStripMenuItem,
            this.дешифрованиеToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // шифрованиеToolStripMenuItem
            // 
            this.шифрованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьКлючToolStripMenuItem,
            this.зашифроватьToolStripMenuItem,
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem});
            this.шифрованиеToolStripMenuItem.Name = "шифрованиеToolStripMenuItem";
            this.шифрованиеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.шифрованиеToolStripMenuItem.Text = "Шифрование";
            // 
            // создатьКлючToolStripMenuItem
            // 
            this.создатьКлючToolStripMenuItem.Name = "создатьКлючToolStripMenuItem";
            this.создатьКлючToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.создатьКлючToolStripMenuItem.Text = "Создать ключ,";
            this.создатьКлючToolStripMenuItem.Click += new System.EventHandler(this.создатьКлючToolStripMenuItem_Click);
            // 
            // зашифроватьToolStripMenuItem
            // 
            this.зашифроватьToolStripMenuItem.Name = "зашифроватьToolStripMenuItem";
            this.зашифроватьToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.зашифроватьToolStripMenuItem.Text = "Зашифровать информацию";
            this.зашифроватьToolStripMenuItem.Click += new System.EventHandler(this.зашифроватьToolStripMenuItem_Click);
            // 
            // отобразитьШифрованнуюИнформациюToolStripMenuItem
            // 
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Name = "отобразитьШифрованнуюИнформациюToolStripMenuItem";
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Text = "Отобразить шифрованную информацию";
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Click += new System.EventHandler(this.отобразитьШифрованнуюИнформациюToolStripMenuItem_Click);
            // 
            // дешифрованиеToolStripMenuItem
            // 
            this.дешифрованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прочестьИнформациюОКлючеToolStripMenuItem,
            this.расшифроватьФайлToolStripMenuItem});
            this.дешифрованиеToolStripMenuItem.Name = "дешифрованиеToolStripMenuItem";
            this.дешифрованиеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.дешифрованиеToolStripMenuItem.Text = "Дешифрование";
            // 
            // прочестьИнформациюОКлючеToolStripMenuItem
            // 
            this.прочестьИнформациюОКлючеToolStripMenuItem.Name = "прочестьИнформациюОКлючеToolStripMenuItem";
            this.прочестьИнформациюОКлючеToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.прочестьИнформациюОКлючеToolStripMenuItem.Text = "Прочесть информацию о ключе";
            this.прочестьИнформациюОКлючеToolStripMenuItem.Click += new System.EventHandler(this.прочестьИнформациюОКлючеToolStripMenuItem_Click);
            // 
            // расшифроватьФайлToolStripMenuItem
            // 
            this.расшифроватьФайлToolStripMenuItem.Name = "расшифроватьФайлToolStripMenuItem";
            this.расшифроватьФайлToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.расшифроватьФайлToolStripMenuItem.Text = "Расшифровать файл";
            this.расшифроватьФайлToolStripMenuItem.Click += new System.EventHandler(this.расшифроватьФайлToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            this.openFileDialog3.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog3_FileOk);
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            this.openFileDialog4.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog4_FileOk);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шифрованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьКлючToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зашифроватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отобразитьШифрованнуюИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дешифрованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочестьИнформациюОКлючеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расшифроватьФайлToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
    }
}