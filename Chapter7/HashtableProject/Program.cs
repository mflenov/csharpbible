using System;
using System.Collections;

namespace HashtableProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            hash.Add("Михаил Смирнов", new Person("Михаил", "Смирнов"));
            hash.Add("Сергей Иванов", new Person("Сергей", "Иванов"));
            hash.Add("Алексей Петров", new Person("Алексей", "Петров"));
            if (!hash.ContainsKey("Алексей Петров"))
                hash.Add("Алексей Петров", new Person("Алексей", "Петров"));
            else
                hash["Алексей Петров"] = new Person("Алексей", "Петров");

            Console.WriteLine("Значения:");
            foreach (Person p in hash.Values)
                Console.WriteLine(p.LastName);

            Console.WriteLine("\nКлючи:");
            foreach (String s in hash.Keys)
                Console.WriteLine(s);

            Console.WriteLine("\nДоступ к значению по ключу:");
            foreach (Object key in hash.Keys)
            {
                Person p = (Person)hash[key];
                Console.WriteLine("Ключ: '" + key + "' Значение:" + p.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public String FirstName { get; set; }
        public String LastName { get; set; }
    }
}
