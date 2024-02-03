using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqObjects.Model
{
    class Person
    {
		public int PersonID { get; set; }


		public string FirstName { get; set; }

		public string LastName { get; set; }

		public int Age { get; set; }

		public string City { get; set; }

		public List<Address> Addresses { get; set; } = new List<Address>(); 
	}
}
