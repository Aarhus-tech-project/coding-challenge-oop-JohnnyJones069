using System;
using OOP_opgave.Interfaces;
using OOP_opgave.Enum;
using OOP_opgave.Category;
using OOP_opgave.Bodyparts;

namespace OOP_opgave.Animals
{
    public class Lion : Mammal, IGiveMilk
    {
        public Lion()
        {
            Name = "Lion";
            Sound = "Roar";
            Habitat = Habitat.Terrestrial;

            // Bodyparts
            AddBody(new Leg());
            AddBody(new Leg());
            AddBody(new Leg());
            AddBody(new Leg());
            AddBody(new Tail());
            AddBody(new Fur());

        }

        public override void MakeSound() => Console.WriteLine($"{Name} says {Sound}");
        public void GiveMilk() => Console.WriteLine("Lion gives milk");
    }
}
