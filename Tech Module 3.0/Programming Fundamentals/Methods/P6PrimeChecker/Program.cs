using System;

namespace P6PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPrime();
        }
        static void IsPrime()
        {
            long num = long.Parse(Console.ReadLine());
            bool isPrime = true;
            if (num==0||num==1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;

                    }

                }
            }
            
            Console.WriteLine(isPrime);

        }

    }
}
