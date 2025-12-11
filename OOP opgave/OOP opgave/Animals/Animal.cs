using System;
using System.Linq;
using OOP_opgave.Interfaces;
using OOP_opgave.Enum;
using OOP_opgave.Bodyparts;

namespace OOP_opgave.Animals
{
    public abstract class Animal
    {
        public string Sound { get; protected set; }
        public string Name { get; protected set; }
        public Habitat Habitat { get; protected set; }
        private readonly List<Body> _body = new();
        public void AddBody(Body body) => _body.Add(body);

        public abstract void MakeSound();

        public virtual void Describe() 
        {
            Console.WriteLine($"-----   {Name}  -----");
            Console.WriteLine($"{Name} says: {Sound}");
            Console.WriteLine($"Habitat: {Habitat}");
            
            // Link Q
            Console.WriteLine("Body parts:");
            var grouped = _body
                .GroupBy(b => b.GetType().Name)
                .Select(g => new { Name = g.Key, Count = g.Count() });

            foreach (var part in grouped)
            {
                if (part.Count > 1)
                    Console.WriteLine($"- {part.Name}s x{part.Count}");
                else
                    Console.WriteLine($"- {part.Name}");
            }

        }
    }
}
