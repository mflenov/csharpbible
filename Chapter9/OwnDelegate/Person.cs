using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace PersonClass
{

    public class Person : IEnumerable
    {
        public delegate void NameChanged(Object sender, NameChangedEvent args);

        public event NameChanged FirstNameChanged;
        public event NameChanged LastNameChanged;

        public event EventHandler AgeChanged;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        #region Свойства

        string firstName;
        public string FirstName 
        {
            get { return firstName; }
            set 
            { 
                if (FirstNameChanged != null)
                    FirstNameChanged(this, 
                        new NameChangedEvent(value, 
                            NameChangedEvent.NameChangingKind.FirstName)
                            );
                firstName = value;
            }
        }

        string lastName;
        public string LastName 
        {
            get { return lastName; }
            set 
            {
                if (LastNameChanged != null)
                {
                    NameChangedEvent changeevent = new NameChangedEvent(value, NameChangedEvent.NameChangingKind.FirstName);
                    LastNameChanged(this, changeevent);
                    if (changeevent.Canceled)
                        return;
                }

                lastName = value;
            }
        }

        int age = 0;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                    throw new Exception("Возраст не может быть отрицательным");
                age = value;

                if (AgeChanged != null)
                    AgeChanged(this, new EventArgs());
            }
        }

        #endregion

        #region Унаследованные методы от Object

        // метод перевода объекта в строку
        public new string ToString()
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
        
        #endregion

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return Children.GetEnumerator();
        }

        #endregion
    }
}
