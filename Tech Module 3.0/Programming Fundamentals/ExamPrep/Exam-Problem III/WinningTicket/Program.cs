using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
public class WinningTicket
{
    public static void Main() // 100/100
    {
        StringBuilder result = new StringBuilder();

        List<string> tickets = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToList();

        string pattern = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";
        Regex reg = new Regex(pattern);

        foreach (string ticket in tickets)
        {
            if (ticket.Length != 20)
            {
                Console.WriteLine($"invalid ticket");
            }
            else
            {
                Match leftMatch = reg.Match(ticket.Substring(0, 10));
                Match rightMatch = reg.Match(ticket.Substring(10));
                int minLen = Math.Min(leftMatch.Length, rightMatch.Length);

                if (!leftMatch.Success || !rightMatch.Success)
                {
                    Console.WriteLine($"ticket \"{ ticket}\" - no match");
                }
                else
                {
                    string leftPart = leftMatch.Value.Substring(0, minLen);
                    string rightPart = rightMatch.Value.Substring(0, minLen);

                    if (leftPart.Equals(rightPart))
                    {
                        if (leftPart.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{ ticket}\" - {minLen}{leftPart.Substring(0, 1)} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ ticket}\" - {minLen}{leftPart.Substring(0, 1)}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ ticket}\" - no match");
                    }
                }
            }
        }
    }
}