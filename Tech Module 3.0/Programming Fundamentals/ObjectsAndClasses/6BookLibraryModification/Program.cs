using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _5.BookMY
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofBOoks = int.Parse(Console.ReadLine());
            Dictionary<string, DateTime> Books = new Dictionary<string, DateTime>();
            for (int i = 0; i < numberofBOoks; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                DateTime Date = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                if (Books.ContainsKey(name))
                {
                    Books[name] = Date;
                }
                else
                {
                    Books.Add(name, Date);
                }
                    
            }
            DateTime StartDate = DateTime.Parse(Console.ReadLine());

          foreach (var book in Books.OrderBy(x => x.Key).OrderBy(x => x.Value))
            {
                if (StartDate<book.Value)
                {
                    Console.WriteLine($"{book.Key} -> {book.Value:dd.MM.yyyy}");
                }
                
            }
        }
    }
}
