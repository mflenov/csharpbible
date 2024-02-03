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
            person.Birthday = new DateTime(1976, 8, 11);
            person.Country = "Канада";
            person.City = "Newmarket";

            StreamWriter sw = File.CreateText("person.dat");
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            options.IgnoreReadOnlyProperties = true;
            options.IncludeFields = true;
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
