using System;
using System.Collections.Generic;

namespace Problem5.CalculateSequencewithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<long>();
            var queue1 = new Queue<long>();
            long N = long.Parse(Console.ReadLine());
            long current = N;
            queue.Enqueue(current);
            while (queue.Count<=50)
            {               
                queue.Enqueue(current+1);
                queue1.Enqueue(current + 1);
                if (queue.Count == 50)
                {
                    break;
                }
                queue.Enqueue(2*current+1);
                queue1.Enqueue(2 * current + 1);

                queue.Enqueue(current + 2);
                queue1.Enqueue(current + 2);
                
                current = queue1.Peek();
                queue1.Dequeue();
            }
            
            while (queue.Count != 0)
            {
               Console.Write(queue.Dequeue() + " ");
            }
        }
    }
}
