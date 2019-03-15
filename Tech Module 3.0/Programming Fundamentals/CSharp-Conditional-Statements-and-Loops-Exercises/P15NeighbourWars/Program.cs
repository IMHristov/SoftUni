using System;

namespace P15NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoDamage = int.Parse(Console.ReadLine());
            int GoshoDamage = int.Parse(Console.ReadLine());
            int GoshoHealth = 100;
            int PeshoHealth = 100;
           int count = 0;

            for (int i = 1; i < 100000; i++)
            {
                count++;
                if (i%2==1)
                {
                    GoshoHealth -= PeshoDamage;
                    if (GoshoHealth<=0)
                    {
                        Console.WriteLine($"Pesho won in {count}th round.");break;
                    }
                    else
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHealth} health.");
                    }

                    
                }
                else
                {
                    PeshoHealth -= GoshoDamage;
                    if (PeshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {count}th round.");break;
                    }
                    else
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHealth} health.");
                    }
                }
                if (i%3==0)
                {
                    PeshoHealth +=10;
                    GoshoHealth+=10;
                }

            }
        }
    }
}
