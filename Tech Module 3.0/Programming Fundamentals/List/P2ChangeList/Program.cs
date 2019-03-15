using System;
using System.Collections.Generic;
using System.Linq;

namespace P2ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool isTrue = true;
          
            while (isTrue)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                int element = 0;
                int postion = 0;
                switch (command[0])
                {
                    case "Odd":
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] % 2 != 0)
                            {
                                Console.Write($"{nums[i]} ");   
                            }
                        }
                        Console.WriteLine();
                        isTrue = false;
                        break;
                    case "Even":
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] % 2 == 0)
                            {
                                Console.Write($"{nums[i]} ");
                            }
                        }
                        Console.WriteLine();
                        isTrue = false;
                        break;
                    case "Delete":
                        element = int.Parse(command[1]);
                        nums.RemoveAll(y => y == element);

                        break;
                    case "Insert":
                        element = int.Parse(command[1]);
                        postion = int.Parse(command[2]);
                        nums.Insert(postion,element);

                        break;
                }
            }
        }
    }
}
