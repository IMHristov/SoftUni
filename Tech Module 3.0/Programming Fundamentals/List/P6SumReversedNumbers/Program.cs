using System;
using System.Collections.Generic;
using System.Linq;

namespace P6SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                
                int result = 0;
                
                while (nums[i] > 0)
                {
                    result = result * 10 + nums[i] % 10;
                    nums[i] /= 10;
                }
                sum += result;
            }
            Console.WriteLine(sum);
           

        }
       
    }
}
