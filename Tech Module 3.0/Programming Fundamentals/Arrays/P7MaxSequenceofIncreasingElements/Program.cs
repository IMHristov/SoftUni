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
            int end = 0;
            int j;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int count = 0;    

                for ( j = i + 1; j < array.Length; j++)
                {
                    if (array[i]<array[j])
                    {
                        count++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                   
                }
                if (count> countМax)
                {
                    countМax = count;
                    end = j;
                    
                    
                }
             

            }
            for (int i = end-1- countМax; i < end; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
