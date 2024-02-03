using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileStreamProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Отобразить окно выбора файла
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            // вспомогательные переменные
            byte[] buffer = new byte[100];
            ASCIIEncoding ascii = new ASCIIEncoding();

            // загрузка файла
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.ReadWrite);
            fs.Seek(10, SeekOrigin.Begin);
            int readed = fs.Read(buffer, 0, 100);
            while (readed > 0)
            {
                richTextBox1.AppendText(ascii.GetString(buffer));
                readed = fs.Read(buffer, 0, 100);
            }
        }
    }
}
