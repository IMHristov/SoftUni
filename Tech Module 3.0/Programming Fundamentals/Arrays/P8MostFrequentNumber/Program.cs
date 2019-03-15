using System;
using System.Linq;

namespace P8MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max = array[0];
            int countМax = 0;
            for (int i = 0; i <array.Length-1; i++)
            {
                int count = 0;
                
                for (int j = i+1; j <array.Length ; j++)
                {
                    if (array[i]== array[j])
                    {
                        count++;
                    }
                }
                if (countМax < count)
                {
                    countМax = count;
                    max = array[i];
                }

            }
            Console.WriteLine(max);

        }
    }
}
