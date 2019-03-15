using System;
using System.Collections.Generic;
using System.Linq;

namespace P7BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bombNumber = command[0];
            int bombLenght = command[1];

            while (nums.Contains(bombNumber))
              {
              int index= nums.IndexOf(bombNumber);
                int start = index- bombLenght;
                int end = start+ 2* bombLenght;
                if (index - bombLenght < 0)
                {
                    start = 0;
                }
                if(end - 1 + 2 * bombLenght > nums.Count)
                {
                    end = nums.Count-1;
                }
                int range = end - start + 1;
                nums.RemoveRange(start,range);
              }
            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }
    }
}
