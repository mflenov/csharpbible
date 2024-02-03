using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructExample
{
    struct Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            age = 18;
        }

        public string FirstName;
        public string LastName;
        public int age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1;
            person1.age = 10;

            Console.WriteLine(person1.age);
            // следующая строка выдаст ошибку
            // Console.WriteLine(person1.FirstName); 

            Person person2 = new Person();
            Console.WriteLine(person2.FirstName);
            Console.WriteLine(person2.LastName);
            Console.WriteLine(person2.age);

            Person person3 = new Person("Михаил", "Фленов");
            Console.WriteLine(person3.FirstName);
            Console.WriteLine(person3.LastName);
            Console.WriteLine(person3.age);

            Console.ReadLine();
        }
    }
}
