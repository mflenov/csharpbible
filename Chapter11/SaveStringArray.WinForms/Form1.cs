using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace SaveStringArray
{
    public partial class Form1 : Form
    {
        string fullpath;
        public Form1()
        {
            InitializeComponent();

            fullpath = Environment.GetCommandLineArgs()[0]+".list";

            if (File.Exists(fullpath))
            {
                listBox1.Items.AddRange(File.ReadAllLines(fullpath));
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = File.CreateText(fullpath);
            foreach (string s in listBox1.Items)
            {
                sw.WriteLine(s);
            }
            sw.Close();
        }
    }
}
