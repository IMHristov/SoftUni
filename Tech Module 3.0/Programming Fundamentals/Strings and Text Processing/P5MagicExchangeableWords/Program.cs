using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem5MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            
            string firstWord = input[0];
            string secondWord = input[1];
            if (firstWord.Length<secondWord.Length)
            {
               firstWord = input[1];
                 secondWord = input[0];
            }
            Dictionary<char, char> Letters = new Dictionary<char, char >();
            bool isTrue = true;
            while (isTrue)
            {
                for (int i = 0; i < secondWord.Length; i++)
                    {
                        if (Letters.ContainsKey(firstWord[i]))
                        {
                            if (Letters[firstWord[i]]!=secondWord[i])
                            {
                              isTrue = false;
                                break;
                            }
                        }
                        else
                        {
                            Letters.Add(firstWord[i], secondWord[i]);
                        }
                    }
                for (int i = secondWord.Length-1; i < firstWord.Length; i++)
                {
                    if (!Letters.ContainsKey(firstWord[i]))
                    {
                        
                            isTrue = false;
                            break;
                    }
                }
                    break;
            }

            if (isTrue)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
