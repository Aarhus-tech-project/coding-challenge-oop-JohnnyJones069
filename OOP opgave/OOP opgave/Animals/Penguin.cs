using System;
using OOP_opgave.Interfaces;
using OOP_opgave.Enum;

namespace OOP_opgave.Animals
{
    public class Penguin : Bird, ISwim, ILayEggs
    {
        public Penguin()
        {
            Name = "Penguin";
            Sound = "Honk";
            Habitat = Habitat.Aquatic;
            Body = new Body { Legs = 2, Wings = 2, HasTail = true, HasBeak = true };
        }

        public override void MakeSound() => Console.WriteLine($"{Name} says {Sound}");
        public void Swim() => Console.WriteLine("Penguin is swimming");
        public void LayEggs() => Console.WriteLine("Penguin lays eggs");
    }
}
