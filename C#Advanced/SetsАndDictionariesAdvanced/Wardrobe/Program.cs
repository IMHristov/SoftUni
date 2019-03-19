using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] token = Console.ReadLine()
                    .Split(" -> ", ',', StringSplitOptions.RemoveEmptyEntries);
                string[] clothes = token[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(token[0]))
                {
                    wardrobe.Add(token[0], new Dictionary<string, int>());
                    foreach (var item in clothes)
                    {
                        if (!wardrobe[token[0]].ContainsKey(item))
                        {
                            wardrobe[token[0]].Add(item, 1);
                        }
                        else
                        {
                            wardrobe[token[0]][item]++;
                        }
                    }
                }
                else
                {
                    foreach (var item in clothes)
                    {
                        if (!wardrobe[token[0]].ContainsKey(item))
                        {
                            wardrobe[token[0]].Add(item, 1);
                        }
                        else
                        {
                            wardrobe[token[0]][item]++;
                        }
                    }
                }
            }
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string searchColor = command[0];
            string searchType = command[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var type in color.Value)
                {
                    Console.Write($"* {type.Key} - {type.Value}");
                    if (searchColor == color.Key && searchType == type.Key)
                    {
                        Console.WriteLine(" (found!)");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
