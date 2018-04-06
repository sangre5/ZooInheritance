using System;
using System.Collections.Generic; //use Lists

namespace ZooInheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the zoo!");

            Giraffe arnold = new Giraffe("Arnold", 3);
            arnold.WhatAreYou();
            arnold.MakeSound();
            arnold.AnimalCategory();
            arnold.AddDescription("He only has three legs, Benny ate one. Honestly Arnold had it coming");
            arnold.ViewComments(arnold);
            

            Cow mu = new Cow("Mu", 4);
            mu.WhatAreYou();
            mu.MakeSound();
            mu.AnimalCategory();

            Cow mu2 = new Cow("Mumu", 4, true);
            mu2.AnimalCategory();

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
            Benny.AnimalCategory();
            Benny.MakeSound();

     
        }
    }
}
