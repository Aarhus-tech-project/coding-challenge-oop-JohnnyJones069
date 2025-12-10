using System;
using OOP_opgave.Interfaces;
using OOP_opgave.Enum;
using OOP_opgave.Category;
using OOP_opgave.Category;
using OOP_opgave.Bodyparts;

namespace OOP_opgave.Animals
{
    public class Penguin : Bird, ISwim, ILayEggs
    {
        public Penguin()
        {
            Name = "Penguin";
            Sound = "Honk";
            Habitat = Habitat.Aquatic;

            // Bodyparts
            AddBody(new Leg());
            AddBody(new Leg());
            AddBody(new Wing());
            AddBody(new Wing());
            AddBody(new Beak());
            AddBody(new Tail());
            AddBody(new Feather());






        }

        public override void MakeSound() => Console.WriteLine($"{Name} says {Sound}");
        public void Swim() => Console.WriteLine("Penguin is swimming");
        public void LayEggs() => Console.WriteLine("Penguin lays eggs");
    }
}
