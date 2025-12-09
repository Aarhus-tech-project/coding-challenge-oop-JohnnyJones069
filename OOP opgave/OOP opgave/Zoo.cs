using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_opgave
{
    public class Zoo
    {
        private List<Animal> zoo = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            zoo.Add(animal);
        }

        public void MakeAllSound()
        {
            foreach (var animal in zoo)
            {
                animal.MakeSound();
            }
        }
    }
}
