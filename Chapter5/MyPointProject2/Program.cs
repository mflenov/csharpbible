using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPointProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint p1 = new MyPoint(10, 20);
            MyPoint p2 = new MyPoint(20, 10);
            MyPoint p3 = p1 + p2;
            
            House house = new House(20, 10);
            MyPoint p3dsum = house + p3;

            Console.WriteLine("Точка 1: " + p1);
            Console.WriteLine("Точка 2: " + p2);
            Console.WriteLine("Точка 3: " + p3);

            p1 *= p2;
            Console.WriteLine(p1 > p2);
            Console.WriteLine(p1 < p2);
            Console.ReadLine();
        }
    }
}
