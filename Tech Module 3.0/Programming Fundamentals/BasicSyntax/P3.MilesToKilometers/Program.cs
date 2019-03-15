using System;

namespace P3.MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            const double kmToMiles = 1.60934;

            Console.WriteLine("{0:F2}", a * kmToMiles);
        }
    }
}
