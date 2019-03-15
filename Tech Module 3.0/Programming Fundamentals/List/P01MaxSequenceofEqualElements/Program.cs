using System;
using System.Collections.Generic;
using System.Linq;

namespace P01MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums= Console.ReadLine().Split().Select(int.Parse).ToList();

            int count = 1;
            int countmax = 1;
            int index = 0;
            for (int i = 0; i < nums.Count-1; i++)
            {
                if (nums[i]==nums[i+1])
                {
                    count++;
                    if (countmax<count)
                    {
                        countmax = count;
                        index=i;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            for (int i = 0; i < countmax; i++)
            {
                Console.Write($"{nums[index]} ");
            }
            Console.WriteLine();
        }
    }
}
