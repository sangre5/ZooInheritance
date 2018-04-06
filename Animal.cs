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