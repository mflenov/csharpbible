using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Это число {0}\nДругое число {1}\nИ снова первое число {0}", 1, 2);

			Console.WriteLine("");

			Console.WriteLine("Это число {0}\nДругое число {1}\nИ снова первое число {0}", new Object[] { 3, 4 });

			Console.WriteLine("Хлеб стоит = {0:c}", 25);
			Console.WriteLine("Хлеб стоит = {0:n}", 25000);

			Console.ReadLine();
		}
	}
}
