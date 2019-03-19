using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var numbers = new Dictionary<int, int>();

            for (int i = 0; i < N; i++)
            {
                int Number = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(Number))
                {
                    numbers.Add(Number, 1);
                }
                else
                {
                    numbers[Number]++;
                }
            }
            foreach (var number in numbers.Where(x => x.Value % 2 == 0))
            {
                Console.WriteLine(number.Key);
            }
        }
    }
}
