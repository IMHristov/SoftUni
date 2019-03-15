using System;

namespace P12TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            
                for (int i = N; i >= 1; i--)
                {
                    for (int j = 1; j <= M; j++)
                    {
                        
                    if (sum > boundary) break;
                    count++;
                    sum += 3 * i * j;
                }
                }
            
            Console.WriteLine($"{count} combinations");
            if (sum>=boundary)
            {
                Console.WriteLine($"Sum: {sum} >= {boundary}");
            }
            else
            {
                Console.WriteLine($"Sum: {sum}");
            }

        }
    }
}
