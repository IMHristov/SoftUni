using System;
using System.Linq;

namespace P11EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sumLeft = 0;
            int sumRight =0;
            bool equal = false;
            int position = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sumLeft += array[j];
                }
                for (int k = array.Length-1; k > i; k--)
                {
                    sumRight += array[k];
                }
                //Console.WriteLine($"{sumleft}    {sumright}");
                if (sumLeft == sumRight)
                {
                    equal = true;
                    position = i;
                }
                sumLeft = sumRight = 0;
            }

            if (equal)
            {
                Console.WriteLine(position);
            }
            else
            {
                Console.WriteLine("no");
            }
            

        }
    }
}
