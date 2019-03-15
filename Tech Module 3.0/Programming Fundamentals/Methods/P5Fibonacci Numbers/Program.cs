using System;

namespace P5Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            fib();   
        }
        static void fib()
        {
            long n = long.Parse(Console.ReadLine());
            long i = 1;
            long sum1 = 1;
            long sum2 = 1;
            long fib = 0;
            if (n == 0 || n == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                do
                {
                    fib = sum1 + sum2;
                    sum1 = sum2;
                    sum2 = fib;
                    i++;
                } while (i < n);
                Console.WriteLine(fib);
            }

        }
    }
}
