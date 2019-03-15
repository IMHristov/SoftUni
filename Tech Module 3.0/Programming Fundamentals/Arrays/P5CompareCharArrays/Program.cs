using System;
using System.Linq;

namespace _5CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            

            bool isFirst = true;



            int min = Math.Min(arr1.Length, arr2.Length);
            if (arr2.Length<arr1.Length)
            {
                for (int i = 0; i < min-1; i++)
                {
                    if (arr1[i]== arr2[i])
                    {
                        isFirst= false;
                    }
                    else
                    {
                        isFirst = true;
                    }
                }
            }
            

            for (int i = 0; i < min; i++)
            {
                int index2 = (int) arr2[i];
                int index1 = (int)arr1[i];

                if (index2<index1)
                {
                   isFirst= false;
                }

            }
           
            if (isFirst)
            {
                Console.WriteLine(string.Join("", arr1));
                Console.WriteLine(string.Join("", arr2));
            }
            else
            {
                Console.WriteLine(string.Join("", arr2));
                Console.WriteLine(string.Join("", arr1));
            }
           

        }
    }
}
