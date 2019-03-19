using System;
using System.Linq;

namespace _2x2SquaresinMatrix
{
    class SquaresinMatrix
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse).ToArray();

            string[,] matrix = new string[sizes[0], sizes[1]];
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                string[] colElements = Console.ReadLine().
                    Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)

                    matrix[row, col] = colElements[col];
            }
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    if ((matrix[i,j]== matrix[i, j+1])&&(matrix[i+1, j]== matrix[i+1, j+1])&& (matrix[i , j] == matrix[i + 1, j + 1]))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
