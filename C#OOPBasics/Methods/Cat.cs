using System.Collections.Generic;

public class Cat
{
    private string name;
    private string color;
    private Position position;

    public Cat(string name, string color)
    {
        this.name = name;
        this.color = color;
        this.position = new Position(0, 0);
    }

    public string Name => this.name;
    public string Color => this.color;

    public static int NumberOfLegs()
    {
        return 4;
    }

    public void Attack(int damage, params Cat[] cats)
    {
        foreach (var cat in cats)
        {

        }
    }

    public Position Move(int xOffset, int yOffset)
    {
        this.position =  new Position(this.position.X + xOffset, this.position.Y + yOffset);
        return this.position; 
    }

    public Position GetPosition()
    {
        return this.position;
    }

    public string GetDescription()
    {
        return $"I am {this.name} and I have {this.color} color";
    }
}
