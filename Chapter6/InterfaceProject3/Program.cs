using System;

namespace InterfaceProject
{
    class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person("Михиал", "Фленов");
            Object personObject;
            IPurse purse;

            personObject = person;
            purse = person;

            if (personObject is IPurse)
            {
                ((IPurse)personObject).AddMoney(100);
                Console.WriteLine("Сумма в кошельке: " + ((IPurse)personObject).Sum.ToString());
            }

            purse.DecMoney((int)50);
            Console.WriteLine("Сумма в кошельке: " + purse.Sum.ToString());
        }
    }
}
