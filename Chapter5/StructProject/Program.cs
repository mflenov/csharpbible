using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p;
            p.FirstName = "Сергей";
            Console.WriteLine("Имя: " + p.FirstName);
            //Console.WriteLine("Фамилия: " + p.LastName);

            Person p1 = new Person();
            Console.WriteLine("Фамилия 1: " + p1.LastName);

            Person p2 = new Person("Михаил", "Фленов");
            Console.WriteLine("Фамилия 2: " + p2.LastName);

            p = new Person("Михаил", "Фленов");
            Foo(p);
            Console.WriteLine(p.FirstName);

            PersonObj pobj = new PersonObj()
            {
                FirstName = "Михаил"
            };
            Foo(pobj);
            Console.WriteLine(pobj.FirstName);

            Person ps1 = new Person("Михаил", "Фленов");
            Person ps2 = new Person("Михаил", "Фленов");
            Console.WriteLine("ps1 == ps2 " + ps1.Equals(ps2));

            PersonObj po1 = new PersonObj() { FirstName = "Михаил" };
            PersonObj po2 = new PersonObj() { FirstName = "Михаил" };
            Console.WriteLine("po1 == po2 " + po1.Equals(ps2));

            Console.ReadLine();
        }

        static void Foo(Person p)
        {
            p.FirstName = "updated";
        }
        static void Foo(PersonObj p)
        {
            p.FirstName = "updated";
        }
    }

    class PersonObj
    {
        public string FirstName;
    }


    struct Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }

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
}
