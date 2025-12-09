using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_opgave.Interfaces;

namespace OOP_opgave.Animals
{
    public class Lion : Mammal, IGiveMilk
    {
        public Body Body { get; set; }
        public Habitat Habitat { get; set; }
        public Lion() 
        {
            Name = "Lion";
            Sound = "Roar";
            Habitat = Habitat.Terrestrial;
            Body = new Body { Legs = 4, Wings = 0, HasTail = true, HasBeak = false };
        }

        public void GiveMilk() => Console.WriteLine("Lions give milk");
    }
}
