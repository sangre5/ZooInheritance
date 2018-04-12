using System;
using System.Collections.Generic; //use Lists
using System.Linq;

namespace ZooInheritance
{    
    public class Program
    {
        static void Main(string[] args)
        {
            Zoo CoolZoo = new Zoo();

            Console.WriteLine("Welcome to the zoo!");

            CoolZoo.AddAnimals();

            Console.WriteLine($"There are {CoolZoo.AnimalCount()} animals in the zoo");

            CoolZoo.AnimalVerbose();

            //CoolZoo.KillHervibores();

            CoolZoo.AnimalVerbose();

            CoolZoo.AddGreenFood(5);
            CoolZoo.AddRedFood(5);

            CoolZoo.WantsFood("Malu");
            CoolZoo.WantsFood("Arnold");

            CoolZoo.KillHervibores();

            CoolZoo.AnimalVerbose();
            
        }

    }
}
