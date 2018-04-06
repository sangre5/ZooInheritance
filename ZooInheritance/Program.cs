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

            Shark Benny = new Shark();
            Benny.AnimalCategory();
            Benny.MakeSound();

      
        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
        public bool HasWings { get; set; }
        public enum Category { mammal, reptile, fish, fantasy };
        public Category GetCategory { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("I make no sound :(");
        }

        public void AnimalCategory()
        {
            Console.WriteLine($"I am a {GetCategory}");
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
            this.Name = animalName;
            this.NumberOfLegs = NumberOfLegs;
            this.GetCategory = Category.mammal;

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
            this.Name = animalName;
            this.NumberOfLegs = NumberOfLegs;
            this.GetCategory = Category.mammal;
        }

        public Cow(string animalName, int legs, bool wings)
        {
            this.Name = animalName;
            this.NumberOfLegs = legs;
            this.HasWings = wings;
            this.GetCategory = Category.fantasy;
        }
    }

    public class Shark : Animal
    {
        public void WhatAreYou()
        {
            Console.WriteLine("I am a Shark");
        }

        public Shark()
        {
            this.GetCategory = Category.fish;
        }
    }
}
