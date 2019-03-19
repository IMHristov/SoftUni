using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var setOfElements = new SortedSet<string>();


            for (int i = 0; i < n; i++)
            {
                string[] Elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in Elements)
                {
                    setOfElements.Add(item);
                }
            }
      
            Console.WriteLine(string.Join(" ", setOfElements));
        }
    }
}
