using System;

namespace P16.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double input1 = double.Parse(Console.ReadLine());
           double input2 = double.Parse(Console.ReadLine());
            double difference = Math.Abs(input1-input2);
            ///Console.WriteLine($"{difference:0.#########}");
            double eps = 0.000001;
            if (eps>=difference)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
