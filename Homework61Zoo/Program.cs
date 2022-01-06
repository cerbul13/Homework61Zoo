using System;

namespace Homework61Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo1 = new Zoo("Zoo1");
            Zoo zoo2 = new Zoo("Zoo2");

            Animal horse1 = new Animal("Horsie1", "horse", "apples", zoo1);
            Animal horse2 = new Animal("Horsie2", "horse", "carrots");
            zoo1.AddAnimal(horse2);
            Animal cow1 = new Animal("Cowey1", "cow", "spice", zoo2);            
            zoo1.FeedAnimals();
            zoo2.FeedAnimals();
            zoo1.TransferAnimal(horse2, zoo2);
            zoo1.FeedAnimals();
            zoo2.FeedAnimals();

        }
    }
}
