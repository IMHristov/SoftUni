using System;

namespace P13GameofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count =0;
            int a = 0;
            int b = 0;

            for (int i = N; i <= M; i++)
            {
                for (int j = N; j <= M; j++)
                {
                    count++;
                    if (i+j== magicNumber)
                    {
                        a = i;
                        b = j;
                    }
                }
            }
            if (a!=0)
            {
                Console.WriteLine($"Number found! {a} + {b} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
        }
    }
}
