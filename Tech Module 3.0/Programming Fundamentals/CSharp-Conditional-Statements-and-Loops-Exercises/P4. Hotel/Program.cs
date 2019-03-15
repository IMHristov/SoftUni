using System;

namespace P4._Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            if (month == "May")
            {
                if (nights < 8)
                {
                    Console.WriteLine($"Studio: {50 * nights:f2} lv.");
                    Console.WriteLine($"Double: {65 * nights:f2} lv.");
                    Console.WriteLine($"Suite: {75 * nights:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"Studio: {50 * nights * 0.95:f2} lv.");
                    Console.WriteLine($"Double: {65 * nights :f2} lv.");
                    Console.WriteLine($"Suite: {75 * nights :f2} lv.");
                }

            }
            if (month == "October")
            {
                if (nights < 8)
                {
                    Console.WriteLine($"Studio: {50 * nights:f2} lv.");
                    Console.WriteLine($"Double: {65 * nights:f2} lv.");
                    Console.WriteLine($"Suite: {75 * nights:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"Studio: {50 * (nights - 1) * 0.95:f2} lv.");
                    Console.WriteLine($"Double: {65 * nights :f2} lv.");
                    Console.WriteLine($"Suite: {75 * nights:f2} lv.");
                }

            }
            if (month == "June")
            {
                if (nights < 15)
                {
                    Console.WriteLine($"Studio: {60 * nights:f2} lv.");
                    Console.WriteLine($"Double: {72 * nights:f2} lv.");
                    Console.WriteLine($"Suite: {82 * nights:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"Studio: {60 * nights :f2} lv.");
                    Console.WriteLine($"Double: {72 * nights * 0.90:f2} lv.");
                    Console.WriteLine($"Suite: {82 * nights :f2} lv.");
                }
            }
            if (month == "September")
            {
                if (nights < 8)
                {
                    Console.WriteLine($"Studio: {60 * nights:f2} lv.");
                    Console.WriteLine($"Double: {72 * nights:f2} lv.");
                    Console.WriteLine($"Suite: {82 * nights:f2} lv.");
                }
                else if (nights < 15)
                {
                    Console.WriteLine($"Studio: {60 * (nights - 1):f2} lv.");
                    Console.WriteLine($"Double: {72 * nights:f2} lv.");
                    Console.WriteLine($"Suite: {82 * nights:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"Studio: {60 * (nights - 1) :f2} lv.");
                    Console.WriteLine($"Double: {72 * nights * 0.90:f2} lv.");
                    Console.WriteLine($"Suite: {82 * nights :f2} lv.");
                }
            }
            if (month == "July" || month == "August" || month == "December")
            {
                if (nights < 15)
                {
                    Console.WriteLine($"Studio: {68 * nights:f2} lv.");
                    Console.WriteLine($"Double: {77 * nights:f2} lv.");
                    Console.WriteLine($"Suite: {89 * nights:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"Studio: {68 * nights :f2} lv.");
                    Console.WriteLine($"Double: {77 * nights :f2} lv.");
                    Console.WriteLine($"Suite: {89 * nights * 0.85:f2} lv.");
                }
            }

        }
    }
}
