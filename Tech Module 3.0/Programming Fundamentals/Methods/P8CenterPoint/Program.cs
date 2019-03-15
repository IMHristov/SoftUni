using System;

namespace P8CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            CenterPoint(X1, Y1, X2, Y2);
        }
        static void CenterPoint(double X1, double Y1,double X2,double Y2)
        {
            

            double distance1 = Math.Sqrt(X1 * X1 + Y1 * Y1);
            double distance2 = Math.Sqrt(X2 * X2 + Y2 * Y2);
            if (distance1<=distance2)
            {
                Console.WriteLine($"({X1}, {Y1})");
            }
            else
            {
                Console.WriteLine($"({X2}, {Y2})");
            }
        }
    }
}
