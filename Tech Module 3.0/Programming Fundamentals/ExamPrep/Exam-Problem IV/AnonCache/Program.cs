using System;
using System.Collections.Generic;
using System.Linq;

namespace P4AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> DataSets = new List<string>();
            Dictionary<string, Dictionary<string, long>> DataDict = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();
            while (input != "thetinggoesskrra")
            {
                var commands = input.Split(" ->|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commands.Length == 1)
                {
                    DataSets.Add(commands[0]);
                }
                else
                {
                    string DataSet = commands[2];
                    string DataKey = commands[0];
                    long DataSize = long.Parse(commands[1]);
                    if (!DataDict.ContainsKey(DataSet))
                    {
                        DataDict[DataSet] = new Dictionary<string, long>();
                    }
                    DataDict[DataSet].Add(DataKey, DataSize);
                }
                input = Console.ReadLine();
            }
            foreach (var item in DataSets)
            {
                if (!DataDict.ContainsKey(item))
                {
                    DataDict.Remove(item);
                }
            }
            if (DataSets.Count > 0)
            {
                var result = DataDict.OrderByDescending(x => x.Value.Sum(e => e.Value)).First();
                Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Sum(x => x.Value)}");

                foreach (var key in result.Value)
                {
                    Console.WriteLine($"$.{key.Key}");
                }
            }
        }
    }
}