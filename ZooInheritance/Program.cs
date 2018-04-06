using System;
using System.Collections.Generic; //use Lists

namespace ZooInheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Giraffe arnold = new Giraffe("Arnold", 3);
            arnold.WhatAreYou();
            arnold.MakeSound();

            Cow mu = new Cow("Mu", 4);
            mu.WhatAreYou();
            mu.MakeSound();

            Cow mu2 = new Cow("Mumu", 4, true);

            List<Cow> listOfAnimals = new List<Cow>();
            listOfAnimals.Add(mu);
            listOfAnimals.Add(mu2);

            foreach (Cow cow in listOfAnimals)
            {
                if (cow.hasWings)
                {
                    Console.WriteLine($"A flying cow named, {cow.name}!");
                }
            }

      
        }
    }

    public class Animal
    {
        public string name { get; set; }
        public int numberOfLegs { get; set; }
        public bool hasWings { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("I make no sound :(");
        }
        
    }

    public class Giraffe : Animal
    {
        

        public void WhatAreYou()
        {
            Console.WriteLine("I am a Giraffe");
        }

        public Giraffe(string animalName, int legs)
        {
            this.name = animalName;
            this.numberOfLegs = numberOfLegs;
        }
    }

    public class Cow : Animal
    {

        public void WhatAreYou()
        {
            Console.WriteLine("I am a Cow");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Muuuuuuuuuuuuuuuuuuuuuuuuu");
        }

        public Cow(string animalName, int legs)
        {
            this.name = animalName;
            this.numberOfLegs = numberOfLegs;
        }

        public Cow(string animalName, int legs, bool wings)
        {
            this.name = animalName;
            this.numberOfLegs = legs;
            this.hasWings = wings;
        }
    }
}
