using System;
using System.Collections;

namespace QueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("Первый");
            queue.Enqueue("Второй");
            queue.Enqueue("Третий");
            queue.Enqueue("Четвертый");
            queue.Enqueue("Пятый");

            for (; queue.Count > 0;)
            {
                String s = queue.Dequeue().ToString();
                Console.WriteLine(s);
            }

            /*
            do
            {
                String s = queue.Dequeue().ToString();
                Console.WriteLine(s);
            } while (queue.Count > 0);
            */

            Console.ReadLine();
        }
    }
}
