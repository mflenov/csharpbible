using System;
using System.IO;
using System.Collections.Generic;

namespace SaveStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullpath = Environment.GetCommandLineArgs()[0] + ".list";
            List<string> items = new List<string>();

            if (File.Exists(fullpath))
            {
                items.AddRange(File.ReadAllLines(fullpath));
            }

            while (true)
            {
                PrintMenu();
                switch (GetNumber(4))
                {
                    case 1:
                        for(int i = 0; i < items.Count; i++)
                            Console.WriteLine(items[i]);
                        break;
                    case 2:
                        Console.WriteLine("Введите имя нового элемента");
                        items.Add(Console.ReadLine());
                        break;
                    case 3:
                        if (items.Count == 0)
                        {
                            Console.WriteLine("Удалять нечего");
                            break;
                        }
                        Console.WriteLine("Введите номер строки для удаления от 1 до " + (items.Count));
                        items.RemoveAt(GetNumber(items.Count) - 1);
                        break;
                    case 4:
                        SaveChanges(fullpath, items);
                        return;
                }
            }
        }

        static int GetNumber(int max)
        {
            int index = 0;
            while (!Int32.TryParse(Console.ReadLine(), out index) && index < 1 || index > max)
            {
            }
            return index;
        }

        static void PrintMenu()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Меню");
            Console.WriteLine("1. Отобразить содержимое файла");
            Console.WriteLine("2. Добавить элемент");
            Console.WriteLine("3. Удалить");
            Console.WriteLine("4. Выход");
            Console.WriteLine("------------------------------");
        }

        static void SaveChanges(string fullpath, List<string> items)
        {
            StreamWriter sw = File.CreateText(fullpath);
            foreach (string s in items)
            {
                sw.WriteLine(s);
            }
            sw.Close();
        }
    }
}
