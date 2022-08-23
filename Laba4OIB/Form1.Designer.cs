namespace Laba4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ключиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подписатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.верификацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытыйКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.верификацияПодписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog3 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog5 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog6 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog7 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ключиToolStripMenuItem,
            this.подписьToolStripMenuItem,
            this.верификацияToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // ключиToolStripMenuItem
            // 
            this.ключиToolStripMenuItem.Name = "ключиToolStripMenuItem";
            this.ключиToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ключиToolStripMenuItem.Text = "Ключи RSA";
            this.ключиToolStripMenuItem.Click += new System.EventHandler(this.ключиToolStripMenuItem_Click);
            // 
            // подписьToolStripMenuItem
            // 
            this.подписьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem,
            this.подписатьToolStripMenuItem});
            this.подписьToolStripMenuItem.Name = "подписьToolStripMenuItem";
            this.подписьToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.подписьToolStripMenuItem.Text = "Подпись";
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // подписатьToolStripMenuItem
            // 
            this.подписатьToolStripMenuItem.Name = "подписатьToolStripMenuItem";
            this.подписатьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.подписатьToolStripMenuItem.Text = "Подписать";
            this.подписатьToolStripMenuItem.Click += new System.EventHandler(this.подписатьToolStripMenuItem_Click);
            // 
            // верификацияToolStripMenuItem
            // 
            this.верификацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem1,
            this.открытыйКлючToolStripMenuItem,
            this.верификацияПодписиToolStripMenuItem});
            this.верификацияToolStripMenuItem.Name = "верификацияToolStripMenuItem";
            this.верификацияToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.верификацияToolStripMenuItem.Text = "Верификация";
            // 
            // открытьФайлToolStripMenuItem1
            // 
            this.открытьФайлToolStripMenuItem1.Name = "открытьФайлToolStripMenuItem1";
            this.открытьФайлToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.открытьФайлToolStripMenuItem1.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem1.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem1_Click);
            // 
            // открытыйКлючToolStripMenuItem
            // 
            this.открытыйКлючToolStripMenuItem.Name = "открытыйКлючToolStripMenuItem";
            this.открытыйКлючToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.открытыйКлючToolStripMenuItem.Text = "Открытый ключ";
            this.открытыйКлючToolStripMenuItem.Click += new System.EventHandler(this.открытыйКлючToolStripMenuItem_Click);
            // 
            // верификацияПодписиToolStripMenuItem
            // 
            this.верификацияПодписиToolStripMenuItem.Name = "верификацияПодписиToolStripMenuItem";
            this.верификацияПодписиToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.верификацияПодписиToolStripMenuItem.Text = "Верификация подписи";
            this.верификацияПодписиToolStripMenuItem.Click += new System.EventHandler(this.верификацияПодписиToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(422, 114);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(240, 234);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
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
            // openFileDialog5
            // 
            this.openFileDialog5.FileName = "openFileDialog5";
            // 
            // openFileDialog6
            // 
            this.openFileDialog6.FileName = "openFileDialog6";
            // 
            // openFileDialog7
            // 
            this.openFileDialog7.FileName = "openFileDialog7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ключиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подписатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem верификацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытыйКлючToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem верификацияПодписиToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog3;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.OpenFileDialog openFileDialog5;
        private System.Windows.Forms.OpenFileDialog openFileDialog6;
        private System.Windows.Forms.OpenFileDialog openFileDialog7;
    }
}

