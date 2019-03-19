using System;
using System.Linq;

namespace Rubik_sMatrix
{
    class RubiksMatrix
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse).ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];
            int count = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = count++;
                }

            }

            int totalcomand = int.Parse(Console.ReadLine());
            for (int i = 0; i < totalcomand; i++)
            {
                string[] command = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray() ;
                int RolColIndex = int.Parse(command[0]);
                int moves = int.Parse(command[2]);
                string direction = command[1];

                if (direction=="down")
                {
                    MoveDown(matrix, RolColIndex, moves % matrix.GetLength(0));
                }
                if (direction == "up")
                {
                    MoveUp(matrix, RolColIndex, moves % matrix.GetLength(0));
                }
                if (direction=="left")
                {
                    MoveLeft(matrix, RolColIndex, moves % matrix.GetLength(1));
                }
                if (direction == "right")
                {
                    MoveRight(matrix, RolColIndex, moves % matrix.GetLength(1));
                }

            }

            int counter = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col]==counter)
                    {
                        Console.WriteLine("No swap required");
                        counter++;
                    }
                    else
                    {
                        reArange(matrix, row, col, counter);
                        counter++;
                    }
                }
            }

            
        }

        private static void reArange(int[,] matrix, int row, int col, int counter)
        {
            for (int targetRow = 0; targetRow < matrix.GetLength(0); targetRow++)
            {
                for (int targetCol = 0; targetCol < matrix.GetLength(1); targetCol++)
                {
                    if (matrix[targetRow,targetCol]== counter)
                    {
                        matrix[targetRow, targetCol] = matrix[row, col];
                        matrix[row, col] = counter;
                        Console.WriteLine($"Swap ({row}, {col}) with ({targetRow}, {targetCol})");
                        
                        return;
                    }
                }
            }
        }

        private static void MoveRight(int[,] matrix, int rol, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int lastElement = matrix[rol, matrix.GetLength(1) - 1];
                for (int col = matrix.GetLength(1) - 1; col > 0; col--)
                {
                    matrix[rol, col] = matrix[rol, col - 1];
                }
                matrix[rol, 0] = lastElement;
            }
            
        }

        private static void MoveLeft(int[,] matrix, int rol, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int firstElement = matrix[rol, 0 ];
                
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    matrix[rol, col] = matrix[rol, col+1];
                }
                matrix[rol, matrix.GetLength(1)-1] = firstElement;
            }
        }

        private static void MoveUp(int[,] matrix, int col , int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int firstElement = matrix[0, col];

                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    matrix[row, col] = matrix[row + 1, col];
                }
                matrix[matrix.GetLength(0)-1, col] = firstElement;
            }
        }

        private static void MoveDown(int[,] matrix, int col, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int lastElement = matrix[matrix.GetLength(0) - 1, col];
                
                for (int row = matrix.GetLength(0) - 1; row > 0; row--)
                {
                    matrix[row, col] = matrix[row - 1, col];
                }
                matrix[0, col] = lastElement;
            }

        }
    }
}
