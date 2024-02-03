using System;
using System.Collections.Generic;
using System.Text;

namespace MethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("и");
            Console.WriteLine(true & true);
            Console.WriteLine(true & false);
            Console.WriteLine(false & true);
            Console.WriteLine(false & false);

            Console.WriteLine("Или");
            Console.WriteLine(true | true);
            Console.WriteLine(true | false);
            Console.WriteLine(false | true);
            Console.WriteLine(false | false);

            Console.WriteLine("Исключающее ИЛИ");
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ true);
            Console.WriteLine(false ^ false);

            int a = 0b_0000_0110;
            int b = 0b_0001_0010;
            Console.WriteLine(a | b);
            Console.WriteLine(a & b);
        }
    }
}
