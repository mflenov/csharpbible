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
            p.FirstNameChanged += new Person.NameChanged(FirstNameChanged);
            p.LastNameChanged += new Person.NameChanged(LastNameChanged);
        }

        public void AgeChanged(Object sender, EventArgs args)
        {
            Person p = (Person)sender;
            MessageBox.Show("Возраст изменился на " + p.Age.ToString());
        }

        public void FirstNameChanged(Object sender, NameChangedEvent args)
        {
            Person p = (Person)sender;
            MessageBox.Show("Попытка изменить имя " + p.FirstName + " на " + args.NewName);
        }

        public void LastNameChanged(Object sender, NameChangedEvent args)
        {
            Person p = (Person)sender;
            if (MessageBox.Show("Попытка изменить фамилию " + p.LastName + " на " + args.NewName, "Внимание", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                args.Canceled = true;
        }

        private void changeFirstNameButton_Click(object sender, EventArgs e)
        {
            p.FirstName = firstNameTextBox.Text;
            firstNameTextBox.Text = p.FirstName;
        }

        private void changeLastNameButton_Click(object sender, EventArgs e)
        {
            p.LastName = lastNameTextBox.Text;
            lastNameTextBox.Text = p.LastName;
        }

        private void ageChangedButton_Click(object sender, EventArgs e)
        {
            p.Age = (int)ageNumericUpDown.Value;
        }
    }
}
