using System;
using System.IO;
using System.Text.Json;

namespace SerializeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "Михаил";
            person.LastName = "Фленов";
            person.Age = 44;
            person.Birthday = new DateTime(1976, 8, 11);

            StreamWriter sw = File.CreateText("person.dat");
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            sw.WriteLine(JsonSerializer.Serialize(person, options));
            sw.Close();


            StreamReader sr = File.OpenText("person.dat");
            string str = sr.ReadToEnd();
            sr.Close();

            Person restoredPerson = JsonSerializer.Deserialize<Person>(str);

            Console.WriteLine("First name: " + restoredPerson.FirstName);
            Console.WriteLine("Last name: " + restoredPerson.LastName);
            Console.WriteLine("Age: " + restoredPerson.Age);
            Console.WriteLine("Birthday: " + restoredPerson.Birthday.ToShortDateString());
        }
    }
}
