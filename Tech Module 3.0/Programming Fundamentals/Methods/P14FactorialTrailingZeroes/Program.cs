using System;
using System.Numerics;

namespace _14FactZero
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
            for (int i = 1; i <= n; i++)
            {

                sum *= (BigInteger)i;
            }
            int a = 0;
            int count = 0;
            while (sum%10==0)
            {
                sum=sum / 10;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
