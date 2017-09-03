using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var firstDate = Console.ReadLine();
        var secondDate = Console.ReadLine();
        Console.WriteLine(DateModifier.GetDaysBetweenDates(firstDate, secondDate));
    }
}