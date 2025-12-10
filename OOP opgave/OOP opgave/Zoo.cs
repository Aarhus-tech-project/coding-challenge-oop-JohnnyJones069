using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_opgave.Animals;
using OOP_opgave.Interfaces;

namespace OOP_opgave
{
    public class Zoo
    {
        private readonly List<Animal> _animals = new() ;

        public void AddAnimal(Animal animal) => _animals.Add(animal);

        public void ShowAllAnimals()
        {
            foreach (var animal in _animals)
            {
                animal.Describe();

                if (this is IFly f) f.Fly();
                if (this is ISwim s) s.Swim();
                if (this is ILayEggs e) e.LayEggs();
                if (this is IGiveMilk m) m.GiveMilk();
                if (this is IDig d) d.Dig();

                Console.WriteLine();
            }
        }

        public void MakeAllSounds()
        {
            foreach (var animal in _animals)
            {
                animal.MakeSound();
            }
        }
    }
}
