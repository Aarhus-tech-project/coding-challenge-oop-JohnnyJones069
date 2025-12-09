using OOP_opgave.Interfaces;
using OOP_opgave.Enum;
using System;

namespace OOP_opgave.Animals
{
    public class ElectricEel : Fish, ISwim
    {
        public ElectricEel()
        {
            Name = "Electric Eel";
            Sound = "Zap";
            Habitat = Habitat.Aquatic;
            Body = new Body { Legs = 0, Wings = 0, HasTail = true, HasBeak = false };
        }

        public override void MakeSound() => Console.WriteLine($"{Name} says {Sound}");
        public void Swim() => Console.WriteLine("Electric eel is swimming");
    }
}
