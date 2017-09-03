using System;

public class Startup
{
    public static void Main()
    {
        var dog = new Dog();
        Console.WriteLine(dog.Eat());
        Console.WriteLine(dog.Bark());

        var cat = new Cat();
        Console.WriteLine(cat.Eat());
        Console.WriteLine(cat.Meow());
    }
}