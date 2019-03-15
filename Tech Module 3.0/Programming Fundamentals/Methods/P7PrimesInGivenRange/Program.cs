using System;

namespace P7PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            PrimesInGivenRange(startNum, endNum);
        }
        static void PrimesInGivenRange(int startNum, int endNum)
        {
            int count = 0;
            for (int i = startNum; i <= endNum; i++)
            {
                bool IsPrime = true;
                if (i == 0 || i == 1)
                {
                   IsPrime = false;
                }                           
                for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            IsPrime = false;

                        }
                    }
                
                if (IsPrime==true)
                {
                    if (count==0)
                    {
                        Console.Write(i);
                        count++;
                    }
                    else
                    {
                        Console.Write($", {i}");
                    }
                    
                }
            }
        }

    }
}
