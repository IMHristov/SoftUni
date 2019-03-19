using System;

namespace ActionPoint
{
    class ActionPoint
    {
        static void Main(string[] args)

        {
            Action<string[]> print = names => Console.WriteLine("Sir " + string.Join("\nSir ",names));
            string[] inputNames = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            print(inputNames);

        }
    }
}
