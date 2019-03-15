using System;
using System.Linq;
using System.Text;

namespace Problem6SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            int maxLenght = Math.Max(num1.Length, num2.Length);
            num1 = num1.PadLeft(maxLenght, '0');
            num2 = num2.PadLeft(maxLenght, '0');
            int reminder = 0;
            StringBuilder result = new StringBuilder();
            for (int i = maxLenght-1; i >= 0; i--)
            {
                int firstDig = int.Parse(num1[i].ToString());
                int secondDig = int.Parse(num2[i].ToString());
                int currentSum = firstDig + secondDig+reminder;
                reminder = 0;
                if (currentSum>9)
                {
                    currentSum -= 10;
                    reminder++;
                }
                result.Append(currentSum);
            }
           
                result.Append(reminder);
            
            string output = result.ToString().TrimEnd('0');
            for (int i = output.Length-1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }
            Console.WriteLine();
        }
    }
}
