using System;

namespace P17PrintPartASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <=b; i++)
            {
                char c = (char)i;
                Console.Write($"{c} ");
            }
            
            
        }
    }
}
