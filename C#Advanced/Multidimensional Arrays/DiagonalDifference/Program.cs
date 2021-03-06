﻿using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                int[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)

                .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)

                    matrix[row, col] = colElements[col];
            }

            int difference = 0;

            for (int i = 0; i < size; i++)
            {

                difference += (matrix[i, i] - matrix[i, size - i - 1]);

            }

            Console.WriteLine(Math.Abs(difference));
        }
    }
}
