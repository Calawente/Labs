namespace Albom11
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисункиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пустыняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маякToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.пустыняToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.маякToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.рисункиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // рисункиToolStripMenuItem
            // 
            this.рисункиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пустыняToolStripMenuItem,
            this.маякToolStripMenuItem});
            this.рисункиToolStripMenuItem.Name = "рисункиToolStripMenuItem";
            this.рисункиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.рисункиToolStripMenuItem.Text = "Рисунки";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // пустыняToolStripMenuItem
            // 
            this.пустыняToolStripMenuItem.Name = "пустыняToolStripMenuItem";
            this.пустыняToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пустыняToolStripMenuItem.Text = "Пустыня";
            this.пустыняToolStripMenuItem.Click += new System.EventHandler(this.пустыняToolStripMenuItem_Click);
            // 
            // маякToolStripMenuItem
            // 
            this.маякToolStripMenuItem.Name = "маякToolStripMenuItem";
            this.маякToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.маякToolStripMenuItem.Text = "Маяк";
            this.маякToolStripMenuItem.Click += new System.EventHandler(this.маякToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пустыняToolStripMenuItem1,
            this.маякToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // пустыняToolStripMenuItem1
            // 
            this.пустыняToolStripMenuItem1.Name = "пустыняToolStripMenuItem1";
            this.пустыняToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.пустыняToolStripMenuItem1.Text = "Пустыня";
            this.пустыняToolStripMenuItem1.Click += new System.EventHandler(this.пустыняToolStripMenuItem1_Click);
            // 
            // маякToolStripMenuItem1
            // 
            this.маякToolStripMenuItem1.Name = "маякToolStripMenuItem1";
            this.маякToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.маякToolStripMenuItem1.Text = "Маяк";
            this.маякToolStripMenuItem1.Click += new System.EventHandler(this.маякToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисункиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пустыняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маякToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem пустыняToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem маякToolStripMenuItem1;
    }
}

