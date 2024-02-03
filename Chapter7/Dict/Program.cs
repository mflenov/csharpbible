using System;
using System.Collections.Generic;

namespace HashtableProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> dict = new Dictionary<string, Person>();
            dict.Add("Вася", new Person("Василий", "Иванович"));
            dict.Add("Петя", new Person("Петр", "Сергеевич"));
            if (dict.ContainsKey("Петя"))
                dict["Петя"] = new Person("Петр", "Сергеевич");
            else
                dict.Add("Петя", new Person("Петр", "Сергеевич"));
            foreach (string key in dict.Keys)
            {
                Console.WriteLine(dict[key]);
            }
            dict.Remove("Петя");
            dict.Clear();
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
