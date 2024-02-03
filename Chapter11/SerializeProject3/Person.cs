using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SerializeProject
{
    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get { return DateTime.Today.Year - Birthday.Year; } }
        public DateTime Birthday { get; set; }

        [OptionalField]
        public string City;
        public string Country;
    }
}
