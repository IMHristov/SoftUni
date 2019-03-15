using System;

namespace P4.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double eContent = double.Parse(Console.ReadLine());
            double sContent = double.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{volume * eContent / 100:0.##}kcal, {volume * sContent / 100:0.##}g sugars");
        }
    }
}
