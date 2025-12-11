using System;
using OOP_opgave.Interfaces;
using OOP_opgave.Enum;
using OOP_opgave.Category;
using OOP_opgave.Bodyparts;

namespace OOP_opgave.Animals
{
    public class Orca : Mammal, ISwim
    {
        public Orca()
        {
            Sound = "Click-Click";
            Habitat = Habitat.Aquatic;

            //Bodyparts
            AddBody(new Tail());
        }
        public override void MakeSound() => Console.WriteLine($"{Name} says {Sound}");
        public void Swim() => Console.WriteLine("Orca is swimming");
    }
}
