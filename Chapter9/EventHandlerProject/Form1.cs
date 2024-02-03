using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PersonClass;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Person p = new Person("Алексей", "Иванов");

        public Form1()
        {
            InitializeComponent();

            firstNameTextBox.Text = p.FirstName;
            lastNameTextBox.Text = p.LastName;
            ageNumericUpDown.Value = p.Age;

            p.AgeChanged += new EventHandler(AgeChanged);
        }

        public void AgeChanged(Object sender, EventArgs args)
        {
            Person p = (Person)sender;
            MessageBox.Show("Возраст изменился на " + p.Age.ToString());
        }

        private void changeFirstNameButton_Click(object sender, EventArgs e)
        {
            p.FirstName = firstNameTextBox.Text;
        }

        private void changeLastNameButton_Click(object sender, EventArgs e)
        {
            p.LastName = lastNameTextBox.Text;
        }

        private void ageChangedButton_Click(object sender, EventArgs e)
        {
            p.Age = (int)ageNumericUpDown.Value;
        }
    }
}
