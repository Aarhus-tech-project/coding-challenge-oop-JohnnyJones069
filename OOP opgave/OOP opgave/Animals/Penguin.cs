using OOP_opgave.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_opgave.Animals
{
    public class Penguin : Bird, ISwim, ILayEggs
    {
        public Body Body { get; set; }
        public Habitat Habitat { get; set; }

        public Penguin()
        {
            Name = "Penguin";
            Sound = "Honk";
            Habitat = Habitat.Aquatic;
            Body = new Body { Legs = 2, Wings = 2, HasTail = true, HasBeak = true};
        }

        public void Swim() => Console.WriteLine("Penguin is swimming");
        public void LayEggs() => Console.WriteLine("Penguin lays Eggs");
    }
}
