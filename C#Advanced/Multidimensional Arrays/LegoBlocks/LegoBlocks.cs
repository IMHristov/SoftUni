using System;
using System.Linq;

namespace LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int totalCells = 0;
            int[][] firstMatix = new int[rows][];
            int[][] SecondMatix = new int[rows][];
            int[][] FinalMatix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                firstMatix[row] = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                totalCells += firstMatix[row].Length;   
            }
            for (int row = 0; row < rows; row++)
            {
                SecondMatix[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().Select(int.Parse).ToArray();
                totalCells += SecondMatix[row].Length;
            }

            int colLenght = firstMatix[0].Length + SecondMatix[0].Length;

            bool isFit = true;

            for (int row = 0; row < FinalMatix.Length; row++)
            {
                if (firstMatix[row].Length+ SecondMatix[row].Length!=colLenght)
                {
                    isFit = false;
                    break;
                }

            }

            if (isFit)
            {
                for (int row = 0; row <SecondMatix.Length; row++)
                {
                    Console.WriteLine($"[{String.Join(", ", firstMatix[row])}, {String.Join(", ", SecondMatix[row])}]");
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {totalCells}");
            }
        }
    }
} 
