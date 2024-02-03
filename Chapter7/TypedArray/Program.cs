using System;
using System.Collections.Generic;
using System.Text;
using PersonClass;

namespace TypedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person("Иван", "Иванов"));
            persons.Add(new Person("Сергей", "Петров"));
            persons.Add(new Person("Игорь", "Сидоров"));

            persons[0].FirstName = "Новое имя";

            foreach (Person p in persons)
                Console.WriteLine(p.FirstName + " " + p.LastName);
            Console.ReadLine();
        }
    }
}
