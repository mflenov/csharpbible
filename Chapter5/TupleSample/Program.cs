using System;

namespace TupleSample
{
    class Program
    {
        static void Main(string[] args)
        {
			Tuple<int, int> coordinates = new Tuple<int, int>(10, 20);
			Console.WriteLine(coordinates.Item1 + " " + coordinates.Item2);

			var coordinates2 = GetCoordinates();

			Console.WriteLine(coordinates2.Item1 + " " + coordinates2.Item2 + " " + coordinates2.Item3);
			Console.ReadLine();
		}

		static Tuple<int, int, int, string> GetCoordinates() {
			return new Tuple<int, int, int, string>(10, 20, 30, "Что-то");
		}
	}
}
