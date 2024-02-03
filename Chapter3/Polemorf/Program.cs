using System;
using System.Text;

namespace TestApplication
{
    // Объявление класса программы
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building();
            Building shed = new Shed();
            Building appartment = new AppartmentBuilding();
            
            //
            Console.WriteLine("building" + building.ToString());
            Console.WriteLine("shed" + shed.ToString());
            Console.WriteLine("appartment" + appartment.ToString());
            Console.ReadLine();
        }
    }
}
