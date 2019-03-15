using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var pattern =  (@"(?<City>[A-Z][A-Z])(?<Temp>[0-9][0-9]?.[0-9][0-9]?)(?<weather>[A-Za-z]+)\|");
            var dict = new Dictionary<string, KeyValuePair<double, string>>();

            while (input!="end")
            {
               
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    var city = match.Groups[1].Value;
                    double temp =double.Parse( match.Groups[2].Value);
                    var typeOfWeather = match.Groups[3].Value;

                    
                        dict[city]= new KeyValuePair<double, string>(temp, typeOfWeather);
                    
                   
                }

                 input = Console.ReadLine();
                
            }
            var sortedDict = dict.OrderBy(x => x.Value.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var d in sortedDict)
            {
                Console.WriteLine($"{d.Key} => {d.Value.Key:f2} => {d.Value.Value}");
            }
        }
    }
}
