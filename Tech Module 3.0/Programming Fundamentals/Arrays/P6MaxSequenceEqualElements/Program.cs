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
            int countMax = 0;
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                int count = 1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (countMax < count)
                {
                    countMax = count;
                    max = array[i];
                }

            }
            for (int i = 0; i < countMax; i++)
            {
                Console.Write($"{max} ");
            }
            Console.WriteLine();

            

        }
    }
}
