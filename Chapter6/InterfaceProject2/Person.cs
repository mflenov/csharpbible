using System;
using System.Collections.Generic;
using System.Text;
using InterfaceProject;

namespace PersonClass
{
    class Person : IPurse, ITripplePurse
    {
        int sum = 0;
        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        // метод перевода объекта в строку
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        // метод сравнения объектов
        public new bool Equals(Object obj)
        {
            Person person = (Person)obj;
            return (FirstName == person.FirstName) && 
                   (LastName == person.LastName);
        }

        public string ComparePersons(Person person)
        {
            bool equalParams = Equals(person);
            bool fullEqual = base.Equals(person);

            if (fullEqual)
                return "Абсолютно одинаковые объекты";
            if (equalParams)
                return "Одинаковые свойства объектов";
            
            return "Объекты разные";
        }

        void IPurse.AddMoney(int sum)
        {
            Sum += sum;
        }

        public int DecMoney(int sum)
        {
            Sum -= sum;
            return Sum;
        }

        public void AddMoney(int sum)
        {
            Sum += sum * 2;
        }
        // Реализация ITripplePurse
        void ITripplePurse.AddMoney(int sum)
        {
            Sum += sum * 3;
        }

        int ITripplePurse.DecMoney(int sum)
        {
            Sum -= sum * 3;
            return Sum;
        }
    }
}
