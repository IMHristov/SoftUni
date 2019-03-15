using System;

namespace P7._Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i < 20; i++)
            {
                var ingredient = Console.ReadLine();
                if (ingredient!="Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    count++;
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");break;
                }
            }
            if (count==20)
            {
                Console.WriteLine($"Preparing cake with {count} ingredients.");
            }
        }
    }
}
