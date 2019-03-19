using System;
using System.Linq;

namespace MatrixofPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse).ToArray();

            string[,] matrix = new string[sizes[0], sizes[1]];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = alphabet[i].ToString() + alphabet[i+j].ToString() + alphabet[i].ToString();
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
