using System;
using System.Collections.Generic;
using System.Text;

namespace Animals2
{
    public class Kitten : Animal
    {
        public Kitten(string name, int age, string gender) : base(name, age, "Female")
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
