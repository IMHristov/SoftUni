using System;

namespace P3._Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int person = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            double pricePerPerson = 0;
            if (person<=50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                if (package=="Normal")
                {
                    pricePerPerson = (2500.00 + 500.00) * 0.95 / person;
                }
                else if (package == "Gold")
                {
                    pricePerPerson = (2500.00 + 750.00) * 0.90 / person;
                }
                else if (package == "Platinum")
                {
                    pricePerPerson = (2500.00 + 1000.00) * 0.85 / person;
                }

            }
            else if (person <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                if (package == "Normal")
                {
                    pricePerPerson = (5000.00 + 500.00) * 0.95 / person;
                }
                else if (package == "Gold")
                {
                    pricePerPerson = (5000.00 + 750.00) * 0.90 / person;
                }
                else if (package == "Platinum")
                {
                    pricePerPerson = (5000.00 + 1000.00) * 0.85 / person;
                }
            }
            else if (person <= 120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                if (package == "Normal")
                {
                    pricePerPerson = (7500.00 + 500.00) * 0.95 / person;
                }
                else if (package == "Gold")
                {
                    pricePerPerson = (7500.00 + 750.00) * 0.90 / person;
                }
                else if (package == "Platinum")
                {
                    pricePerPerson = (7500.00 + 1000.00) * 0.85 / person;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            if (pricePerPerson != 0)
            {
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
        }
    }
}
