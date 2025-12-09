using System;
using OOP_opgave;
using OOP_opgave.Animals;

class Program
{
    static void Main()
    {
        Zoo zoo = new Zoo();

        zoo.AddAnimal(new Lion());

        zoo.MakeAllSounds();
        zoo.DescribeAll();
    }
}