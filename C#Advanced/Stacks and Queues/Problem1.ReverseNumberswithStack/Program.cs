using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1.ReverseNumberswithStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            var stack = new Stack<string>();

            foreach (var number in input)
            {
                stack.Push(number);
            }

            while (stack.Count!=0)
            {
                Console.Write(stack.Pop()+ " "); 
            }
        }
    }
}
