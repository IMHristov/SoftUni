using System;

namespace P9._Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    int a = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception)
                {

                    Console.WriteLine(count); break;
                }
            }
        }
    }
}
