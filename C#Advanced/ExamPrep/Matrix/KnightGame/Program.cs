using System;

namespace KnightGame
{
    class KnightGame
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];

            for (int i = 0; i < matrix.Length; i++)
            {
                char[] inputRow = Console.ReadLine().ToCharArray();
                matrix[i] = new char[n];
                matrix[i] = inputRow;
            }

            int currentKnightsInDanger = 0;
            int maxKnightsInDanger = -1;
            int mostDangerousKnightRow = 0;
            int mostDangerousKnightCol = 0;
            int count = 0;

            while (true)
            {
                for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                    {
                        if (matrix[rowIndex][colIndex] == 'K')
                        {
                            //Up and left
                            if (isInTheMatrix(rowIndex - 2, colIndex - 1, matrix))
                            {
                                if (matrix[rowIndex - 2][colIndex - 1] == 'K')
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            //Up and right
                            if (isInTheMatrix(rowIndex - 2, colIndex + 1, matrix))
                            {
                                if (matrix[rowIndex - 2][colIndex + 1] == 'K')
                                {
                                    currentKnightsInDanger++;
                                }
                            }
                            //Down and right
                            if (isInTheMatrix(rowIndex + 2, colIndex + 1, matrix))
                            {
                                if (matrix[rowIndex + 2][colIndex + 1] == 'K')
                                {
                                    currentKnightsInDanger++;
                                }
                            }
                            //Down and left
                            if (isInTheMatrix(rowIndex + 2, colIndex - 1, matrix))
                            {
                                if (matrix[rowIndex + 2][colIndex - 1] == 'K')
                                {
                                    currentKnightsInDanger++;
                                }
                            }
                            //left and down
                            if (isInTheMatrix(rowIndex + 1, colIndex - 2, matrix))
                            {
                                if (matrix[rowIndex + 1][colIndex - 2] == 'K')
                                {
                                    currentKnightsInDanger++;
                                }
                            }
                            //left and up
                            if (isInTheMatrix(rowIndex - 1, colIndex - 2, matrix))
                            {
                                if (matrix[rowIndex - 1][colIndex - 2] == 'K')
                                {
                                    currentKnightsInDanger++;
                                }
                            }
                            //Right and up
                            if (isInTheMatrix(rowIndex - 1, colIndex + 2, matrix))
                            {
                                if (matrix[rowIndex - 1][colIndex + 2] == 'K')
                                {
                                    currentKnightsInDanger++;
                                }
                            }
                            //Right and down
                            if (isInTheMatrix(rowIndex + 1, colIndex + 2, matrix))
                            {
                                if (matrix[rowIndex + 1][colIndex + 2] == 'K')
                                {
                                    currentKnightsInDanger++;
                                }
                            }
                        }
                        if (currentKnightsInDanger > maxKnightsInDanger)
                        {
                            maxKnightsInDanger = currentKnightsInDanger;
                            mostDangerousKnightCol = colIndex;
                            mostDangerousKnightRow = rowIndex;
                        }
                        currentKnightsInDanger = 0;

                    }
                }
                if (maxKnightsInDanger != 0)
                {
                    matrix[mostDangerousKnightRow][mostDangerousKnightCol] = 'O';
                    count++;
                    maxKnightsInDanger = 0;
                }
                else
                {
                    Console.WriteLine(count);
                    return;
                }

            }
        }

        private static bool isInTheMatrix(int row, int col, char[][] matrix)
        {
            if (0 <= row && row < matrix.Length && 0 <= col && col < matrix[row].Length)
            {
                return true;
            }
            return false;

        }
    }
}
