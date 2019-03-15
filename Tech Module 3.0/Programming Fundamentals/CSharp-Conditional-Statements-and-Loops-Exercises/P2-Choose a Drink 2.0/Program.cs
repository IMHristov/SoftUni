using System;

namespace P2_Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        
{
            var person = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double sum = 0;

            if (person == "Athlete")
            {
                sum=quantity*0.7;
            }
            else if (person == "Businessman" || person == "Businesswoman")
            {
                sum = quantity * 1.0;
            }
            else if (person == "SoftUni Student")
            {
                sum = quantity * 1.7;
            }
            else
            {
                sum = quantity * 1.2;
            }
            
           Console.WriteLine($"The {person} has to pay {sum:f2}.");
        }
    }
}
