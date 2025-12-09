using System;
using OOP_opgave.Interfaces;
using OOP_opgave.Enum;

namespace OOP_opgave.Animals
{
    public class Orca : Mammal, ISwim
    {
        public Orca()
        {
            Sound = "Click-Click";
            Habitat = Habitat.Aquatic;
            Body = new Body { Legs = 0, Wings = 0, HasTail = true, HasBeak = false };
        }
        public override void MakeSound() => Console.WriteLine($"{Name} says {Sound}");
        public void Swim() => Console.WriteLine("Orca is swimming");
    }
}
