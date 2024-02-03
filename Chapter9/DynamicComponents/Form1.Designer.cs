namespace DynamicComponents
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПанельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designerPanel = new System.Windows.Forms.Panel();
            this.добавитьКнопкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редакторToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // редакторToolStripMenuItem
            // 
            this.редакторToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПанельToolStripMenuItem,
            this.добавитьКнопкуToolStripMenuItem});
            this.редакторToolStripMenuItem.Name = "редакторToolStripMenuItem";
            this.редакторToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.редакторToolStripMenuItem.Text = "Редактор";
            // 
            // добавитьПанельToolStripMenuItem
            // 
            this.добавитьПанельToolStripMenuItem.Name = "добавитьПанельToolStripMenuItem";
            this.добавитьПанельToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.добавитьПанельToolStripMenuItem.Text = "Добавить панель";
            this.добавитьПанельToolStripMenuItem.Click += new System.EventHandler(this.добавитьПанельToolStripMenuItem_Click);
            // 
            // designerPanel
            // 
            this.designerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.designerPanel.Location = new System.Drawing.Point(0, 24);
            this.designerPanel.Name = "designerPanel";
            this.designerPanel.Size = new System.Drawing.Size(473, 331);
            this.designerPanel.TabIndex = 1;
            // 
            // добавитьКнопкуToolStripMenuItem
            // 
            this.добавитьКнопкуToolStripMenuItem.Name = "добавитьКнопкуToolStripMenuItem";
            this.добавитьКнопкуToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.добавитьКнопкуToolStripMenuItem.Text = "Добавить кнопку";
            this.добавитьКнопкуToolStripMenuItem.Click += new System.EventHandler(this.добавитьКнопкуToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 355);
            this.Controls.Add(this.designerPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Динамические компоненты";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редакторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПанельToolStripMenuItem;
        private System.Windows.Forms.Panel designerPanel;
        private System.Windows.Forms.ToolStripMenuItem добавитьКнопкуToolStripMenuItem;
    }
}

