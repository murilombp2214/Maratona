using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//1110
namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            string numberStr;
            while ((numberStr = Console.ReadLine()) != "0")
            {
                queue.Clear();
                int number = int.Parse(numberStr);

                for (int i = 1; i <= number; ++i)
                    queue.Enqueue(i);

                ProcesseCartas(queue);
            }

        }

        private static void ProcesseCartas(Queue<int> queue)
        {
            Queue<int> discarded = new Queue<int>();
            int end_rem = 0;
            while (queue.Any())
            {
                discarded.Enqueue(queue.Dequeue());

                if (queue.Any())
                {
                    if (queue.Count == 2)
                    {
                        end_rem = queue.Dequeue();
                    }

                    queue.Enqueue(queue.Dequeue());
                }

            }

            Console.Write("Discarded cards:");
            while (discarded.Any())
            {
                Console.Write(" ");
                Console.Write(discarded.Dequeue());
                if (discarded.Count > 0)
                    Console.Write(",");
               
            }
            Console.WriteLine();
            Console.WriteLine("Remaining card: {0}", end_rem);
        }
    }
}
