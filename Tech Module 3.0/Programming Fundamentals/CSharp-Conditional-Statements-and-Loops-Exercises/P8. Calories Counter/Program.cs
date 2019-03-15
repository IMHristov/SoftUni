using System;

namespace P8._Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalProducts = int.Parse(Console.ReadLine());
            int calories = 0;
            for (int i = 0; i < totalProducts; i++)
            {
                var product = Console.ReadLine().ToLower();
                if (product== "cheese")
                {
                    calories += 500;
                }
                if (product == "tomato sauce")
                {
                    calories += 150;
                }
                if (product == "salami")
                {
                    calories += 600;
                }
                if (product == "pepper")
                {
                    calories += 50;
                }
            }
            Console.WriteLine($"Total calories: {calories}");

        }
    }
}
