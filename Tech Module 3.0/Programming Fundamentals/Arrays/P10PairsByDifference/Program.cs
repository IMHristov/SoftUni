using System;
using System.Linq;

namespace P10PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (Math.Abs(array[i]-array[j])==Math.Abs(diff))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

        }
    }
}
