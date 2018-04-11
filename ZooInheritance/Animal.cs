using System;
using System.Collections.Generic; //use Lists
using System.Linq;

public abstract class Animal
{
    public string Name { get; set; }
    public int NumberOfLegs { get; set; }
    public bool HasWings { get; set; }
    public enum Category { mammal, reptile, fish, bird };
    public Category GetCategory { get; set; }
    public string Comment { get; set; }
    public static int GreenFood { get; set; }
    public static int RedFood { get; set; }
    

    public virtual void MakeSound()
    {
        Console.WriteLine("I make no sound :(");
    }

    public abstract void WhatAreYou(); //Force all inherited classes to provide a body for this method.

    public void ViewComments(Animal animal)
    {
        Console.WriteLine($"{animal.Name} Comments:");
        Console.WriteLine(animal.Comment);

    }

    public void AddDescription(string comment)
    {
        this.Comment = comment;
    }

    public virtual void EatGreen()
    {

    }

    public virtual void EatAnother(Animal carnivore, Animal herbivore)
    {

    }

    

    public static void AddGreenFood(int food)
    {
        Animal.GreenFood += food;
        Console.WriteLine($"There are {Animal.GreenFood} units of green food");
    }

    public static void AddRedFood(int food)
    {
        Animal.RedFood += food;
        Console.WriteLine($"There are {Animal.RedFood} units of red food");
    }

    

    public abstract void WantsFood(Animal animal);

}

public class Giraffe : Mammal, IHervibore
{

    public override void WhatAreYou()
    {
        Console.WriteLine($"I am a Giraffe!");
    }

    public override void EatGreen()
    {
        Console.WriteLine("Eating trees");
    }

    public override void WantsFood(Animal animal)
    {
        if (Animal.GreenFood >= 20)
        {
            Animal.GreenFood -= 20;
            Console.WriteLine($"{animal.Name} ate 20 units of green food");
        }
        else
        {
            Console.WriteLine("Not enough food");
            Herbivore.Remove(animal);
            Console.WriteLine($"{animal.Name} died of starvation");
        }        
    }

    public Giraffe(string animalName)
    {
        this.Name = animalName;
        this.NumberOfLegs = 4;
        this.GetCategory = Category.mammal;
        Herbivore.Add(this);
    }
}

public class Cow : Mammal, IHervibore
{
    public override void WhatAreYou()
    {
        Console.WriteLine("I am a Cow");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Muuuuuuuuuuuuuuuuuuuuuuuuu");
    }

    public override void EatGreen()
    {
        Console.WriteLine("Eating some grass");
    }

    public override void WantsFood(Animal animal)
    {
        if (Animal.GreenFood >= 15)
        {
            Animal.GreenFood -= 15;
            Console.WriteLine($"{animal.Name} ate 15 units of green food");
        }
        else
        {
            Console.WriteLine("Not enough food");
            Herbivore.Remove(animal);
            Console.WriteLine($"{animal.Name} died of starvation");
        }
    }

    public Cow(string animalName)
    {
        this.Name = animalName;
        this.NumberOfLegs = 4;
        this.GetCategory = Category.mammal;
        Herbivore.Add(this);
    }   
}

public class Shark : Fish, ICarnivore
{
    public override void WhatAreYou()
    {
        Console.WriteLine("I am a Shark");
    }

    public override void WantsFood(Animal animal)
    {
        if (Animal.RedFood >= 5)
        {
            Animal.RedFood -= 5;
            Console.WriteLine($"{animal.Name} ate 5 units of red food");
        }
        else
        {
            Console.WriteLine("Not enough food");
            Random rnd = new Random();
            int h = rnd.Next(0, Herbivore.Count - 1);
            EatAnother(this, Herbivore[h]);
        }
    }

    public override void EatAnother(Animal carnivore, Animal herbivore)
    {
        Console.WriteLine($"{carnivore.Name} is eating the {herbivore} named {herbivore.Name}");
        Herbivore.Remove(herbivore);
    }



    public Shark(string name)
    {
        this.Name = name;
        this.GetCategory = Category.fish;
        this.NumberOfLegs = 0;
        Carnivore.Add(this);
    }

    
}

public class Tiger : Mammal, ICarnivore
{
    public override void WhatAreYou()
    {
        Console.WriteLine("I am a tiger!");
    }

    public override void MakeSound()
    {
        Console.WriteLine("raaaawrr");
    }

    public override void EatAnother(Animal carnivore, Animal herbivore)
    {
        Console.WriteLine($"{carnivore.Name} is eating the {herbivore} named {herbivore.Name}");
        Herbivore.Remove(herbivore);
    }

    public override void WantsFood(Animal animal)
    {
        if (Animal.RedFood >= 10)
        {
            Animal.RedFood -= 10;
            Console.WriteLine($"{animal.Name} ate 10 units of red food");
        }
        else
        {
            Console.WriteLine("Not enough food");
            Random rnd = new Random();
            int h = rnd.Next(0, Herbivore.Count - 1);
            EatAnother(this, Herbivore[h]);
        }
    }

    public Tiger(string name)
    {
        this.Name = name;
        this.GetCategory = Category.mammal;
        this.NumberOfLegs = 4;
        Carnivore.Add(this);

    }
}

public class Lizard : Reptile, IHervibore
{

    public override void WhatAreYou()
    {
        Console.WriteLine("I am a Lizard");
    }

    public override void EatGreen()
    {
        Console.WriteLine("Eating green lizard stuff");
    }

    public override void WantsFood(Animal animal)
    {
        if (Animal.GreenFood >= 1)
        {
            Animal.GreenFood -= 1;
            Console.WriteLine($"{animal.Name} ate 1 unit of green food");
        }
        else
        {
            Console.WriteLine("Not enough food");
            Herbivore.Remove(animal);
            Console.WriteLine($"{animal.Name} died of starvation");
        }
    }

    public Lizard(string name)
    {
        this.NumberOfLegs = 4;
        this.GetCategory = Category.reptile;
        this.Name = name;
        Herbivore.Add(this);
    }
}

public abstract class Mammal : Animal
{
    public int NumberOfBabies { get; set; }

    public void getPregnant(Animal mother)
    {
        Console.WriteLine($"{mother.Name} is pregnant");
    }
}

public abstract class Fish : Animal
{
    public void SwimAround(Animal fish)
    {
        Console.WriteLine($"{fish.Name} is doing some laps");
    }
}

public abstract class Reptile : Animal
{
   
    public void LayEggs(Animal reptile)
    {
        Random rdm = new Random();
        int eggs = rdm.Next(1, 5);
        Console.WriteLine($"{reptile.Name} layed {eggs} eggs.");        
    }
}

public abstract class Bird : Animal
{
    public void FlyAround(Animal bird)
    {
        Console.WriteLine($"{bird.Name} is flapping its birds wings!");
    }
}

public interface IHervibore
{
    void EatGreen();
}

public interface ICarnivore
{
    void EatAnother(Animal carnivore, Animal herbivore);
}