using OOP_opgave.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_opgave.Animals
{
    public class Orca : Mammal, ISwim
    {
        public Body Body { get; set; }
        public Habitat Habitat { get; set; }

        public Orca()
        {
            Sound = "Click-Click";
            Habitat = Habitat.Aquatic;
            Body = new Body { Legs = 0, Wings = 0, HasTail = true, HasBeak = false };
        }

        public void Swim() => Console.WriteLine("Orca is swimming");
    }
}
