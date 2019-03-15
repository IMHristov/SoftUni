using System;

namespace P2.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double area = a * h;
                Console.WriteLine("{0:F2}", area);
            
        }
    }
}
