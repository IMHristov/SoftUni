using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace P1ConvertfromBase10toBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int @base = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);

            StringBuilder converted = new StringBuilder();

            while (number>0)
            {
               BigInteger reminder = number % @base;
                converted.Append(reminder);
                number /= @base;

            }
            
            string reversed = string.Concat(converted.ToString().Reverse());
            Console.WriteLine(reversed);
        }
    }
}
