using System;
using System.Collections.Generic;
using System.Text;

namespace Animals2
{
    public class Animal
    {
        //Each Animal should have a name, an age and a gender
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get { return this.age; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.age = value;
            }
        }
        public string Gender
        {
            get => gender;
            set => gender = value;
        }

        public virtual string ProduceSound()
        {
            return "Not implemented!";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.Append(ProduceSound());

            return sb.ToString();
        }
    }
}