using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[10][];
            jaggedArray[1] = new int[5];
            jaggedArray[2] = new int[2];
            jaggedArray[4] = new int[20];


            for (int i = 0; i < jaggedArray.Length; i++)
                jaggedArray[i] = new int[i];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = j;
                    Console.Write(jaggedArray[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
