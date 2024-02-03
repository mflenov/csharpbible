using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConcurentAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            new ThreadTester();
        }
    }

    class ThreadTester
    {
        public ThreadTester()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t = new Thread(new ThreadStart(ThreadFunc));
                t.Name = "Поток " + i.ToString();
                t.Start();
            }
            Console.ReadLine();
        }

        void ThreadFunc()
        {
            //lock (this)
            Monitor.Enter(this);
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " - " + i.ToString());
                    Thread.Sleep(100);
                }
            }
            finally
            {
                Monitor.Exit(this);
            }
        }
    }
}
