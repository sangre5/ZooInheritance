using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ZooInheritance
{
    class Zoo
    {
        private static IList<Animal> Herbivore = new List<Animal>();
        private static IList<Animal> Carnivore = new List<Animal>();

        public static int GreenFood { get; set; }
        public static int RedFood { get; set; }



        public void AddAnimals()
        {
            new Giraffe("Arnold");
            new Cow("Mu");
            new Lizard("Dimitri");
            new Tiger("Malu");
            new Shark("Benny");
        }

        public int AnimalCount()
        {
            return Herbivore.Count + Carnivore.Count;
        }

        public static int HerbivoreCount()
        {
            return Herbivore.Count;
        }

        public static int CarnivoreCount()
        {
            return Carnivore.Count;
        }

        public void AnimalVerbose()
        {
            if (Herbivore.Count > 0)
            {
                Console.WriteLine("Herbivore List:");
                foreach (Animal animal in Herbivore)
                {
                    Console.WriteLine($"{animal} named {animal.Name}");
                }
            }

            if (Carnivore.Count > 0)
            {
                Console.WriteLine("Carnivore List:");
                foreach (Animal animal in Carnivore)
                {
                    Console.WriteLine($"{animal} named {animal.Name}");
                }
            }
        }

        public void KillHervibores()
        {
        Random carne = new Random();
        Random herbi = new Random();

        while (Herbivore.Count > 0 && Carnivore.Count > 0)
            {            
            int c = carne.Next(0, Carnivore.Count);
            int h = herbi.Next(0, Herbivore.Count - 1);

            Console.WriteLine($"{Herbivore[h].Name} was eaten by {Carnivore[c].Name}");
            Herbivore.Remove(Herbivore[h]);
            }
        }

        public static void RemoveAnimal(Animal animal)
        {
            if (animal is IHervibore)
            {
                Herbivore.Remove(animal);
            }
            else if (animal is ICarnivore)
            {
                Carnivore.Remove(animal);
            }           
        }

        public static void AddAnimal(Animal animal)
        {
            if (animal is IHervibore)
            {
                Herbivore.Add(animal);
            }
            else if (animal is ICarnivore)
            {
                Carnivore.Add(animal);
            }
        }

        public void AddGreenFood(int food)
        {
            GreenFood += food;
            Console.WriteLine($"There are {GreenFood} units of green food");
        }

        public void AddRedFood(int food)
        {
            RedFood += food;
            Console.WriteLine($"There are {RedFood} units of red food");
        }

        public void WantsFood(string animalName)
        {
            List<Animal> All = new List<Animal>();
            All.AddRange(Herbivore);
            All.AddRange(Carnivore);
            Animal animal = All .Where(a => a.Name == animalName).FirstOrDefault();

            if (animal != null)
            {
                if (animal is IHervibore)
                {
                    animal.EatFood(animal);
                }
                else if(animal is ICarnivore)
                {
                    Random rnd = new Random();
                    int h = rnd.Next(0, ZooInheritance.Zoo.HerbivoreCount());
                    animal.EatFood(animal, Herbivore[h]);
                }
                
            }
            else
            {
                Console.WriteLine("No animal with that name");
            }
            
        }
    }    
}
