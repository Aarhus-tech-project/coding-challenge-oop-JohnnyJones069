using System;

namespace OOP_opgave
{
    public abstract class Animal
    {
        public string Sound {  get; protected set; }
        public string Name { get; protected set; }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} Says {Sound}");
        }
    }
}
