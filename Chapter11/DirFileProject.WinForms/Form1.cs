using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DirFileProject
{
    public partial class Form1 : Form
    {
        string FPath = "C:\\";
        public Form1()
        {
            InitializeComponent();
            GetFiles();
        }

        void GetFiles()
        {
            listView1.BeginUpdate();
            listView1.Items.Clear();

            string[] dirs = Directory.GetDirectories(FPath);
            foreach (string s in dirs)
            {
                if ((File.GetAttributes(s) & FileAttributes.Hidden) == FileAttributes.Hidden)
                    continue;

                string dirname = System.IO.Path.GetFileName(s);
                listView1.Items.Add(dirname, 1);
            }

            string[] files = Directory.GetFiles(FPath);
            foreach (string s in files)
            {
                string filename = System.IO.Path.GetFileName(s);
                listView1.Items.Add(filename, 0);
            }
            
            listView1.EndUpdate();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView1.SelectedItems[0];
            if (item.ImageIndex == 1)
            {
                FPath = FPath + item.Text + "\\";
                GetFiles();
            }
        }
    }
}
