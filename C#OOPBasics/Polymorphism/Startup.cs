using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        Animal pingy = new Penguin("Pingy", "Seaweed", 9);
        Animal betsy = new Penguin("Betsy", "slama", 7);
        List<Animal> animals = new List<Animal>();
        animals.Add(pingy);
        animals.Add(betsy);
        foreach (var animal in animals)
        {
            animal.MakeNoise();
            if (animal.GetType() == typeof(Penguin))
            {
                var penguin = (animal as Penguin).numberOfWings;
            }
        }



    }
}
