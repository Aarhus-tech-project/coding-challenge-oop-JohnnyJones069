using System;
using OOP_opgave.Interfaces;
using OOP_opgave.Enum;

namespace OOP_opgave.Animals
{
    public abstract class Animal
    {
        public string Sound { get; protected set; }
        public string Name { get; protected set; }
        public Habitat Habitat { get; protected set; }
        public Body Body { get; protected set; }

        public abstract void MakeSound();

        public virtual void Describe() 
        {
            Console.WriteLine($"-----   {Name}  -----");
            Console.WriteLine($"{Name} says: {Sound}");
            Console.WriteLine($"Habitat: {Habitat}");

            if (Body != null)
                Console.WriteLine($"Legs: {Body.Legs} | Wings: {Body.Wings} | Tail: {Body.HasTail} | Beak: {Body.HasBeak}");
        }
    }
}
