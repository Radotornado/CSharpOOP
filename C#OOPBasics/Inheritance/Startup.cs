public class Startup
{
    public static void Main()
    {
        var cat = new Cat
        {
            Name = "Silvestar",
            Age = 50
        };
        var bunny = new Bunny
        {
            Name = "Bugs",
            Age = 75
        };

        System.Console.WriteLine(cat.SayHello());
        System.Console.WriteLine(bunny.SayHello());
        System.Console.WriteLine(bunny.Color);
    }
}
