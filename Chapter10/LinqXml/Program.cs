using System;
using System.Xml.Linq;
using System.Linq;

namespace LinqXml
{
	class Program
	{
		static void Main(string[] args)
		{
			test1();
			test2();
			Console.ReadLine();
		}

		static void test1()
		{
			Console.WriteLine("Тест 1");
			XElement root = XElement.Load(@"person.xml");
			foreach (var item in root.Elements("person").Where(m => Int32.Parse(m.Attribute("Age").Value) < 16))
			{
				Console.WriteLine(item.Attribute("FirstName").Value);
			}
		}

		static void test2()
		{
			Console.WriteLine("Тест 2");
			XElement root = XElement.Load(@"person.xml");
			foreach (var item in root.Elements("person").Where(m => m.Elements("address").Elements("city").First().Value == "Москва"))
			{
				Console.WriteLine(item.Attribute("FirstName").Value);
			}
		}
	}
}
