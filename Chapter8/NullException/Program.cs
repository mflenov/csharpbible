using System;

namespace NullException
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число");

                string inLine = Console.ReadLine();
                if (inLine == "q")
                    break;

                try
                {
                    int i = Convert.ToInt32(inLine);
                    Console.WriteLine("Вы ввели {0}", i);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели некорректное число {0}", inLine);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
