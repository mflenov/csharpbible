using System;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1, max = 5;
            for (int i = 2; i <= max; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
