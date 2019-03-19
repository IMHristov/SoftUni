using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int BarrelSize = int.Parse(Console.ReadLine());
            int[] inputBullets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var Bullets = new Stack<int>();
            foreach (var bullet in inputBullets)
            {
                Bullets.Push(bullet);
            }
            int[] inputLocks = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var Locks = new Queue<int>();
            foreach (var Lock in inputLocks)
            {
                Locks.Enqueue(Lock);
            }

            int value = int.Parse(Console.ReadLine());

            int count = 0;
            while (Locks.Count != 0 && Bullets.Count != 0)
            {


                if (Bullets.Peek() <= Locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    Bullets.Pop();
                    Locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                    Bullets.Pop();
                }
                count++;
                if (count % BarrelSize == 0 && Bullets.Count != 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }
            if (Bullets.Count > 0)
            {
                Console.WriteLine($"{Bullets.Count} bullets left. Earned ${value - count * bulletPrice}");
            }
            else if (Bullets.Count == 0 && Locks.Count == 0)
            {
                Console.WriteLine($"{Bullets.Count} bullets left. Earned ${value - count * bulletPrice}");

            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {Locks.Count}");
            }

        }
    }
}