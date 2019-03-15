using System;
using System.Collections.Generic;
using System.Linq;

namespace P3SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            nums.RemoveRange(command[0], nums.Count - command[0]);
            nums.RemoveRange(0, command[1]);
            if (nums.Contains(command[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
