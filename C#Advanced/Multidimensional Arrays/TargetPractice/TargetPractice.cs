using System;
using System.Linq;

namespace TargetPractice
{
    class TargetPractice
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse).ToArray();

            char[,] matrix = new char[sizes[0], sizes[1]];
            string snake = Console.ReadLine();

            int[] Shoot = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse).ToArray();
            int shootRow = Shoot[0];
            int shootColumn = Shoot[1];
            int shootRadius = Shoot[2];

            bool isLeft = true;
            int counter = 0;
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                if (isLeft)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (counter > snake.Length - 1)
                        {
                            counter = 0;
                        }
                        matrix[row, col] = snake[counter++];
                    }

                    isLeft = false;

                }
                else
                {
                    for (int col = 0; col <= matrix.GetLength(1) - 1; col++)
                    {
                        if (counter > snake.Length - 1)
                        {
                            counter = 0;
                        }
                        matrix[row, col] = snake[counter++];
                    }
                    isLeft = true;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if ((row - shootRow) *
                        (row - shootRow) +
                        (col - shootColumn) *
                        (col - shootColumn)
                        <= shootRadius * shootRadius)
                    {
                        matrix[row, col] = ' ';
                    }
                }
               
            }

            for (int row =matrix.GetLength(0) - 1; row >= 0; row--)
            {
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    
                    if (matrix[row,col]==' ')
                    {
                        for (int i = 1; i <= row; i++)
                        {
                            
                            if (matrix[row - i, col] != ' ')
                            {
                               matrix[row, col] = matrix[row - i, col];
                               matrix[row - i, col] = ' ';
                                break;
                            }
                        }
                    }
                }
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
