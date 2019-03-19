using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var Vloggers = new Dictionary<string, Dictionary<string, SortedSet<string>>>();
            string[] token = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (token[0] != "Statistics")
            {
                if (token[1] == "joined")
                {
                    if (!Vloggers.ContainsKey(token[0]))
                    {
                        Vloggers.Add(token[0], new Dictionary<string, SortedSet<string>>());
                        Vloggers[token[0]].Add("followers", new SortedSet<string>());
                        Vloggers[token[0]].Add("following", new SortedSet<string>());
                    }
                }
                if (token[1] == "followed")
                {
                    if (Vloggers.ContainsKey(token[0]) && Vloggers.ContainsKey(token[2]) && token[0] != token[2])
                    {
                        Vloggers[token[0]]["following"].Add(token[2]);
                        Vloggers[token[2]]["followers"].Add(token[0]);

                    }
                }

                token = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"The V-Logger has a total of {Vloggers.Count} vloggers in its logs.");

            var SortedVlogers = Vloggers.OrderByDescending(x => x.Value["followers"].Count)
            .ThenBy(x => x.Value["following"].Count);
            int counter = 1;
            foreach (var person in SortedVlogers)
            {
                Console.WriteLine($"{counter++}. {person.Key} : {person.Value["followers"].Count} followers, {person.Value["following"].Count} following");
                if (counter == 2)
                {
                    foreach (var follower in person.Value["followers"])
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
            }

        }
    }
}
