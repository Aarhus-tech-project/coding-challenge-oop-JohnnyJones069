using System;
using OOP_opgave.Interfaces;
using OOP_opgave.Enum;

namespace OOP_opgave.Animals
{
    public class Chameleon : Lizard, ILayEggs
    {
        public Chameleon()
        {
            Name = "Chameleon";
            Sound = "Click";
            Habitat = Habitat.Terrestrial;
            Body = new Body { Legs = 4, Wings = 0, HasTail = true, HasBeak = false };
        }

        public override void MakeSound() => Console.WriteLine($"{Name} says {Sound}");
        public void LayEggs() => Console.WriteLine("Chameleon lays eggs");
    }
}
