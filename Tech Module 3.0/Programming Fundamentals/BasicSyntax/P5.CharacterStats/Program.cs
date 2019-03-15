using System;

namespace P5.CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new string('|', a)}{new string('.', b - a)}|");
            Console.WriteLine($"Energy: |{new string('|', c)}{new string('.', d - c)}|");
        }
    }
}
