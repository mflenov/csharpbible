using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            string intsum = sum<int>(10, 20);
            Console.WriteLine(intsum);

            string strsum = sum<string>("Hello ", "world");
            Console.WriteLine(strsum);


            var result1 = DisplayName<Employee>(new Employee());
            var result2 = DisplayName<Person>(new Person());

            Console.ReadLine();
        }

        static string sum<T>(T value1, T value2)
        {
            return value1.ToString() + value2.ToString();
        }

        static string DisplayName<T>(T p) where T : Person
        {
            return p.FirstName + p.LastName;
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Employee : Person
    {
        public DateTime HoreDate { get; set; }
    }
}
