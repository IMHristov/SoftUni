using System;

namespace P1HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
             PrintName();
        }
        static void PrintName()
        {
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
        
        }
        
    }
}
