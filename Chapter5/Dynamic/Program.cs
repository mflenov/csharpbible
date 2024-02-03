using System;

namespace TupleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic s = "test";
            var sum = s + 3;
            System.Console.WriteLine(sum);

            dynamic test = new Test();
            test.Print(1);
            test.Start();
        }
	}

    class Test
    {
        public void Print()
        {
            Console.WriteLine("Test");
        }
    }
}
