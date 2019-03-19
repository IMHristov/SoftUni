using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem4.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = input[0];
            int S = input[1];
            int X = input[2];

            int[] inputStack = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var queue = new Queue<int>();
            foreach (var number in inputStack)
            {
                queue.Enqueue(number);
            }
            if (N <= S)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = 0; i < S; i++)
                {
                    queue.Dequeue();
                }
                if (queue.Contains(X))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
