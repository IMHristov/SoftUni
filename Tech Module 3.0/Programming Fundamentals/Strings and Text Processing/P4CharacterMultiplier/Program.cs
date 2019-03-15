using System;
using System.Linq;

namespace P4CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string firstWord = input[0];
            string secondWord = input[1];
            int sum = 0;
            
            for (int i = 0; i < Math.Min(firstWord.Length, secondWord.Length); i++)
            {
                char symbol = firstWord[i];
                char symbol2 = secondWord[i];

                sum += ((int)symbol * (int)symbol2);
            }
            if (firstWord.Length> secondWord.Length)
            {
                for (int i = secondWord.Length; i < firstWord.Length; i++)
                {
                    char symbol = firstWord[i];
                    sum += (int)symbol;
                }
            }
            if (firstWord.Length < secondWord.Length)
            {
                for (int i = firstWord.Length; i < secondWord.Length; i++)
                {
                    char symbol = secondWord[i];
                    sum += (int)symbol;
                }
            }


            Console.WriteLine(sum);
        }
    }
}
