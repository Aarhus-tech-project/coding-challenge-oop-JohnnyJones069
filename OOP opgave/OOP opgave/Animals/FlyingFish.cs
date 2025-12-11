using System;
using OOP_opgave.Interfaces;
using OOP_opgave.Enum;
using OOP_opgave.Category;
using OOP_opgave.Bodyparts;

namespace OOP_opgave.Animals
{
    public class FlyingFish : Fish, IFly, ISwim
    {
        public FlyingFish()
        {
            Name = "Flying Fish";
            Sound = "Splash";
            Habitat = Habitat.Aquatic;

            //Body parts
            AddBody(new Scales());
            AddBody(new Tail());


        }

        public override void MakeSound() => Console.WriteLine($"{Name} says {Sound}");
        public void Fly() => Console.WriteLine("Flying fish is flying");
        public void Swim() => Console.WriteLine("Flying fish is swimming");
    }
}
