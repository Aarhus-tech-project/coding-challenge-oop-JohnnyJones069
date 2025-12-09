using System;
using OOP_opgave.Interfaces;
using OOP_opgave.Enum;

namespace OOP_opgave.Animals
{
    public class Lion : Mammal, IGiveMilk
    {
        public Lion()
        {
            Name = "Lion";
            Sound = "Roar";
            Habitat = Habitat.Terrestrial;
            Body = new Body { Legs = 4, Wings = 0, HasTail = true, HasBeak = false };
        }

        public override void MakeSound() => Console.WriteLine($"{Name} says {Sound}");
        public void GiveMilk() => Console.WriteLine("Lion gives milk");
    }
}
