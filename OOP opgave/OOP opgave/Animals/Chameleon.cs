using System;
using OOP_opgave.Interfaces;
using OOP_opgave.Enum;
using OOP_opgave.Category;
using OOP_opgave.Bodyparts;

namespace OOP_opgave.Animals
{
    public class Chameleon : Lizard, ILayEggs
    {
        public Chameleon()
        {
            Name = "Chameleon";
            Sound = "Click";
            Habitat = Habitat.Amphibious;

            //Bodyparts
            AddBody(new Leg());
            AddBody(new Leg());
            AddBody(new Leg());
            AddBody(new Leg());
            AddBody(new Tail());
            AddBody(new Scales());

        }

        public override void MakeSound() => Console.WriteLine($"{Name} says {Sound}");
        public void LayEggs() => Console.WriteLine("Chameleon lays eggs");
    }
}
