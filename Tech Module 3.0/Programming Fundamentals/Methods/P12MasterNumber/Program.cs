using System;

namespace P12MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 232; i <= num; i++)
            {
                if (isSymetric(i) == true && isDevisableBy7(i) == true && OneEvenDigit(i)==true)
                {
                    Console.WriteLine(i);
                }
            }
            

        }
        static bool isSymetric(int num)
        {
            string digits = "" + num;
            for (int i = 0; i < digits.Length / 2; i++)
                if (digits[i] != digits[digits.Length - i - 1])
                {
                    return false;
                }
            return true;

        }
        static bool isDevisableBy7(int num)
        {
            int sum = 0;
            while (num!=0)
            {
                sum += (num % 10);
                num /= 10;
            }
            if (sum%7==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool OneEvenDigit(int num)
        {
            int count = 0;
            while (num != 0)
            {
                if ((num%10) % 2 == 0)
                {
                    count++;
                    num /= 10;
                }
                else
                {
                    num /= 10;     
                }
            }
            if (count==0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}
