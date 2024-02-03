using System;

namespace TestApplication
{
    class Program
    {
        enum WeekDays
        {
            Monday, Tuesday, Wednesday,
            Thursday, Friday, Saturday, Sunday
        };

        static void Main(string[] args)
        {
            // массив с названиями дней недели на русском
            string[] WeekDaysRussianNames = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

            WeekDays day = WeekDays.Thursday;

            // вывод дня недели в разных форматах
            Console.WriteLine("Сегодня " + day);
            Console.WriteLine("Сегодня " + WeekDaysRussianNames[(int)day]);
            int dayIndex = (int)day + 1;
            Console.WriteLine("Номер дня " + dayIndex);

            // вот так можно делать проверку сравнением
            if (day == WeekDays.Friday)
                Console.WriteLine("Скоро выходной");
            Console.ReadLine();
        }
    }

}
