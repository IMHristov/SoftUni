using System;

namespace P5WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            var plural = Console.ReadLine();
            var o = plural.EndsWith("o");
            var ch= plural.EndsWith("ch");
            var s = plural.EndsWith("s");
            var sh = plural.EndsWith("sh");
            var x = plural.EndsWith("x");
            var z = plural.EndsWith("z");
            var y = plural.EndsWith("y");

            if (o == true || ch == true || s == true || sh == true || x == true || z == true)
            {
                Console.WriteLine($"{plural}es");
            }
            else if (y == true)
            {
                plural = plural.Remove(plural.Length - 1);
                Console.WriteLine($"{plural}ies");
            }
            else
            {
                Console.WriteLine($"{plural}s");
            }
           
 
        }
    }
}
