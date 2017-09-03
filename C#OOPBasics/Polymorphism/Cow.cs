using System;

public class Cow : Animal
{
    public Cow(string name, string favouriteFood, int age)
        : base(name, favouriteFood, age)
    {
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Moooo");
    }

    public override void StateFavFood()
    {
        base.StateFavFood();
        Console.WriteLine("And I am also a cow");
    }
}