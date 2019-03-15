using System;
using System.Collections.Generic;
using System.Linq;

namespace P5Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Sums = new Dictionary<string, int>();
            string Name = Console.ReadLine().Split(" ").ToString();
            int allsum = 0;
            while (Name!= "JOKER")
            {
                List<string> Inputcards = Console.ReadLine().Split(", ").ToList();
                
                List<string> cards =Inputcards.Distinct().ToList();
                for (int i = 0; i < cards.Count; i++)
                {
                    string card = cards[i];
                    int power;
                    int type;
                    int sum = 0;
                    

                    if (card[0]=='J'|| card[0] == 'Q' || card[0] == 'K' || card[0] == 'A')
                    {
                        switch (card[0])
                        {
                            case 'J':
                                sum = 11;
                                break;
                            case 'Q':
                                sum = 12;
                                break;
                            case 'K':
                                sum = 13;
                                break;
                            case 'A':
                                sum = 14;
                                break;
                        }

                    }
                    else
                    {
                        sum = (int)card[0]-48;
                    }
                    switch (card[1])
                    {
                        case 'S':
                            sum = 4*sum;
                            break;
                        case 'H':
                            sum = 3 * sum;
                            break;
                        case 'D':
                            sum = 2 * sum;
                            break;
                        case 'C':
                            sum = 1 * sum;
                            break;
                    }
                    allsum += sum;

                }
                Console.WriteLine(allsum);
            }
            
        }
    }
}
