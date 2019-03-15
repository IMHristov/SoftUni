using System;

namespace P10._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i); Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
