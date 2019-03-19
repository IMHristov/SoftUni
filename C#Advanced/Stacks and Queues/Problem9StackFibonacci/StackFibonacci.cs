using System;
using System.Collections.Generic;

namespace Problem9StackFibonacci
{
    class StackFibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<long>();
            if (n==0)
            {
                Console.WriteLine("0");
            }
            else if (n==1)
            {
                Console.WriteLine("1");
            }
            else
            {
                long a = 0;
                long b = 0;
                stack.Push(0);
                stack.Push(1);

                for (int i = 0; i < n-1; i++)
                {
                    a = stack.Pop();
                    b = a + stack.Peek();
                    stack.Push(a);
                    stack.Push(b);
                }
                Console.WriteLine(stack.Peek());
            }
        }
    }
}
