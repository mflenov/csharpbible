using System;
using System.Collections.Generic;
using System.Text;

namespace MethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Shed shed = new Shed();
            Console.WriteLine(shed.GetObjectNumber());
            Shed shed1 = new Shed();
            Console.WriteLine(shed1.GetObjectNumber());

            Console.ReadLine();
        }
    }
}
