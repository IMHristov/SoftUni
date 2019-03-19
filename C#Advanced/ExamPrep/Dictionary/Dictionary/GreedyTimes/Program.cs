using System;
using System.Collections.Generic;
using System.Linq;

namespace GredyTimes
{
    class Program
    {
        static void Main()
        {
            var bag = new Dictionary<string, Dictionary<string, long>>();

            var bagCapacity = long.Parse(Console.ReadLine());



            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < input.Length; i += 2)
            {
                var wealth = input[i];

                var amount = long.Parse(input[i + 1]);

                var goldAmount = bag.Where(x => x.Key.Equals("Gold")).Sum(x => x.Value.Sum(z => z.Value));
                var gemAmount = bag.Where(x => x.Key.Equals("Gem")).Sum(x => x.Value.Sum(z => z.Value));
                var cashAmount = bag.Where(x => x.Key.Equals("Cash")).Sum(x => x.Value.Sum(z => z.Value));

                var type = GetType(wealth);

                long totalAmount = gemAmount + goldAmount + cashAmount;


                if (bagCapacity >= totalAmount + amount)
                {
                    if (type == "Gold")
                    {
                        AddToBag(bag, wealth, amount, type);
                        continue;
                    }

                    if (type == "Gem" && gemAmount + amount <= goldAmount)
                    {
                        AddToBag(bag, wealth, amount, type);
                        continue;
                    }
                    if (type == "Cash" & cashAmount + amount <= gemAmount)
                    {
                        AddToBag(bag, wealth, amount, type);
                        continue;
                    }

                }

            }

            var dict = bag.OrderByDescending(x => x.Value.Sum(z => z.Value));

            foreach (var kvp in dict)
            {

                Console.WriteLine($"<{kvp.Key}> ${bag.Where(x => x.Key.Equals(kvp.Key)).Sum(x => x.Value.Sum(z => z.Value))}");
                foreach (var item in kvp.Value.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
                {
                    Console.WriteLine($"##{item.Key} - {item.Value}");
                }
            }
        }

        private static void AddToBag(Dictionary<string, Dictionary<string, long>> bag, string wealth, long amount, string type)
        {
            if (!bag.ContainsKey(type))
            {
                bag.Add(type, new Dictionary<string, long>());
            }

            if (!bag[type].ContainsKey(wealth))
            {
                bag[type].Add(wealth, 0);
            }

            bag[type][wealth] += amount;

        }

        private static string GetType(string wealth)
        {
            if (wealth.Count() == 3)
            {
                return "Cash";
            }

            if (wealth.Length >= 4 && wealth.ToLower().EndsWith("gem"))
            {
                return "Gem";
            }

            if (wealth.ToLower() == "gold")
            {
                return "Gold";
            }

            return "";
        }
    }


}