using System;
using System.Collections.Generic; //use Lists

namespace ZooInheritance
{    
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the zoo!");

            Giraffe arnold = new Giraffe("Arnold");
            arnold.WhatAreYou();
            arnold.MakeSound();
            arnold.AddDescription("He only has three legs, Benny ate one. Honestly Arnold had it coming");
            arnold.ViewComments(arnold);
            arnold.Eat();
            

            Cow mu = new Cow("Mu");
            mu.WhatAreYou();
            mu.MakeSound();

            Cow mu2 = new Cow("Mumu");

            List<Cow> listOfAnimals = new List<Cow>();
            listOfAnimals.Add(mu);
            listOfAnimals.Add(mu2);

            foreach (Cow cow in listOfAnimals)
            {
                if (cow.HasWings)
                {
                    Console.WriteLine($"A flying cow named, {cow.Name}!");
                }
            }

            Shark Benny = new Shark("Benny");
            Benny.WhatAreYou();
            Benny.MakeSound();
            Benny.SwimAround(Benny);
            Benny.Eat();

            Lizard Dimitri = new Lizard("Dimitri");
            Dimitri.WhatAreYou();
            Dimitri.Eat();

            int animalCount = Animal.AnimalCount();
            Console.WriteLine($"There are {Animal.AnimalCount()} animals at the zoo");

            Animal.AnimalVerbose();
     
        }
    }
}
