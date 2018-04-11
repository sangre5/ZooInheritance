using System;
using System.Collections.Generic;
using System.Text;

namespace ZooInheritance
{
    class Zoo
    {
        private static IList<Animal> Herbivore = new List<Animal>();
        private static IList<Animal> Carnivore = new List<Animal>();

        public void AddAnimal()
        {
            Herbivore.Add(new Giraffe("Arnold"));
        }

        public int AnimalCount()
        {
            return Herbivore.Count + Carnivore.Count;
        }

        public void AnimalVerbose()
        {
            if (Herbivore.Count > 0)
            {
                Console.WriteLine("Herbivore List:");
                foreach (Animal animal in Herbivore)
                {
                    Console.WriteLine(animal);
                }
            }

            if (Carnivore.Count > 0)
            {
                Console.WriteLine("Carnivore List:");
                foreach (Animal animal in Carnivore)
                {
                    Console.WriteLine(animal);
                }
            }

        }

        public static void KillHervibores()
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
    }

    

    
}
