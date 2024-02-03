using System;

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
			foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor))) {
				Console.CursorLeft = (Console.BufferWidth - color.ToString().Length) / 2;
				Console.CursorTop = 10;
				Console.ForegroundColor = color;
				Console.WriteLine(color);
				System.Threading.Tasks.Task.Delay(1000).Wait();
				Console.Clear();
			}
		}
	}
}
