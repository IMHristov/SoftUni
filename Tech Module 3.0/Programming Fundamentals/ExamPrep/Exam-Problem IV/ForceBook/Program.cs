using System;
using System.Collections.Generic;
using System.Linq;

namespace P_4ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> Sides = new Dictionary<string, List<string>>();

            while (input != "Lumpawaroo")
            {
                var commands = input
                    .Split()
                    .ToArray();
                if (commands[1] == "|")
                {
                    string side = commands[0];
                    string jedi = commands[2];

                    if (!Sides.ContainsKey(side))
                    {
                        Sides.Add(side, new List<string>());
                    }
                    if (Sides[side].Contains(jedi) == false &&
                       Sides.Values.Any(x => x.Contains(jedi)) == false)
                    {
                        Sides[side].Add(jedi);

                    }

                }
                if (commands[1] == "->")
                {
                    string side = commands[2];
                    string jedi = commands[0];

                    if (Sides.Values.Any(x => x.Contains(jedi)) == false)
                    {
                        if (Sides.ContainsKey(side) == false)
                        {

                            Sides.Add(side, new List<String>());
                        }

                        Sides[side].Add(jedi);
                        Console.WriteLine($"{jedi} joins the {side} side!");
                    }
                    else
                    {
                        foreach (var s in Sides)
                        {
                            if (s.Value.Contains(jedi))
                            {
                                s.Value.Remove(jedi);
                            }
                        }
                        if (Sides.ContainsKey(side) == false)
                        {
                            Sides.Add(side, new List<String>());
                        }
                        Sides[side].Add(jedi);
                        Console.WriteLine($"{jedi} joins the {side} side!");
                    }

                }
                input = Console.ReadLine();

            }
            var sorted = Sides.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);

            foreach (var side in sorted)
            {
                if (side.Value.Count != 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                }
                foreach (var user in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }


            }
        }
    }
}
