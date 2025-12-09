
using OOP_opgave.Enum;
using OOP_opgave.Interfaces;
using System;

namespace OOP_opgave.Animals
{
    public class Bat : Mammal, IFly, IGiveMilk
    {
        public Bat()
        {
            Name = "Bat";
            Sound = "Screech";
            Habitat = Habitat.Flying;
            Body = new Body { Legs = 2, Wings = 2, HasTail = true, HasBeak = false };
        }

        public override void MakeSound() => Console.WriteLine($"{Name} says {Sound}");
        public void Fly() => Console.WriteLine("Bat is flying");
        public void GiveMilk() => Console.WriteLine("Bat gives milk");
    }
}
