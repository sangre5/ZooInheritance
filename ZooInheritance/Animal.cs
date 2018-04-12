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
        Console.WriteLine("Eating some fren stuff");
    }

    public virtual void EatFood(Animal carnivore, Animal herbivore)
    {
        Console.WriteLine("Eating my zoo pals");
    }

    public virtual void EatFood(Animal animal)
    {
        Console.WriteLine("Eating something I found");
    }
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

    public override void EatFood(Animal animal)
    {
        if (ZooInheritance.Zoo.GreenFood >= 20)
        {
            ZooInheritance.Zoo.GreenFood -= 20;
            Console.WriteLine($"{animal.Name} ate 20 units of green food");
        }
        else
        {
            Console.WriteLine("Not enough food");
            ZooInheritance.Zoo.RemoveAnimal(animal);
            Console.WriteLine($"{animal.Name} died of starvation");
        }        
    }

    public Giraffe(string animalName)
    {
        this.Name = animalName;
        this.NumberOfLegs = 4;
        this.GetCategory = Category.mammal;
        ZooInheritance.Zoo.AddAnimal(this);
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

    public override void EatFood(Animal animal)
    {
        if (ZooInheritance.Zoo.GreenFood >= 15)
        {
            ZooInheritance.Zoo.GreenFood -= 15;
            Console.WriteLine($"{animal.Name} ate 15 units of green food");
        }
        else
        {
            Console.WriteLine("Not enough food");
            ZooInheritance.Zoo.RemoveAnimal(animal);
            Console.WriteLine($"{animal.Name} died of starvation");
        }
    }

    public Cow(string animalName)
    {
        this.Name = animalName;
        this.NumberOfLegs = 4;
        this.GetCategory = Category.mammal;
        ZooInheritance.Zoo.AddAnimal(this);
    }   
}

public class Shark : Fish, ICarnivore
{
    public override void WhatAreYou()
    {
        Console.WriteLine("I am a Shark");
    }

    public override void EatFood(Animal animal)
    {
        if (ZooInheritance.Zoo.RedFood >= 5)
        {
            ZooInheritance.Zoo.RedFood -= 5;
            Console.WriteLine($"{animal.Name} ate 5 units of red food");
        }
        else
        {
            Console.WriteLine("Not enough food");
            Random rnd = new Random();
            int h = rnd.Next(0, ZooInheritance.Zoo.HerbivoreCount() - 1);
            //eatanother(this, zooinheritance.zoo.eatanother[h]);
        }
    }

    public override void EatFood(Animal carnivore, Animal herbivore)
    {
        if (ZooInheritance.Zoo.RedFood >= 5)
        {
            ZooInheritance.Zoo.RedFood -= 5;
            Console.WriteLine($"{carnivore.Name} ate 5 units of red food");
        }
        else
        {
            Console.WriteLine("Not enough food");
            ZooInheritance.Zoo.RemoveAnimal(herbivore);
            Console.WriteLine($"{carnivore.Name} ate {herbivore.Name}");

        }



        Console.WriteLine($"{carnivore.Name} is eating the {herbivore} named {herbivore.Name}");
        ZooInheritance.Zoo.RemoveAnimal(herbivore);
    }



    public Shark(string name)
    {
        this.Name = name;
        this.GetCategory = Category.fish;
        this.NumberOfLegs = 0;
        ZooInheritance.Zoo.AddAnimal(this);
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

    

    public override void EatFood(Animal carnivore, Animal herbivore)
    {
        if (ZooInheritance.Zoo.RedFood >= 10)
        {
            ZooInheritance.Zoo.RedFood -= 10;
            Console.WriteLine($"{carnivore.Name} ate 10 units of red food");
        }
        else
        {
            Console.WriteLine("Not enough food");
            Console.WriteLine("Not enough food");
            ZooInheritance.Zoo.RemoveAnimal(herbivore);
            Console.WriteLine($"{carnivore.Name} ate {herbivore.Name}");
        }
    }

    public Tiger(string name)
    {
        this.Name = name;
        this.GetCategory = Category.mammal;
        this.NumberOfLegs = 4;
        ZooInheritance.Zoo.AddAnimal(this);
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

    public override void EatFood(Animal animal)
    {
        if (ZooInheritance.Zoo.GreenFood >= 1)
        {
            ZooInheritance.Zoo.GreenFood -= 1;
            Console.WriteLine($"{animal.Name} ate 1 unit of green food");
        }
        else
        {
            Console.WriteLine("Not enough food");
            ZooInheritance.Zoo.RemoveAnimal(animal);
            Console.WriteLine($"{animal.Name} died of starvation");
        }
    }

    public Lizard(string name)
    {
        this.NumberOfLegs = 4;
        this.GetCategory = Category.reptile;
        this.Name = name;
        ZooInheritance.Zoo.AddAnimal(this);
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
    void EatFood(Animal carnivore, Animal herbivore);
}