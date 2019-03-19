using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem7BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<char>(input.Length);
            var queue = new Queue<char>(input.Length);
           

            foreach (var ch in input)
            {
                stack.Push(ch);
                queue.Enqueue(ch);
            }
            int count = 0;
            for (int i = 0; i <= input.Length/2; i++)
            {
                char a;
                char b;
                a = stack.Pop();
                b = queue.Dequeue();
                if ((a=='{'&& b != '}')|| (a == '(' && b != ')') || (a == '[' && b != ']') || (a == ')' && b != '('))
                {
                    count++; break;
                }
            }
            if (count!=0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
