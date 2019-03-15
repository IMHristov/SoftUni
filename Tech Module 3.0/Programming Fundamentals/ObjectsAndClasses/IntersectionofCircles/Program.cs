using System;
using System.Linq;

namespace IntersectionofCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Circle1 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] Circle2 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double distance = Math.Sqrt(Math.Pow(Math.Abs(Circle1[0] - Circle2[0]),2)+ Math.Pow(Math.Abs(Circle1[1] - Circle2[1]), 2));

            if (distance>(Circle1[2]+ Circle2[2]))
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }

        }
    }
}
