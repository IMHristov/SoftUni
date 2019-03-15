using System;

namespace P11GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string FigureType = Console.ReadLine();
            if (FigureType== "triangle")
            {
                Triagnle();
            }
            else if (FigureType == "square")
            {
                Square();
            }
            else if (FigureType == "rectangle")
            {
                Rectangle();
            }
            else if (FigureType == "circle")
            {
                Circle();
            }
        }
        static void Triagnle()
        {

            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{side*height/2:F2}");

        }
        static void Square()
        {

            double side = double.Parse(Console.ReadLine());
            Console.WriteLine($"{side*side:F2}");

        }
        static void Rectangle()
        {

            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{side * height:F2}");

        }
        static void Circle()
        {

            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"{radius*radius*Math.PI:F2}");

        }
    }
}
