using System;
using System.Collections.Generic;

namespace P4.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Mails = new Dictionary<string, string>();
            string Name = Console.ReadLine();
            
            while (Name!="stop")
            {
               string mail = Console.ReadLine();
                char first = mail[mail.Length-2];
                char second = mail[mail.Length - 1];

                if ((first == 'u' && second == 'k') || (first == 'u' && second == 's'))
                {

                }
                else
                {
                    Mails.Add(Name, mail);
                }
                 Name = Console.ReadLine();
                 

            }
            foreach (var name in Mails)
            {
                Console.WriteLine($"{name.Key} -> {name.Value}");
            }
        }
    }
}
