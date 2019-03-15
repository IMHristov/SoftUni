using System;

namespace P14IntegerHexBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int a = input;
            string myHex = input.ToString("X");
            Console.WriteLine(myHex);

            string binary = Convert.ToString(a, 2);
            Console.WriteLine(binary);

        }
    }
}
