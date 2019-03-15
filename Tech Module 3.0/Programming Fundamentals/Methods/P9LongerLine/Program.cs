using System;

namespace P9LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            double X3 = double.Parse(Console.ReadLine());
            double Y3 = double.Parse(Console.ReadLine());
            double X4 = double.Parse(Console.ReadLine());
            double Y4 = double.Parse(Console.ReadLine());
            CenterPoint(X1, Y1, X2, Y2, X3, Y3, X4, Y4);
        }
        static void CenterPoint(double X1, double Y1, double X2, double Y2, double X3, double Y3, double X4, double Y4)
        {
            double lenght1 = Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
            double lenght2 = Math.Sqrt((X3 - X4) * (X3 - X4) + (Y3 - Y4) * (Y3 - Y4));
            if (lenght2>lenght1)
            {
                X1 = X3;
                X2 = X4;
                Y1 = Y3;
                Y2 = Y4;
            }


            double distance1 = Math.Sqrt(X1 * X1 + Y1 * Y1);
            double distance2 = Math.Sqrt(X2 * X2 + Y2 * Y2);
            if (distance1 <= distance2)
            {
                Console.Write($"({X1}, {Y1})");
                Console.WriteLine($"({X2}, {Y2})");
            }
            else
            {
                Console.Write($"({X2}, {Y2})");
                Console.WriteLine($"({X1}, {Y1})");
            }
        }
    }
}
