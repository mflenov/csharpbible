using System;

namespace TimeSpanProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("DateTime.Now = " + dt.ToString());

            dt = dt.Add(new TimeSpan(0, 15, 0));
            Console.WriteLine("Add(new TimeSpan(0, 15, 0) "  + dt.ToString());

            dt = dt.Add(new TimeSpan(-1, 0, 0));
            Console.WriteLine("Add(new TimeSpan(0, 15, 0)) " + dt.ToString());

            Console.ReadLine();
        }
    }
}
