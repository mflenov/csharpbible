using System;
using System.Text;

namespace PersonClass
{
    // Объявление класса программы
    class Program
    {
        static void Main(string[] args)
        {
            Figure rect;
            rect = new RectangleFigure();
            rect.Draw();

            rect = new CircleFigure();
            rect.Draw();
        }
    }
    abstract class Figure
    {
        public int left { get; set; }
        public int top { get; set; }

        abstract public void Draw();
    }

    class RectangleFigure : Figure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Это класс прямоугольника");
        }
    }

    class CircleFigure : Figure
    {
        public int Radius { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Это класс круга");
        }
    }

    class SuperCircle : Figure
    {
        // если убрать следующий метод, то будет ошибка
        // метод должен существовать или нужно сделать
        // класс абстрактным
        public override void Draw() { }
    }

}
