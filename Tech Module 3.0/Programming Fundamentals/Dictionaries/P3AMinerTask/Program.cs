using System;
using System.Collections.Generic;
using System.Linq;

namespace P3AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> Minner = new Dictionary<string, double>();
            string resource = Console.ReadLine();
            double quantity = 0;

            while (resource != "stop")
            {
                quantity = double.Parse(Console.ReadLine());
                if (Minner.ContainsKey(resource))
                {
                    Minner[resource] += quantity;
                }
                else
                {
                    Minner.Add(resource, quantity);
                }
                resource = Console.ReadLine();

            }
            foreach (var item in Minner)
            {

                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }

    }
}
