using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework61Zoo
{
    class Zoo
    {
        private string name;
        public string Name
        {
            get
            { return name; }
        }
        private List<Animal> animalsList;
        public void AddAnimal(Animal animal)
        {
            animalsList.Add(animal);
            Console.WriteLine($"{name}: Animal {animal.Breed} with name {animal.Name} added.");
            animal.SetZoo(this);
        }
        public void TransferAnimal(Animal animal, Zoo zoo)
        {
            animalsList.Remove(animal);                        
            Console.WriteLine($"{name}: Animal {animal.Breed} with name {animal.Name} transfered to zoo: {zoo.name}.");
            zoo.AddAnimal(animal);
        }
        public void FeedAnimals()
        {
            foreach(Animal animal in animalsList)
            {
                animal.GetFed();
            }
        }
        public Zoo(string name)
        {
            this.name = name;
            Console.WriteLine($"{name} zoo initialized.");
            animalsList = new List<Animal>();
        }
    }
}
