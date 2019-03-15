using System;
using System.Linq;

namespace P3FoldandSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array1 = new int[inputArray.Length / 2];
            int[] array2 = new int[inputArray.Length / 2];
            int[] sum= new int[inputArray.Length / 2];
            for (int i = 0; i < inputArray.Length/4; i++)
           {
               array1[i] = inputArray[inputArray.Length / 4-1-i];
           }
           for (int i = 0; i < inputArray.Length / 4; i++)
           {
               array1[i+ inputArray.Length / 4] = inputArray[inputArray.Length  -1- i];
            }
           //Console.WriteLine(string.Join(" ", array1));

            for (int i = 0; i < inputArray.Length / 2; i++)
            {
                array2[i] = inputArray[inputArray.Length / 4 + i];
            }
            // Console.WriteLine(string.Join(" ", array2));

            for (int i = 0; i <= sum.Length-1; i++)
            {
                sum[i] = array1[i] + array2[i];
            }
            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
