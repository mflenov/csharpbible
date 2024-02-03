using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConversationProject
{
    class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            X = 0;
            Y = 0;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
