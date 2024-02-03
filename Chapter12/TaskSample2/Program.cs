using System;
using System.Threading.Tasks;

namespace TaskSample
{
    class Program
    {
        static void Main(string[] args)
        {
			// создать класс
			AsyncSampleClass c = new AsyncSampleClass();

			// вызвать метод загрузки файла из интернета
			Task<string> asyncContent = c.AccessTheWebAsync();

			// показать состояние задачи
			Console.WriteLine("Состояние: " + asyncContent.Status);

			// дождаться загрузки выполнения
			string webContent = asyncContent.ConfigureAwait(false).GetAwaiter().GetResult();

			// еще раз отобразить статус
			Console.WriteLine("Состояние: " + asyncContent.Status);

			// отобразить содержимое файла
			Console.WriteLine("Результат с сайта:");
			Console.WriteLine(webContent);
			Console.ReadLine();

		}
	}
}
