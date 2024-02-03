using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateProject
{
    public static class Class1
    {
        static void Main()
        {
            TemplateTest<int> testarray = new TemplateTest<int>();
            
            testarray.Add(10);
            testarray.Add(1);
            testarray.Add(3);
            testarray.Add(14);

            for (int i = 0; i < testarray.Count(); i++)
            {
                Console.WriteLine(testarray.Get(i));
            }
            Console.ReadLine();
        }
    }

    public class TemplateTest<T> 
    {
        T[] array = new T[10];
        int index = 0;

        public bool Add(T value)
        {
            if (index >= 10)
                return false;

            array[index++] = value;
            return true;
        }

        public T Get(int index)
        {
            if (index < this.index && index >=0 )
                return array[index];
            else
                return default(T);
        }

        public int Count()
        {
            return index;
        }
    }
}
