using OOP_opgave.Interfaces;
using OOP_opgave.Enum;
using System;
using OOP_opgave.Category;
using OOP_opgave.Bodyparts;

namespace OOP_opgave.Animals
{
    public class ElectricEel : Fish, ISwim
    {
        public ElectricEel()
        {
            Name = "Electric Eel";
            Sound = "Zap";
            Habitat = Habitat.Aquatic;

            // Bodyparts
            AddBody(new Tail());
            AddBody(new Scales());
        }

        public override void MakeSound() => Console.WriteLine($"{Name} says {Sound}");
        public void Swim() => Console.WriteLine("Electric eel is swimming");
    }
}
