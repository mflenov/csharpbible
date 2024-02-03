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
            Thread t = new Thread(new ThreadStart(ThreadProc));
            t.IsBackground = true;
            t.Start();
            string s;
            do
            {
                s = Console.ReadLine();
                Console.WriteLine(s);
            } while (s != "q");
        }

        public static void ThreadProc()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Это поток");
                Thread.Sleep(1000);
            }
        }
    }
}
