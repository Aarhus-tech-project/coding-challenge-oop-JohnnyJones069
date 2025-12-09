using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_opgave.Animals;

namespace OOP_opgave
{
    public class Zoo
    {
        private readonly List<Animal> _animals = new() ;

        public void AddAnimal(Animal animal) => _animals.Add(animal);

        public void MakeAllSounds()
        {
            foreach (var animal in _animals)
            {
                animal.MakeSound();
            }
        }

        public void DescribeAll()
        {
            foreach (var animal in _animals)
            {
                animal.Describe();
            }
        }
    }
}
