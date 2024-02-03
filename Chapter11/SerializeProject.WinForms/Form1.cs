using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Person person = new Person();

            person.FirstName = firstnameTextBox.Text;
            person.LastName = lastnameTextBox.Text;
            person.Age = (int)ageNumericUpDown.Value;
            person.Birthday = birthdayDateTimePicker.Value;

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("person.dat", FileMode.Create, FileAccess.Write);
            formatter.Serialize(fileStream, person);
            fileStream.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ageNumericUpDown.Value = DateTime.Today.Year - birthdayDateTimePicker.Value.Year;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("person.dat", FileMode.Open, FileAccess.Read);
            Person person = (Person)formatter.Deserialize(fileStream);
            fileStream.Close();

            firstnameTextBox.Text = person.FirstName;
            lastnameTextBox.Text = person.LastName;
            ageNumericUpDown.Value = person.Age;
            birthdayDateTimePicker.Value = person.Birthday;
        }
    }
}
