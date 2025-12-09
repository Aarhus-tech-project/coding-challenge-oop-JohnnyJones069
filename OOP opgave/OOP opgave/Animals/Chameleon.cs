using OOP_opgave.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_opgave.Animals
{
    public class Chameleon : Lizard, ILayEggs
    {
        public Body Body { get; set; }
        public Habitat Habitat { get; set; }
        public Chameleon() 
        {
            Name = "Chameleon";
            Sound = "Silent hiss";
            Habitat = Habitat.Arboreal;
            Body = new Body { Legs = 4, Wings = 0, HasTail = true, HasBeak = false};
        }

        public void LayEggs() => Console.WriteLine("Chameleons lays eggs.");
    }
}
