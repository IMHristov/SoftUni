using System;

namespace _11ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int time = seconds + minutes * 60 + hours * 3600;

            float MPS = (float)1.0* distance / time;
            float KPh = MPS/1000*60*60;
            float MPH = (float)(KPh / 1.609);

            Console.WriteLine($"{MPS:0.#######}");
            Console.WriteLine($"{KPh:0.#######}");
            Console.WriteLine($"{MPH:0.#######}");

        }
    }
}
