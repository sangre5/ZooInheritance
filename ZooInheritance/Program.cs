using System;

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
        }
    }

    public class Animal
    {
        public string name { get; set; }
        public int numberOfLegs { get; set; }
        //public bool hasWings { get; set; }
        //public string category { get; set; }

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
    }
}
