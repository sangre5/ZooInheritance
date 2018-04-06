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

    public abstract class Animal
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
        public bool HasWings { get; set; }
        public enum Category { mammal, reptile, fish, fantasy };
        public Category GetCategory { get; set; }
        public string Comment { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("I make no sound :(");
        }

        public void AnimalCategory()
        {
            Console.WriteLine($"I am a {GetCategory}");
        }

        public abstract void WhatAreYou(); //Force all inherited classes to provide a body for this method.

        public abstract void ViewComments(Animal animal);
        
        public void AddDescription(string comment)
        {
            this.Comment = comment;
        }
    
    }

    public class Giraffe : Animal
    {   
        

        public override void WhatAreYou()
        {
            Console.WriteLine($"I am a Giraffe, with {NumberOfLegs} legs");            
        }

        public override void ViewComments(Animal animal)
        {
            Console.WriteLine(Comment);
        }


        public Giraffe(string animalName, int legs)
        {
            this.Name = animalName;
            this.NumberOfLegs = legs;
            this.GetCategory = Category.mammal;

        }

        
    }

    public class Cow : Animal
    {

        public override void WhatAreYou()
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

        public override void ViewComments(Animal animal)
        {
            Console.WriteLine(Comment);
        }
    }

    public class Shark : Animal
    {
        public override void WhatAreYou()
        {
            Console.WriteLine("I am a Shark");
        }

        public Shark(string name)
        {
            this.Name = name;
            this.GetCategory = Category.fish;
        }

        public override void ViewComments(Animal animal)
        {
            Console.WriteLine(Comment);
        }
    }
}
