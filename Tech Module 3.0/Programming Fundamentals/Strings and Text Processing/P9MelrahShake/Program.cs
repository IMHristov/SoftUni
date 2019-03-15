using System;

namespace P9MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string keyword = Console.ReadLine();

            while ((text.IndexOf(keyword)!=-1&&text.LastIndexOf(keyword)!= text.IndexOf(keyword))&&keyword.Length!=0)
            {
                Console.WriteLine("Shaked it.");
                text = text.Remove(text.LastIndexOf(keyword), keyword.Length);
                text = text.Remove(text.IndexOf(keyword), keyword.Length);
                keyword = keyword.Remove(keyword.Length / 2, 1);
                
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}
