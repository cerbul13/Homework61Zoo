using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework61Zoo
{
    class Animal
    {
        private string name;
        private string breed;
        private string favoriteFood;
        private Zoo zoo;
        public string Name 
        { 
            get 
            {
                return name;
            } 
            set
            {
                name = value;
            }
        }
        public string FavoriteFood
        {
            get
            {
                return favoriteFood;
            }
            set
            {
                favoriteFood = value;
            }
        }
        public string Breed
        {
            get
            {
                return breed;
            }
        }
        public Animal(string name, string breed, string favoriteFood, Zoo zoo)
        {
            this.Name = name;
            this.breed = breed;
            this.FavoriteFood = favoriteFood;
            zoo.AddAnimal(this);
            this.SetZoo(zoo);
        }
        public Animal(string name, string breed, string favoriteFood)
        {
            this.Name = name;
            this.breed = breed;
            this.FavoriteFood = favoriteFood;
        }
        public void SetZoo(Zoo zoo)
        {
            this.zoo = zoo;
        }
        public void GetFed()
        {
            if (zoo == null) { Console.WriteLine($"<unassigned>: I am a {Breed} called {Name} and I am eating {FavoriteFood}."); }
            else
            { Console.WriteLine($"{zoo.Name}: I am a {Breed} called {Name} and I am eating {FavoriteFood}."); }
        }
    }
}
