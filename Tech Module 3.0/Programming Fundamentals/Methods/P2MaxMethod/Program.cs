using System;

namespace P2MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int firstMax = Getmax(firstNum, secondNum);
            int Max = Getmax(firstMax, thirdNum);
            Console.WriteLine(Max);

        }
        static int Getmax(int a,int b)
        {
            
            if (a >= b)
            {
                return a;
            }
            else
                return b;
        }
    }
}
