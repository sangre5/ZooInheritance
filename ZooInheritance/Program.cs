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

            CoolZoo.AddAnimal();

            Console.WriteLine($"There are {CoolZoo.AnimalCount()} animals in the zoo");
            

            
            
               
        }

    }
}
