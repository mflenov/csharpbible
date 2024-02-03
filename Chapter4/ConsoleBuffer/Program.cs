using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleBuffer
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Текущая высота буфера: " + Console.BufferHeight);
            Console.WriteLine("Текущая ширина буфера: " + Console.BufferWidth);

            ConsoleColor[] colors = { ConsoleColor.Blue, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow };
            //foreach (ConsoleColor color in colors)
            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.CursorLeft = (Console.BufferWidth - color.ToString().Length) / 2;
                Console.CursorTop = 10;
                Console.ForegroundColor = color;
                Console.WriteLine(color);
                Thread.Sleep(1000);
                Console.Clear();                
            }

        }
    }
}
