using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace P6ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine()
                .Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> ValidWords = new List<string>();

            var pattern = @"^[a-zA-Z][a-zA-Z0-9_]{2,24}$";

            foreach (string word in input)
            {
                if (Regex.IsMatch(word, pattern))
                {
                    ValidWords.Add(word);
                }
            }
            string firstWord = ValidWords[0];
            string secondWord = ValidWords[1];
           int sum = firstWord.Length + secondWord.Length;
            for (int i = 1; i < ValidWords.Count-1; i++)
            {
                int curSum = ValidWords[i].Length + ValidWords[i+1].Length;
                if (curSum > sum)
                {
                    sum = curSum;
                    firstWord = ValidWords[i];
                    secondWord = ValidWords[i+1];
                }
            }
            Console.WriteLine(firstWord);
            Console.WriteLine(secondWord);

        }
    }
}
