using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StringMatrixRotation
{
    class StringMatrixRotation
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            string pattern = @"[0-9]+";
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(command);
            int rotation = int.Parse(match[0].Value)%360;
            
            string text = string.Empty;
            List<string> words = new List<string>();
            while (text!="END")
            {
                 text = Console.ReadLine();
                if (text!="END")
                {
                    words.Add(text);
                }
                
            }
            int maxLenght = int.MinValue;

            foreach (var word in words)
            {
                if (maxLenght<word.Length)
                {
                    maxLenght = word.Length;
                }
            }
            char[,] matrix = new char[words.Count,maxLenght];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    matrix[i, j] = words[i][j];
                }
            }

            if (rotation==0)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            if (rotation == 180)
            {
                for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            if (rotation==90)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            if (rotation == 270)
            {
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
