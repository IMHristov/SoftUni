using System;
using System.Linq;
namespace P1LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstString = Console.ReadLine().Split(' ').ToArray();
            string[] secondString = Console.ReadLine().Split(' ').ToArray();
            int countLeft = 0;
            int countRight = 0;
            for (int i = 0; i <=firstString.Length-1&& i <= secondString.Length - 1; i++)
            {
                if (firstString[i] == secondString[i])
                {
                    countLeft++;
                    
                }
                else
                {
                    if (countLeft!= 0)
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i <= firstString.Length - 1 && i <= secondString.Length - 1; i++)
            {
                if (firstString[firstString.Length - 1-i]== secondString[secondString.Length - 1 - i])
                {
                    countRight++;
                }
                else
                {
                    if (countRight != 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(Math.Max(countRight, countLeft));
        }
    }
}
