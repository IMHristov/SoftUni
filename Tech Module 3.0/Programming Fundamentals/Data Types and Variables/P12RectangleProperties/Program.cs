using System;

namespace P12RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double area = a * b;
            double diagonal = Math.Sqrt(a * a + b * b);
            Console.WriteLine(2*a+2*b);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
