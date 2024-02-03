using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TextFileReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            List<string> fileLines = new List<string>();
            StreamReader reader = new StreamReader(ofd.FileName);
            while (true)
            {
                String s = reader.ReadLine();
                if (s == null)
                    break;
                fileLines.Add(s);
            }
            reader.Close();
            textBox1.Lines = fileLines.ToArray();
        }
    }
}
