using System;
using System.Collections.Generic;
using LinqObjects.Model;
using System.Linq;
using System.Data;

namespace LinqObjects
{
	class Program
	{
		static void Main(string[] args)
		{
			SQLStyleQuery();

			MethodStyleQuery();

			IEnumerableTest();

			IEnumerableTest2();

            MappingTest();
            
			Console.ReadLine();
		}

		static void MappingTest()
		{
            Console.WriteLine("Тест маппинга");

            List<Person> people = SampleHelper.CreatePersons();
            List<Address> addresses = SampleHelper.CreateAddreses();
			var addr_lookup = addresses.ToLookup(m => m.PersonID);

            foreach (var p in people)
            {
				p.Addresses = addr_lookup[p.PersonID].ToList();
            }
        }

        static void SQLStyleQuery()
		{
			Console.WriteLine("SQL стиль запроса поиска людей до 16 лет");
			List<Person> people = SampleHelper.CreatePersons();

			var results = from p in people
						  where p.Age < 16
						  select new { p.FirstName, p.LastName, p.Age };

            foreach (var p in results)
				Console.WriteLine(p.FirstName + " " + p.LastName + ": " + p.Age);

			PrintDiv();
		}

		static void MethodStyleQuery()
		{
			Console.WriteLine("Методы - поиск людей до 16 лет");
			List<Person> people = SampleHelper.CreatePersons();

			IEnumerable<Person> results = people.Where(r => r.Age < 16);

			foreach (var p in results)
			{
				Console.WriteLine(p.FirstName + " " + p.LastName + ": " + p.Age);
			}

			PrintDiv();
		}

		static void IEnumerableTest()
		{
			Console.WriteLine("Пример с IEnumerable");
			List<Person> people = SampleHelper.CreatePersons();

            var underage = people.Where(r => r.Age < 16).Select(m => new { FirstName = m.FirstName, LastName = m.LastName });
			foreach (var p in underage)
			{
				Console.WriteLine(p.FirstName + " " + p.LastName);
			}

            IEnumerable<Person> results = people.Where(r => r.Age < 16);

			foreach (var p in results)
			{
				Console.WriteLine(p.FirstName + " " + p.LastName + ": " + p.Age);
			}

			Console.WriteLine("Добавим значение:");
			people.Add(new Person() { FirstName = "Михаил", LastName = "Сергеев", Age = 10 });

			foreach (var p in results)
			{
				Console.WriteLine(p.FirstName + " " + p.LastName + ": " + p.Age);
			}

			PrintDiv();
		}

		static void IEnumerableTest2()
		{
			Console.WriteLine("Пример с двумя IEnumerable");
			List<Person> people = SampleHelper.CreatePersons();

			IEnumerable<Person> byAge = people.Where(r => r.Age < 16);
			IEnumerable<Person> byCityAndAge = byAge.Where(r => r.City == "Ростов");
			foreach (var p in byCityAndAge)
			{
				Console.WriteLine(p.FirstName + " " + p.LastName + ": " + p.Age);
			}

			PrintDiv();
		}

		static void TakeSample()
		{
			Console.WriteLine("Пример с Take");
			List<Person> people = SampleHelper.CreatePersons();

			IEnumerable<Person> result = people.Where(r => r.Age < 16).Skip(10).Take(10);

			PrintDiv();
		}

		static void PrintDiv()
		{
			Console.WriteLine("-----------------------------------------------");
		}
	}
}
