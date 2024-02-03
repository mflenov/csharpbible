using System;
using System.Collections;

namespace StackProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("Первый");
            stack.Push("Второй");
            stack.Push("Третий");
            stack.Push("Четвертый");
            stack.Push("Пятый");

            for (; stack.Count > 0;)
            {
                String s = stack.Pop().ToString();
                Console.WriteLine(s);
            }

            /*
            do
            {
                String s = stack.Pop().ToString();
                Console.WriteLine(s);
            } while (stack.Count > 0);
            */

            Console.ReadLine();
        }
    }
}
