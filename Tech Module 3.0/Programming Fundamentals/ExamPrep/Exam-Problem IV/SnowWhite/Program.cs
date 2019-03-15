using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> Dwarfs = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                var commands = input.Split(" <:>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                string Name = commands[0];
                string HatColor = commands[1];
                int Physics = int.Parse(commands[2]);
                if (!Dwarfs.ContainsKey(HatColor))
                {
                    Dwarfs[HatColor] = new Dictionary<string, int>();
                    Dwarfs[HatColor].Add(Name, Physics);
                }
                else
                {
                    if (!Dwarfs[HatColor].ContainsKey(Name))
                    {
                        Dwarfs[HatColor].Add(Name, Physics);
                    }
                    else
                    {
                        if (Dwarfs[HatColor][Name] < Physics)
                        {
                            Dwarfs[HatColor][Name] = Physics;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            var sorted = Dwarfs.OrderByDescending(x => x.Value.Values.Max()).ThenByDescending(x => x.Value.Count());
            Dictionary<string, int> NewDict = new Dictionary<string, int>();
            foreach (var colorhat in sorted)
            {
                var color = colorhat.Key;

                foreach (var dwarf in colorhat.Value)
                {
                    NewDict.Add("(" + color + ")" + " " + dwarf.Key, dwarf.Value);
                }

            }
            foreach (var item in NewDict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
        }
    }
}