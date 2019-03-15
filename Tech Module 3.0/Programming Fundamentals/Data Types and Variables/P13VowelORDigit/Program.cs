using System;

namespace P13VowelORDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = Console.ReadLine()[0];

            switch (input)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    Console.WriteLine("digit");
                    break;
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'y':
                case 'u':
                    Console.WriteLine("vowel");
                    break;

                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}
