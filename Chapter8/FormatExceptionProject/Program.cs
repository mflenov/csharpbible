using System;

namespace FormatExceptionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите число");
                    int index = Convert.ToInt32(Console.ReadLine());

                    if (index > 10)
                        throw new Exception("Вы ввели слишком большое значение");

                    Console.WriteLine("Вы ввели: " + index);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели некорректное число");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Неизвестная ошибка: " + ex.Message);
                }
                finally
                {
                }
            }
        }
    }
}
