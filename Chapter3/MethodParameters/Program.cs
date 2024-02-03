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
            shed.Width = 2;
            shed.Height = 1;
            shed.Lengthwise = 3;

            shed.ExpandSize(2, 4, 6);
            Console.WriteLine("Новая ширина: " + shed.Width);

            int vx = 2;
            int vy = 4;
            int vz = 6;
            shed.ExpandAndGetSize(ref vx, ref vy, ref vz);
            Console.WriteLine("Размеры 1: " + vx + " " + vy + " " + vz);

            shed.ExpandAndGetSize2(10, out vx, out vy, out vz);
            Console.WriteLine("Размеры 2: " + vx + " " + vy + " " + vz);

            Console.ReadLine();
        }
    }
}
