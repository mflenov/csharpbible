using System;
using System.Text;

namespace PropertiesExample
{
    // Объявление класса программы
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект
            Shed myFirstShed = new Shed();
            // Задаем значения свойств
            myFirstShed.Height = 10;
            myFirstShed.Width = 20;
            myFirstShed.Lengthwise = myFirstShed.Width;

            // Вывод на экран значений
            Console.WriteLine("Высота: " + myFirstShed.Height);
            Console.WriteLine("Ширина: " + myFirstShed.Width);
            Console.WriteLine("Глубина: " + myFirstShed.Lengthwise);

            Console.ReadLine();
        }
    }

    // Класс сарая
    class Shed
    {
        int width;
        int height;

        public int Width {
            get { return width; }
            set { width = value; }
        }

        public int Height {
            get { return height; }
            set { height = value; }
        }

        public int Lengthwise { get; set; }

        public int GetSize() => 
            Width * Height * Lengthwise;
    }
}
