using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    class Program
    {
        static int[] array = { 10, 98, 78, 4, 54, 25, 41, 30, 87, 60, 84, 6, 12 };

        static void Main(string[] args)
        {
            sort(0, array.Length-1);
            foreach (int i in array)
                Console.WriteLine(i);
            Console.ReadLine();
        }

    static void sort(int left, int right)
    {
        int i = left;
        int j = right;
        int x = array[(left + right) / 2];
            
        do
        {
            while (array[i] < x) i++;
            while (array[j] > x) j--;
            if (i <= j)
            {
                int y = array[i];
                array[i] = array[j];
                array[j] = y;
                i++;
                j--;
            }
        } while (i < j);

        foreach (int k in array)
            Console.Write(k.ToString() + ',');
        Console.WriteLine(" ");

        if (left < j)
            sort(left, j);
        if (left < right)
            sort(i, right);
    }
    }
}
