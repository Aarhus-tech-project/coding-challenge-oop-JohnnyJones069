using System;
using OOP_opgave;
using OOP_opgave.Animals;

class Program
{
    static void Main()
    {
        Zoo zoo = new Zoo();

        zoo.AddAnimal(new Lion());
        zoo.AddAnimal(new Chameleon());
        zoo.AddAnimal(new ElectricEel());
        zoo.AddAnimal(new Penguin());
        zoo.AddAnimal(new Bat());
        zoo.AddAnimal(new Platypus());
        zoo.AddAnimal(new FlyingFish());

        zoo.ShowAllAnimals();

        zoo.MakeAllSounds();
    }
}