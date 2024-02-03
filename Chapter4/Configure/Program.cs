using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Матрица в тебе";

   // меняю цвет текста на зеленый
   Console.ForegroundColor = ConsoleColor.Green;
   // следующие две строки текста будут зелеными
   Console.WriteLine("Здравствуй, Нео Киану Ривз.");
   Console.WriteLine("Тебя приветствует матрица!");

   // меняю цвет текста на красный
   Console.ForegroundColor = ConsoleColor.Red;
   // следующие две строки текста будут красными
   Console.WriteLine("Здравствуй, Тринити.");
   Console.WriteLine("Признавайся, где мМорфеус!");

            Console.ReadLine();
        }
    }
}
