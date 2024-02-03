using System;
using PersonClass;

namespace SortProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Сергей", "Иванов");

            person.AddChild("Сергей", "Иванов");
            person.AddChild("Алексей", "Иванов");
            person.AddChild("Валя", "Иванов");

            person.SortChildren();
            foreach (Person children in person)
                Console.WriteLine(children.FirstName + " " + children.LastName);
        }
    }
}
