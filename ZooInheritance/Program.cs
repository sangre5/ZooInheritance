using System;
using System.Collections.Generic; //use Lists
using System.Linq;

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
            arnold.EatGreen();
            
            Cow mu = new Cow("Mu");
            mu.WhatAreYou();
            mu.MakeSound();

            Cow mu2 = new Cow("Mumu");
                                    
            Shark Benny = new Shark("Benny");
            Benny.WhatAreYou();
            Benny.MakeSound();
            Benny.SwimAround(Benny);
            Benny.EatAnother(Benny, mu);

            Lizard Dimitri = new Lizard("Dimitri");
            Dimitri.WhatAreYou();
            Dimitri.EatGreen();

            Lizard Ana = new Lizard("Ana");
            Ana.WhatAreYou();
            Ana.MakeSound();
            Ana.LayEggs(Ana);

            Tiger Malu = new Tiger("Malu");
            Malu.WhatAreYou();
            Malu.MakeSound();
            Malu.EatAnother(Malu, Dimitri);


            Console.WriteLine($"There are {Animal.AnimalCount()} animals at the zoo");

            
            //Animal.KillHervibores();

            Animal.AnimalCount();
            Animal.AnimalVerbose();

            //Animal.AddGreenFood(50);

            Animal.AddRedFood(1);

            arnold.WantsFood(arnold);
            Malu.WantsFood(Malu);

            Animal.AnimalVerbose();

            Animal.KillHervibores();

            Animal.AnimalVerbose();
               
        }

    }
}
