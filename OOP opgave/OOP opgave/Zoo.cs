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

                if (animal is IFly f) f.Fly();
                if (animal is ISwim s) s.Swim();
                if (animal is ILayEggs e) e.LayEggs();
                if (animal is IGiveMilk m) m.GiveMilk();
                if (animal is IDig d) d.Dig();

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
