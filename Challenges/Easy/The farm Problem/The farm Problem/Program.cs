using System;
using System.Collections.Generic;
using System.Linq;

namespace The_farm_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = Init();

            while (true)
            {
                Console.WriteLine("Hello User, please enter the number of each animal in the form 2, 3, 5 to get the total legs, in the order :");
                foreach (var item in animals)
                {
                    Console.WriteLine(item.Name);
                }
                string userInput = Console.ReadLine();

                try
                {
                    string[] Animals = userInput.Split(",");
                    if (Animals.Count() == animals.Count())
                    {
                        int Legs = GetLegs(Animals, animals);
                        Console.WriteLine("Total legs: " + Legs);
                        Console.Read();
                    }
                    throw new System.ArgumentException("Parameter cannot be null", "original");

                }
                catch (Exception)
                {

                    Console.WriteLine("Mismatch in objects");
                }
                Console.WriteLine("-------------------------------------------------");
            }
       
        }

        private static int GetLegs(string[] animals, List<Animal> animals_objects)
        {
            int totalLegs= 0;
            for (int i = 0; i < animals_objects.Count; i++)
            {
                totalLegs += animals_objects[i].Number_Legs * int.Parse(animals[i]);
            }
            return totalLegs;
        }

        private static List<Animal> Init()
        {
          
            Animal Chicken = new Animal() 
            {
                Name = "Chicken",
                Number_Legs = 2
            };
          

            Animal Cow = new Animal()
            {
                Name = "Cow",
                Number_Legs = 4
            };

            Animal Pig = new Animal()
            {
                Name = "Pig",
                Number_Legs = 4
            };


            return new List<Animal>() { Chicken, Cow, Pig }; 
        }
    }
}
