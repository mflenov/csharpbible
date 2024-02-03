using System;

namespace StringProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = "c:\\windows\\system32\\filename.txt";
            Console.WriteLine("path 1 = " + path1);

            string path2 = @"c:\windows\system32\filename.txt";
            Console.WriteLine("path 2 = " + path2);

            string multyline1 = "Строка 1\nСтрока 2";
            Console.WriteLine("multyline 1 = " + multyline1);

            string multyline2 = @"Строка 1
Строка 2";
            Console.WriteLine("multyline 2 = " + multyline2);
        }
    }
}
