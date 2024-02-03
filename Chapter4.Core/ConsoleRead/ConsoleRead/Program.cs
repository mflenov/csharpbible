using System;

namespace ConsoleRead
{
    class Program
    {
        static void Main(string[] args)
        {
			char ch;
			Console.WriteLine("Введите строку, чтобы разбить ее на символы:");
			do {
				int x = Console.Read();
				ch = Convert.ToChar(x);
				if (x != 13 && x != 13)
					Console.WriteLine(ch + x);
			} while (ch != 'q');

			string str;
			Console.WriteLine("Введите строку, я прочитаю ее полностью:");
			do {
				str = Console.ReadLine();
				Console.WriteLine(str);
			} while (str != "q");
		}
	}
}
