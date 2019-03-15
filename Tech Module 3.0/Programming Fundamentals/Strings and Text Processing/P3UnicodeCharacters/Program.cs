using System;

namespace P3UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                Console.Write("\\u" + ((int)symbol).ToString("X4").ToLower());
            }
            Console.WriteLine();
        }
    }
}
