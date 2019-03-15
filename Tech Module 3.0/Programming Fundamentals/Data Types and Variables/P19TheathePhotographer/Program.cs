using System;
using System.Numerics;
namespace P19TheathePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
           long N = long.Parse(Console.ReadLine());
           long FT = long.Parse(Console.ReadLine());
           long FF = long.Parse(Console.ReadLine());
          long UT = long.Parse(Console.ReadLine());
           double FP = Math.Ceiling(N * FF/100.0);
            
          long totalTime = (long)(FP *UT+ N*FT);

            long dd =0;
            long hh = 0;
            long mm = 0;
            long ss = 0;

            ss = (totalTime % 60);
             dd = (totalTime / 86400);
              hh = ((totalTime - dd * 86400) / 3600);
            mm = ((totalTime - dd * 86400 - 3600 * hh)/60);
             Console.WriteLine($"{dd:d1}:{hh:d2}:{mm:d2}:{ss:d2}");

            //TimeSpan time = TimeSpan.FromSeconds(totaltime);
          //  string str = time.ToString(@"d\:hh\:mm\:ss");
            //Console.WriteLine(str);
        }
    }
}
