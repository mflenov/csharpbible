using System;
using PersonClass;


namespace IEnumerableProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Сергей", "Иванов");

            Console.WriteLine("Введите количество детей:");
            int childrenNumber = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < childrenNumber; i++)
            {
                Console.WriteLine($"Введите имя ребенка {i + 1}:");
                string name = Console.ReadLine();
                person.AddChild(name, "Иванов");
            }
            Console.WriteLine("Введите индекс ребенка для удаления:");
            childrenNumber = Int32.Parse(Console.ReadLine());
            if (childrenNumber >= 0 && childrenNumber < person.GetChildrenNumber())
            {
                person.DeleteChild(childrenNumber);
            }

            Console.WriteLine("Список детей:");
            foreach (Person children in person)
            {
                Console.WriteLine(" " + children.FirstName + " " + children.LastName);
            }
        }
    }
}
