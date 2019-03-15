using System;
using System.Collections.Generic;
using System.Linq;

namespace P6UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
           
            SortedDictionary<string, List<string>> LogFile = new SortedDictionary<string, List<string>>();
            bool isEnd= true;
            while (isEnd)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                if (input[0] =="end")
                {
                   
                    break;
                }
                string IP = input[0].Remove(0, 3);
                List<string> IPs = new List<string>();
                IPs.Add(IP);
                string user = input[2].Remove(0, 5);

                if (LogFile.ContainsKey(user))
                {
                    LogFile[user].AddRange(IPs);
                }
                else
                {
                    LogFile[user] = IPs;
                }
                
            }
            foreach (var user in LogFile)
            {
                Console.WriteLine($"{user.Key}:");
                List < string >IPs= user.Value;
                Dictionary<string, int> NumberIP = new Dictionary<string, int>();
                foreach (var ip in IPs)
                {
                    if (NumberIP.ContainsKey(ip))
                    {
                        NumberIP[ip] += 1;
                    }
                    else
                    {
                        NumberIP[ip] = 1;
                    }
                }
                int lenght = NumberIP.Count;
                foreach (var ip in NumberIP)
                {
                    lenght--;
                    if (lenght>0)
                    {
                        Console.Write($"{ip.Key} => {ip.Value}, ");
                    }
                    else
                    {
                        Console.Write($"{ip.Key} => {ip.Value}.");
                    }
                }
                Console.WriteLine();
                
            }
           
        }
    }
}
