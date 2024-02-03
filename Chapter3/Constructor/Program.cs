using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Shed sh = new Shed(1, 2, 3);
            Console.WriteLine("Размеры сарая: " + sh.Width + ":" + sh.Lengthwise + ":" + sh.Height);
            Console.ReadLine();
        }
    }
}
