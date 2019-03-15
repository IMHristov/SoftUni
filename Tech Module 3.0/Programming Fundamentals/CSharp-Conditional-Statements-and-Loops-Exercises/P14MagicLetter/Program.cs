using System;

namespace P14MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = Console.ReadLine()[0];
            char b = Console.ReadLine()[0];
            char c = Console.ReadLine()[0];

            for (char i = a; i <= b; i++)
            {
                for (char j = a; j <= b; j++)
                {
                    for (char k = a; k <=b; k++)
                    {
                        if (i!=c&& j != c && k != c)
                        {
                            Console.Write ($"{i}{j}{k} ");
                        }
                    }
                }
            }
        }
    }
}
