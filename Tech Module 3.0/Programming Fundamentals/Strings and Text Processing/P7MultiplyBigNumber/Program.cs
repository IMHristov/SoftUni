using System;
using System.Text;

namespace Problem7MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());
            if (num2==0)
            {
                Console.WriteLine(0);
                return;
            }
            
            int reminder = 0;
            StringBuilder result = new StringBuilder();
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int firstDig = int.Parse(num1[i].ToString());
                
                int currentSum = firstDig * num2 + reminder;
                reminder = 0;
                if (currentSum > 9)
                {
                    reminder = currentSum / 10;
                    currentSum %= 10;
                    
                }
                result.Append(currentSum);
            }

            result.Append(reminder);

            string output = result.ToString().TrimEnd('0');
            for (int i = output.Length - 1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }
            Console.WriteLine();
        }
    }
}
