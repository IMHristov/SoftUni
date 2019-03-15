using System;
using System.Collections.Generic;
using System.Linq;

namespace P5ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isTrue=true;
            while (isTrue)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                int index = 0;
                int element = 0;

                switch(command[0])
                {
                    case "print":      
                        Console.WriteLine("[{0}]",string.Join(", ",nums));
                        isTrue = false;
                        break;
                    case "add":
                        index = int.Parse(command[1]);
                        element = int.Parse(command[2]);
                        nums.Insert(index,element);
                        break;
                    case "addMany":
                        index = int.Parse(command[1]);
                        for (int i = 2; i < command.Length; i++)
                        {
                           nums.Insert(index, int.Parse(command[i]));
                           index++;
                        }
                        break;
                    case "contains":
                        element = int.Parse(command[1]);
                        index = nums.IndexOf(element);
                        Console.WriteLine(index);
                        break;
                    case "remove":
                         index= int.Parse(command[1]);
                        nums.RemoveAt(index);
                        break;
                    case "shift":
                        int CountOfShifts = int.Parse(command[1]);
                        for (int i = 0; i <  CountOfShifts%nums.Count; i++)
                        {
                            int current = nums[0];
                            nums.RemoveAt(0);
                            nums.Add(current);
                        }
                        break;
                    case "sumPairs":
                        for (int i = 0; i < nums.Count-1; i++)
                        {
                            nums[i] += nums[i + 1];
                            nums.RemoveAt(i+1);
                        }
                        break;

                }
                    
            }
        }
    }
}
