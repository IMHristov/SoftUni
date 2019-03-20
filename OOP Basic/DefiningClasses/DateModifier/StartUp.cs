using System;

namespace DateModifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier.DatesDifference(firstDate, secondDate);
        }
    }
}
