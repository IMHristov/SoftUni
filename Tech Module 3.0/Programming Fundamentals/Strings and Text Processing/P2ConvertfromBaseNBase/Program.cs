using System;
using System.Numerics;

namespace Problem2ConvertfromBaseNBase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int @base = int.Parse(input[0]);
            string number =input[1];
            int pow = 0;
            BigInteger sum = 0;
            for (int i = number.Length-1; i >=0; i--)
            {
                char currentChar = number[i];
                int num = int.Parse(currentChar.ToString());
                BigInteger currentsum = num * BigInteger.Pow(@base, pow);
                pow++;
                sum += currentsum;
            }

            Console.WriteLine(sum);
            
        }
    }
}
