using System;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrase = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] City = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int n = int.Parse(Console.ReadLine());
            Random num = new Random();
            for (int i = 0; i < n; i++)
            {
                int PhraseIndex = num.Next(0, phrase.Length);
                int EventIndex = num.Next(0, events.Length);
                int AuthorIndex = num.Next(0, Authors.Length);
                int CityIndex = num.Next(0, City.Length);

                Console.WriteLine($"{phrase[PhraseIndex]} {events[EventIndex]} {Authors[AuthorIndex]} – {City[CityIndex]}");
            }
            
        }
    }
}
