using System;

namespace P4VariableinHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int hexdecimal = Convert.ToInt32(input, 16);
            Console.WriteLine(hexdecimal);
        }
    }
}
