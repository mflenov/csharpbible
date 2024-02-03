using System;

namespace AnonamousClasses
{
    class Program
    {
        static void Main(string[] args)
        {
			var p = new {
				FirstName = "Михаил",
				LastName = "Фленов",
				Age = 10
			};

			//p.FirstName = "Миша"; // Ошибка

			Console.WriteLine("Имя" + p.FirstName);

			Console.ReadLine();
        }
    }
}
