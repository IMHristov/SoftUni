using System;
using System.Collections.Generic;
using System.Linq;

namespace _02SneakingFebruary
{
    class Sneaking
    {
        static void Main(string[] args)
        {
            int samRow = 0;
            int samCol = 0;

            int numberOfRows = int.Parse(Console.ReadLine());

            char[][] gameArea = new char[numberOfRows][];

            for (int row = 0; row < gameArea.Length; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                if (input.Contains('S'))
                {
                    samRow = row;
                    samCol = Array.IndexOf(input, 'S');
                }
                gameArea[row] = input;
            }

            char[] commands = Console.ReadLine().ToCharArray();

            for (int i = 0; i < commands.Length; i++)
            {
                MoveEnemy(gameArea);

                if (gameArea[samRow].Contains('b') && samCol > Array.IndexOf(gameArea[samRow], 'b'))
                {
                    gameArea[samRow][samCol] = 'X';
                    Console.WriteLine($"Sam died at {samRow}, {samCol}");
                    break;
                }
                else if (gameArea[samRow].Contains('d') && samCol < Array.IndexOf(gameArea[samRow], 'd'))
                {
                    gameArea[samRow][samCol] = 'X';
                    Console.WriteLine($"Sam died at {samRow}, {samCol}");
                    break;
                }

                MoveSam(gameArea, commands[i], ref samRow, ref samCol);

                if (gameArea[samRow].Contains('N'))
                {
                    int nikoladze = Array.IndexOf(gameArea[samRow], 'N');
                    gameArea[samRow][nikoladze] = 'X';
                    Console.WriteLine("Nikoladze killed!");
                    break;
                }

            }
            PrintArea(gameArea);
        }

        private static void MoveSam(char[][] jaggedArray, char commands, ref int samRow, ref int samCol)
        {
            switch (commands)
            {
                case 'U':
                    jaggedArray[samRow][samCol] = '.';
                    samRow--;
                    jaggedArray[samRow][samCol] = 'S';
                    break;
                case 'D':
                    jaggedArray[samRow][samCol] = '.';
                    samRow++;
                    jaggedArray[samRow][samCol] = 'S';
                    break;
                case 'L':
                    jaggedArray[samRow][samCol] = '.';
                    samCol--;
                    jaggedArray[samRow][samCol] = 'S';
                    break;
                case 'R':
                    jaggedArray[samRow][samCol] = '.';
                    samCol++;
                    jaggedArray[samRow][samCol] = 'S';
                    break;
                default:
                    break;
            }
        }

        private static void MoveEnemy(char[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if (jaggedArray[row][col] == 'b' && col == jaggedArray[row].Length - 1)
                    {
                        jaggedArray[row][col] = 'd';
                        break;
                    }
                    else if (jaggedArray[row][col] == 'b')
                    {
                        jaggedArray[row][col] = '.';
                        jaggedArray[row][col + 1] = 'b';
                        break;
                    }

                    if (jaggedArray[row][col] == 'd' && col == 0)
                    {
                        jaggedArray[row][col] = 'b';
                    }
                    else if (jaggedArray[row][col] == 'd')
                    {
                        jaggedArray[row][col] = '.';
                        jaggedArray[row][col - 1] = 'd';
                        break;
                    }
                }
            }
        }

        private static void PrintArea(char[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}