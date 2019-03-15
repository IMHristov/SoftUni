using System;
using System.Numerics;

namespace P13Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Factorial(n);
        }
        static void Factorial(int n)

        {
            BigInteger sum = 1;
            for (int i = 1; i <=n; i++)
            {
                
                sum *= (BigInteger)i;
            }
            Console.WriteLine(sum);
        }
    }
}
