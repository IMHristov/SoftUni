using System;
using System.Numerics;

namespace P10CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(365.2422 * years);
            int hours = 24 * days;
            int minutes = hours * 60;
            long seconds = 60L * minutes;
            long milliseconds = 1000 * seconds;
            ulong microseconds = (ulong)(milliseconds * 1000);
            BigInteger nanoseconds = microseconds * (BigInteger)1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");


        }
    }
}
