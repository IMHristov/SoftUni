using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regeh
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\[[A-Z&a-z]+<([0-9]+)REGEH([0-9]+)>[A-Z&a-z]+\]";

            var input = Console.ReadLine();

            Regex rgx = new Regex(pattern);

            MatchCollection matches = rgx.Matches(input);

            string result = string.Empty;
            int index = 0;
            foreach (Match match in matches)
            {
                index += int.Parse(match.Groups[1].Value);
                if (index >= input.Length)
                {
                    var realIndex = (index % input.Length) + 1;

                    result += input[realIndex];
                }
                else
                {
                    result += input[index];
                }
                index += int.Parse(match.Groups[2].Value);
                if (index >= input.Length)
                {
                    var realIndex = (index % input.Length) + 1;

                    result += input[realIndex];
                }
                else
                {
                    result += input[index];
                }
            }
            Console.WriteLine(result);
        }
    }
}