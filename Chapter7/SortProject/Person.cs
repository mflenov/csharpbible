using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using ArrayListProject;

namespace PersonClass
{
    public class Person : IEnumerable, IComparer, IComparable
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        #region Унаследованные методы от Object

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

        #endregion

        #region Дети

        ArrayList Children = new ArrayList();

        public void AddChild(string firstName, string lastName)
        {
            Children.Add(new Person(firstName, lastName));
        }

        public void DeleteChild(int index)
        {
            Children.RemoveAt(index);
        }

        public Person GetChild(int index)
        {        
            return (Person)Children[index];
        }

        public Person this[int index]
        {
            get { return (Person)Children[index]; }
        }

        public int GetChildrenNumber()
        {
            return Children.Count;
        }

        public void SortChildren()
        {
            Children.Sort(new SortTest());
        }

        int IComparer.Compare(Object person1, Object person2)
        {
            string personName1 = ((Person)person1).ToString();
            string personName2 = ((Person)person2).ToString();

            return personName1.CompareTo(personName2);
        }

        public int CompareTo(object obj)
        {
            Person person = (Person)obj;

            string personName1 = ToString();
            string personName2 = person.ToString();

            return personName1.CompareTo(personName2.ToString());
        }

        #endregion

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            //return Children.GetEnumerator();
            return new PersonEnumerator(this);
        }

        #endregion
    }

    class SortTest : IComparer
    {
        int IComparer.Compare(Object person1, Object person2)
        {
            string personName1 = ((Person)person1).ToString();
            string personName2 = ((Person)person2).ToString();

            return personName1.CompareTo(personName2);
        }
    }
}
