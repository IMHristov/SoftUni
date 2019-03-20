using System;
using System.Collections.Generic;

namespace Animals2
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string animal = Console.ReadLine();


            
                while (animal != "Beast!")
                {
                 
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                string gender = input[2];
                try
                {
                    switch (animal)
                {
                    case "Cat":
                        animals.Add(new Cat(name, age, gender));
                        break;
                    case "Tomcat":
                        animals.Add(new Tomcat(name, age, gender));
                        break;
                    case "Kitten":
                        animals.Add(new Kitten(name, age, gender));
                        break;
                    case "Dog":
                        animals.Add(new Dog(name, age, gender));
                        break;
                    case "Frog":
                        animals.Add(new Frog(name, age, gender));
                        break;
                   
                }
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }
                animal = Console.ReadLine();

                }
            
            

            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine(animals[i].ToString()); 
            }
        }
    }
}
