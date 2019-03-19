using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3.Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int command = 0;
            var stack = new Stack<int>();
            for (int i = 0; i <N; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                command = input[0];
                if (command==1)
                {
                    stack.Push(input[1]);
                }
                if (command == 2)
                {
                    stack.Pop();
                }
                if (command == 3)
                {
                    Console.WriteLine(stack.Max());
                }
            }
        }
    }
}
