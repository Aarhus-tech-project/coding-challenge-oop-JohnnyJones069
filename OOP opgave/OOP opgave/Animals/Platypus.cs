using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using OOP_opgave.Interfaces;
using OOP_opgave.Enum;

namespace OOP_opgave.Animals
{
    public class Platypus : Mammal, ILayEggs, ISwim
    {
        public Platypus()
        {
            Name = "Platypus";
            Sound = "Growl";
            Habitat = Habitat.Amphibious;
            Body = new Body { Legs = 4, Wings = 0, HasTail = true, HasBeak = true };
        }

        public override void MakeSound() => Console.WriteLine($"{Name} says {Sound}");
        public void LayEggs() => Console.WriteLine("Platypus lays eggs");
        public void Swim() => Console.WriteLine("Platypus is swimming");
    }
}
