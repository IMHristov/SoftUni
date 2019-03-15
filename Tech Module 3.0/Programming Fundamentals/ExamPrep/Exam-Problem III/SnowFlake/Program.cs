using System;
using System.Text.RegularExpressions;

namespace Ep3Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            var patternSurface = @"[^A-Za-z\d]+$";
            var patternMantle = @"[\d_]+$";
            var pattern = @"([^A-Za-z\d]+)([\d_]+)(?<core>[a-zA-Z]+)([\d_]+)([^A-Za-z\d]+)";

            var surface = Console.ReadLine();
            var Mantle = Console.ReadLine();
            var All = Console.ReadLine();
            var Mantle2 = Console.ReadLine();
            var surface2 = Console.ReadLine();

            if (Regex.IsMatch(surface, patternSurface) && Regex.IsMatch(surface2, patternSurface) &&
                Regex.IsMatch(Mantle, patternMantle) && Regex.IsMatch(Mantle2, patternMantle) &&
                Regex.IsMatch(All, pattern))
            {
                Console.WriteLine("Valid");
                Match match = Regex.Match(All, pattern);
                int num = match.Groups[5].Value.Length;
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
