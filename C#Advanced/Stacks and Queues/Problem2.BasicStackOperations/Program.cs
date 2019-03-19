using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2.BasicStackOperations
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
            var stack = new Stack<int>();
            foreach (var number in inputStack)
            {
                stack.Push(number);
            }
            if (N <= S)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = 0; i < S; i++)
                {
                    stack.Pop();
                }
                if (stack.Contains(X))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            
        }
    }
}
