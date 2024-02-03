using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerializeProject
{
    [Serializable]
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get { return DateTime.Today.Year - Birthday.Year; } }
        public DateTime Birthday { get; set; }

        public string City;
        public string Country;
    }
}
