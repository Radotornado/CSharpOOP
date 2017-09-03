﻿using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var player = new Player();
        player.Eat(Console.ReadLine()
            .Split()
            .Where(fn => fn != string.Empty)
            .Select(fn => FoodFactory.GetFood(fn)));

        Console.WriteLine(player);
    }
}