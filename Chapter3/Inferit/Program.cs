using System;
using System.Text;

namespace TestApplication
{
    // Объявление класса программы
    class Program
    {
        static void Main(string[] args)
        {
            Building myBuilding = new Building();
            myBuilding.Height = 10;
            myBuilding.Width = 20;
            myBuilding.Lengthwise = 30;
            // myBuilding.GetSize(); 

            Shed myFirstShed = new Shed(10, 20, 30);
            myFirstShed.Height = 15;
            myFirstShed.GetSize();

            AppartmentBuilding appartmentBuilding = new AppartmentBuilding();
            appartmentBuilding.Height = 10;
            appartmentBuilding.Width = 20;
            appartmentBuilding.Lengthwise = 30;
            appartmentBuilding.Floors = 9;

            Console.WriteLine("Глубина: " + myFirstShed.Lengthwise);

            Console.ReadLine();
        }
    }
}
