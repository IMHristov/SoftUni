using System;

using System.Linq;

namespace P4NumbersInRevOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] number = Console.ReadLine().ToArray();
            int length = number.Length;
            ReversingNumber(number, length);

        }

        static void ReversingNumber(char[] number, int length)
        {
            int i = length - 1;
            char[] revNumber = new char[length];

            while (i >= 0)
            {
                revNumber[length - 1 - i] = number[i];
                i--;
            }

            foreach (char revnumber in revNumber)
            {
                Console.Write(revnumber);
            }
            Console.WriteLine();
        }
    }
}