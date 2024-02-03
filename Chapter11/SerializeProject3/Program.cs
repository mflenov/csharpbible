using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

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
            XmlSerializer serializerout = new XmlSerializer(typeof(Person),
               new Type[] { typeof(Person) });
            serializerout.Serialize(sw, person);
            sw.Close();


            XmlSerializer serializerin = new XmlSerializer(typeof(Person),
               new Type[] { typeof(Person) });

            StreamReader fsin = File.OpenText("person.dat");
            Person restoredPerson = (Person)serializerin.Deserialize(fsin);
            fsin.Close();

            Console.WriteLine("First name: " + restoredPerson.FirstName);
            Console.WriteLine("Last name: " + restoredPerson.LastName);
            Console.WriteLine("Age: " + restoredPerson.Age);
            Console.WriteLine("Birthday: " + restoredPerson.Birthday.ToShortDateString());
        }
    }
}
