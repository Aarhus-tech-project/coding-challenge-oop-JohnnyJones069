using System;

namespace OOP_opgave
{
    public enum Habitat
    {
        Terrestrial,
        Aquatic,
        Arboreal,
        Flying
    }

    public enum LifeStage
    {
        Larva,
        Young,
        Adult
    }
    public class Body
    {
        public int Legs { get; set; }
        public int Wings { get; set; }
        public bool HasTail { get; set; }
        public bool HasBeak { get; set; }
    }
}
