
using OOP_opgave.Bodyparts;
using OOP_opgave.Category;
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
            Habitat = Habitat.Air;

            // Bodyparts
            AddBody(new Leg());
            AddBody(new Leg());
            AddBody(new Wing());
            AddBody(new Wing());
            AddBody(new Fur());
        }

        public override void MakeSound() => Console.WriteLine($"{Name} says {Sound}");
        public void Fly() => Console.WriteLine("Bat is flying");
        public void GiveMilk() => Console.WriteLine("Bat gives milk");
    }
}
