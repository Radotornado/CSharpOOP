using System;
public class Startup
{
    public static void Main()
    {
        var rl = new RandomList();
        Console.WriteLine(rl.randomInteger());
        rl.Add("ggg");
        rl.Add(1);
        rl.Add("ttt");

        var test = rl[0];
        var test1 = rl[1];
    }
}