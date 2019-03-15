using System;

namespace P3EnglishNameLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            LastDigit();
        }
        static void LastDigit()
        {
            long a = long.Parse(Console.ReadLine());
            long b = Math.Abs(a);
            long LastNum = b % 10;
            switch (LastNum)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("tree");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                case 0:
                    Console.WriteLine("zero");
                    break;

            }


        }

    }
}
