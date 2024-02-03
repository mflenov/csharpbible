using System;

namespace TimeSpanProject
{
    class Program
    {
        static int GetNumber(string message)
        {
            while (true)
            {
                Console.WriteLine("Введите " + message);
                string input = Console.ReadLine();
                int number;
                if (Int32.TryParse(input, out number))
                {
                    return number;
                }
                Console.WriteLine("неверное значение");
            }
        }

        static void Main(string[] args)
        {
            int year = GetNumber("год");
            int month = GetNumber("месяц");
            int day = GetNumber("день");
            int hour = GetNumber("час");
            int minute = GetNumber("минуты");

            DateTime dt = new DateTime(year, month, day, hour, minute, 0);
            Console.WriteLine("День недели: " + dt.DayOfWeek.ToString());
            Console.WriteLine("День недели #: " + ((int)dt.DayOfWeek).ToString());
            Console.WriteLine("Время: " + dt.TimeOfDay.ToString());
            Console.WriteLine("День: " + dt.DayOfYear.ToString());
            Console.WriteLine(".ToString: " + dt.ToString());
            Console.WriteLine("date.ToString: " + dt.Date.ToString());
            Console.WriteLine(".ToShortDateString: " + dt.ToShortDateString());
            Console.WriteLine(".ToLongDateString: " + dt.ToLongDateString());
            Console.WriteLine(".ToShortTimeString: " + dt.ToShortTimeString());
            Console.WriteLine(".ToLongTimeString: " + dt.ToLongTimeString());

            Console.ReadLine();
        }
    }
}
