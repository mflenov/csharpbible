using System;
using System.Collections.Generic;
using System.Text;

namespace LinqObjects.Model
{
    class SampleHelper
    {
		public static List<Person> CreatePersons()
		{
			List<Person> result = new List<Person>();
			result.Add(new Person()
			{
				PersonID = 1,
				FirstName = "Иван",
				LastName = "Иванов",
				City = "Ростов",
				Age = 13
			});
			result.Add(new Person()
			{
				PersonID = 2,
				FirstName = "Иван",
				LastName = "Сидоров",
				City = "Ростов",
				Age = 78
			});
			result.Add(new Person()
			{
				PersonID = 3,
				FirstName = "Сергей",
				LastName = "Петров",
				City = "Сочи",
				Age = 78
			});
			result.Add(new Person()
			{
				PersonID = 4,
				FirstName = "Александр",
				LastName = "Пушкин",
				City = "Сочи",
				Age = 93
			});
			result.Add(new Person()
			{
				PersonID = 5,
				FirstName = "Антон",
				LastName = "Пушкин",
				City = "Сочи",
				Age = 78
			});
			return result;
		}

        public static List<Address> CreateAddreses()
		{
			yield return new Address()
			{
				AddressID = 1,
				PersonID = 1,
				Name = "This is address 1"
			};
            yield return new Address()
            {
                AddressID = 2,
                PersonID = 2,
                Name = "This is address 2"
            };
            yield return new Address()
            {
                AddressID = 3,
                PersonID = 2,
                Name = "This is address 3"
            };
        }
    }
}
