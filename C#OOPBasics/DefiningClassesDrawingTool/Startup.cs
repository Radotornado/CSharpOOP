﻿using System;

public class Startup
{
    public static void Main()
    {
        var shape = Console.ReadLine();
        var width = double.Parse(Console.ReadLine());
        double height;

        if (shape == "Square")
        {
            height = width;
        }
        else
        {
            height = double.Parse(Console.ReadLine());
        }

        var figure = new CorDraw(width, height);
        Console.WriteLine(figure.Draw());
    }
}