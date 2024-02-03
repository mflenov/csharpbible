using System;

namespace EnumTest
{
    class Program
    {
        enum MyColors
        {
            Red = 100,
            Green = 200,
            Blue = 300
        };


        [Flags]
        public enum Weekdays { 
            Monday    = 0b_0000_0001, 
            Tuesday   = 0b_0000_0010, 
            Wednesday = 0b_0000_0100, 
            Thursday  = 0b_0000_1000,
            Friday    = 0b_0001_0000,
            Saturday  = 0b_0010_0000,
            Sunday    = 0b_0100_0000
        };

        static void Main(string[] args)
        {
            Weekdays weekend = Weekdays.Saturday | Weekdays.Sunday;
            Console.WriteLine("Weekend: " + weekend);

            weekend = (int)Weekdays.Saturday + Weekdays.Sunday;
            Console.WriteLine("Weekend: " + weekend);

            weekend = (int)Weekdays.Saturday + (int)Weekdays.Sunday + Weekdays.Saturday;
            Console.WriteLine("Weekend: " + weekend);

            weekend = Weekdays.Saturday | Weekdays.Saturday | Weekdays.Sunday;
            Console.WriteLine("Weekend: " + weekend);

            Console.WriteLine("Понедельние: " + ((weekend & Weekdays.Monday) != 0) );
            Console.WriteLine("Воскресенье: " + ((weekend & Weekdays.Sunday) != 0));

            Console.WriteLine("Enum Names");

            foreach (string str in Enum.GetNames(typeof(MyColors)))
                Console.WriteLine(str);

            Console.WriteLine("Enum Values");
            foreach (int i in Enum.GetValues(typeof(MyColors)))
                Console.WriteLine(i);

            Console.WriteLine("Введите имя цвета");
            string currentColor = Console.ReadLine();
            MyColors myColor1 = (MyColors)Enum.Parse(typeof(MyColors), currentColor, true);
            Console.WriteLine("Вы выбрали " + myColor1 + " - " +  (int)myColor1);

            object myColorObject;
            if (Enum.TryParse(typeof(MyColors), currentColor, true, out myColorObject))
            {
                myColor1 = (MyColors)myColorObject;
                Console.WriteLine("Вы выбрали " + myColor1 + " - " + (int)myColor1);
            }

            Console.WriteLine("Введите имя значение цвета");
            currentColor = Console.ReadLine();
            int colorIntValue = Int32.Parse(currentColor);
            MyColors myColor2 = (MyColors)colorIntValue;
            Console.WriteLine("Вы выбрали " + myColor2 + " - " + (int)myColor2);

            Console.ReadLine();
        }
    }
}
