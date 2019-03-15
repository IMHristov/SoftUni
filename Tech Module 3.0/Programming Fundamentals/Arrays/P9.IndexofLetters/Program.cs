using System;
using System.Linq;


namespace P9.IndexofLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                int number = (int)input[i]-97;
                Console.WriteLine($"{input[i]} -> {number}");
            }
            



        }
    }
}
