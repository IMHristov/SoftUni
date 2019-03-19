using System;
using System.Collections.Generic;

namespace HitList
{
    class HitList
    {
        static void Main(string[] args)
        {
            int TargetInfo = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, SortedDictionary<string, string>>();
            string input = Console.ReadLine();

            while (input != "end transmissions")
            {

                string[] command = input.Split("=", StringSplitOptions.RemoveEmptyEntries);

                if (!people.ContainsKey(command[0]))
                {
                    people[command[0]] = new SortedDictionary<string, string>();
                }

                string[] info = command[1].Split(";", StringSplitOptions.RemoveEmptyEntries);

                foreach (var pair in info)
                {
                    var token = pair.Split(":", StringSplitOptions.RemoveEmptyEntries);
                    people[command[0]][token[0]] = token[1];

                }
                input = Console.ReadLine();
            }
            string[] target = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string targetName = target[1];


            var Target = people[targetName];
            int sum = 0;

            Console.WriteLine($"Info on {targetName}:");
            foreach (var info in Target)
            {
                Console.WriteLine($"---{info.Key}: {info.Value}");
                sum += info.Value.Length + info.Key.Length;
            }
            Console.WriteLine($"Info index: {sum}");
            if (sum >= TargetInfo)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                Console.WriteLine($"Need {TargetInfo - sum} more info.");
            }
        }
    }
}