using System;

namespace HiddenOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int x = 1000000;
                int y = 3000;
                try
                {
                    checked
                    {
                        int z = x * y;
                        Console.WriteLine(z);
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Знечение результата превышает пределы");
                }
                Console.ReadLine();
            }
        }
    }
}
