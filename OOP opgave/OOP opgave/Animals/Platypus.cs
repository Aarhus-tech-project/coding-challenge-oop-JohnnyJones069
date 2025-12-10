using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using OOP_opgave.Interfaces;
using OOP_opgave.Enum;
using OOP_opgave.Category;
using OOP_opgave.Bodyparts;

namespace OOP_opgave.Animals
{
    public class Platypus : Mammal, ILayEggs, ISwim
    {
        public Platypus()
        {
            Name = "Platypus";
            Sound = "Growl";
            Habitat = Habitat.Amphibious;

            //Bodyparts
            AddBody(new Fur());
            AddBody(new Leg());
            AddBody(new Leg());
            AddBody(new Leg());
            AddBody(new Leg());
            AddBody(new Tail());
            AddBody(new Beak());

        }

        public override void MakeSound() => Console.WriteLine($"{Name} says {Sound}");
        public void LayEggs() => Console.WriteLine("Platypus lays eggs");
        public void Swim() => Console.WriteLine("Platypus is swimming");
    }
}
