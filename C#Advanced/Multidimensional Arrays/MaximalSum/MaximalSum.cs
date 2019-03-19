using System;
using System.Linq;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse).ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];
        
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                int[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)

                .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)

                    matrix[row, col] = colElements[col];
            }
            int sum = int.MinValue;
            int maxSum = int.MinValue;
            int maxRol = 0;
            int maxCol = 0;


            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                          matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                          matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        maxRol = i;
                        maxCol = j;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int i = maxRol; i < maxRol+3; i++)
            {
                for (int j = maxCol; j < maxCol+3; j++)
                {
                    Console.Write(matrix[i,j]+ " ");
                }
                Console.WriteLine();
            }

        }
    }
}
