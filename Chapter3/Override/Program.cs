using System;
using System.Text;

namespace PersonClass
{
    // Объявление класса программы
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Михаил", "Фленов");
            Console.WriteLine(p.ToString());

            Object o = p;
            Console.WriteLine(o.ToString());

            Console.ReadLine();
        }
    }
}
