using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadProc));
            t.IsBackground = true;
            t.Start(5);
            string s;
            do
            {
                s = Console.ReadLine();
                Console.WriteLine(s);
            } while (s != "q");
        }

        public static void ThreadProc(Object number)
        {
            int loop_number = (int)number;
            for (int i = 0; i < loop_number; i++)
            {
                Console.WriteLine("Это поток");
                Thread.Sleep(1000);
            }
        }
    }
}
