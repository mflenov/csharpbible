using System;
using System.IO;
using System.Collections.Generic;

namespace TextFileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя файла:");
            string fileName = Console.ReadLine();

            List<string> fileLines = new List<string>();
            StreamReader reader = new StreamReader(fileName);
            while (true)
            {
                String s = reader.ReadLine();
                if (s == null)
                    break;
                fileLines.Add(s);
            }
            reader.Close();            
        }
    }
}
