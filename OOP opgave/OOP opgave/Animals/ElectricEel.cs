using OOP_opgave.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_opgave.Animals
{
    public class ElectricEel : Fish, ISwim, ILayEggs
    {
        public Body Body { get; set; }
        public Habitat Habitat { get; set; }

        public ElectricEel() 
        {
            Name = "Electric Eel";
            Sound = "BZZZZT";
            Habitat = Habitat.Aquatic;
            Body = new Body { Legs = 0, Wings = 0, HasTail = true, HasBeak = false};
        }

        public void Swim() => Console.WriteLine("Electric Eel is swimming");
        public void LayEggs() => Console.WriteLine("Electric Eel lays Eggs");
    }
}
