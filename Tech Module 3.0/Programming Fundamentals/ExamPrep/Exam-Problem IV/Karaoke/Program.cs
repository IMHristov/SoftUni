using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            string[] songList = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            string[] input = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            Dictionary<string, List<string>> Winners = new Dictionary<string, List<string>>();
            while (input[0] != "dawn")
            {
                string winner = input[0];
                string song = input[1];
                string award = input[2];
                if (participants.Contains(winner) && songList.Contains(song))
                {
                    if (Winners.ContainsKey(winner) && !Winners[winner].Contains(award))
                    {
                        Winners[winner].Add(award);
                    }
                    if (!Winners.ContainsKey(winner))
                    {
                        Winners.Add(winner, new List<string>());
                        Winners[winner].Add(award);
                    }

                }
                input = Console.ReadLine()
               .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(x => x.Trim())
               .ToArray();

            }
            foreach (var person in Winners.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{person.Key}: {person.Value.Count} awards");

                foreach (var prize in person.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"--{prize}");
                }
            }
            if (Winners.Count == 0)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
