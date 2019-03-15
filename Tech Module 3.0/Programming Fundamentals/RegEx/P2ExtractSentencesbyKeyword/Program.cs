using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P2ExtractSentencesbyKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchWord = Console.ReadLine();
            string patern = $@"\b{searchWord}\b";
            Regex regex = new Regex(patern);

            string[] words = Console.ReadLine()
                .Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();

            foreach ( string word in words)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word);
                }

            }
        }
    }
} 
