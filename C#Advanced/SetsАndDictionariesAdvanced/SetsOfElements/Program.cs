using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        public static void Main()
        {
            var lengths = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var firstSet = new HashSet<int>();
            for (int i = 0; i < lengths[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            var secondSet = new HashSet<int>();
            for (int i = 0; i < lengths[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(string.Join(" ", firstSet.Intersect(secondSet)));
        }
    }
}
