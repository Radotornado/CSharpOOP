using System;

public class Penguin : Animal
{
    public int numberOfWings;
    public Penguin(string name, string favouriteFood, int age)
        : base(name, favouriteFood, age)
    {
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Peep");
    }

}