using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tparameterskinds
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine(Sum(1, 2, out sum));
            Console.WriteLine(sum);
            Console.WriteLine(Sum2(1, 2, 3));
            Console.WriteLine(Sum2(1, 2, 3, 4, 5));
            Console.ReadLine();            
        }

        static int Sum(int x, int y, out int result)
        {
            result = x * y;
            return x + y;
        }

        static int Sum2(params int[] values)
        {
            int result = 0;
            foreach (int value in values)
                result += value;
            return result;
        }
    }
}
