using System;
using System.Collections.Generic;
using System.Linq;

namespace P8LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCount = int.Parse(Console.ReadLine());
            Dictionary<string, int> Duration = new Dictionary<string, int>();
            Dictionary<string, string> IPs = new Dictionary<string, string>();
            for (int i = 0; i < totalCount; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                
                string IP = input[0];
                string name = input[1];
                int time = int.Parse(input[2]);

                if (!Duration.ContainsKey(name))
                {
                    Duration.Add(name, time);
                    IPs.Add(name, IP);
                }
                else
                {
                    Duration[name] += time;
                    IPs[name] +=" "+ IP;
                }

            }
            SortedDictionary<string, List<string>> NewIPs = new SortedDictionary<string, List<string>>();
            foreach (var item in IPs)
            {
                NewIPs.Add(item.Key, item.Value.Split().Distinct().OrderBy(x => x).ToList());
            }
            
            foreach (var person in NewIPs.OrderBy(x => x.Key))
            {
                
                    Console.WriteLine($"{person.Key}: {Duration[person.Key]} [{string.Join(", ", NewIPs[person.Key])}]");
               


            }
        }
        
    }
}
