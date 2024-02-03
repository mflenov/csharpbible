using System;

namespace FormatStringSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 10;
            Console.WriteLine("Index variable = " + index);
            Console.WriteLine("Index variable = {0}", index);
            Console.WriteLine(String.Format("Index variable = {0}", index));
            Console.WriteLine($"Index variable = {index}");
            Console.WriteLine($"Index variable + 5 = {index + 5}");
            Console.ReadLine();
        }
    }
}
