using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> Countries = new Dictionary<string, Dictionary<string, long>>();
            string command = "";
            //List<string> input = Console.ReadLine().Split('|').ToList();
            while (true)
            {
                List<string> input = Console.ReadLine().Split('|').ToList();
                command = input[0];
                if (command == "report") break;
                string town = input[0];
                string country = input[1];
                long townPopulation = long.Parse(input[2]);

                if (Countries.ContainsKey(country))
                {
                    Countries[country].Add(town, townPopulation);
                }

                if (!Countries.ContainsKey(country))
                {
                    Countries[country] = new Dictionary<string, long>();
                }
                if (!Countries[country].ContainsKey(town))
                {
                    Countries[country].Add(town, townPopulation);
                }
            }
                Dictionary<string, long> TotalPopulation = new Dictionary<string, long>();

                foreach (var item in Countries)
                {
                    TotalPopulation[item.Key] = item.Value.Values.Sum();
                }
            foreach (var item in TotalPopulation.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value})");
                foreach (var Town in Countries[item.Key].OrderByDescending(x => x.Value))
                {
                    
                    Console.WriteLine($"=>{Town.Key}: {Town.Value}");
                }

            }
        }
    }
}
