using System;
using System.Numerics;
namespace P18DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            if (a >= -9223372036854775808 && a <= 9223372036854775807)
            {
                Console.WriteLine($"{a} can fit in:");
                if (-128 <= a && a <= 127)
                {
                    Console.WriteLine("* sbyte");
                }
                if (0 <= a && a <= 255)
                {
                    Console.WriteLine("* byte");
                }
                    if (-32768 <= a && a <= 32767)
                    {
                        Console.WriteLine("* short");
                    }
                    if (0 <= a && a <= 65535)
                    {
                        Console.WriteLine("* ushort");
                    }
                    if (-2147483648 <= a && a <= 2147483647)
                    {
                        Console.WriteLine("* int");
                    }
                    if (0 <= a && a <= 4294967295)
                    {
                        Console.WriteLine("* uint");
                    }
                    Console.WriteLine("* long");
                
            }
            else
            {
                Console.WriteLine($"{a} can't fit in any type");
            }
        }
    }
}
