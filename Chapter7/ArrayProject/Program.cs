using System;
using System.Linq;

namespace ArrayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 10, 20, 1, 6, 15 };

            Console.WriteLine("Отсортированная версия: ");
            Array.Sort(test);
            foreach (int i in test)
                Console.WriteLine(i);

            Console.WriteLine("Реверсная версия: ");
            Array.Reverse(test);
            foreach (int i in test)
                Console.WriteLine(i);

            Console.WriteLine("Текущий размер: {0}", test.Length);
            Array.Clear(test, 2, 2);
            Console.WriteLine("После очистки: {0}", test.Length);
            foreach (int i in test)
                Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
