using System;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 20, 4, 19, 44, 95, 74, 28, 84, 79 };

            int max = array[0];
            int min = array[0];
            foreach (int value in array)
            {
                if (value < min)
                    min = value;
                if (value > max)
                    max = value;
            }

            Console.WriteLine("Максимальное значение " + max);
            Console.WriteLine("Минимальное значение " + min);
            Console.ReadLine();
        }
    }
}
