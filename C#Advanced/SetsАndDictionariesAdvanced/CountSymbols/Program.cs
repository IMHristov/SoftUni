using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            var symbols = new SortedDictionary<char, int>();
            foreach (var item in input)
            {
                if (!symbols.ContainsKey(item))
                {
                    symbols.Add(item, 1);
                }
                else
                {
                    symbols[item]++;
                }
            }
            foreach (var symbol in symbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
