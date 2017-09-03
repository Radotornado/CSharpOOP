using System;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public double GetSurfaceArea()
    {
        return (2 * this.length * this.width)
               + (2 * this.length * this.height)
               + (2 * this.width * this.height);
    }

    public double Length
    {
        get { return length;  }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(this.Length)} cannot be zero or negative.", nameof(this.Length));
            }
            this.length = value;
        }
    }
    public double Height
    {
        get { return height; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative.", nameof(this.Height));
            }
            this.height = value;
        }
    }
    public double Width
    {
        get { return width; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(this.Length)} cannot be zero or negative.", nameof(this.Width ));
            }
            this.width = value;
        }
    }
    public double GetLateralSurfaceArea()
    {
        return (2 * this.length * this.height)
               + (2 * this.width * this.height);
    }

    public double GetVolume()
    {
        return this.length * this.width * this.height;
    }

    public override string ToString()
    {
        string result = $"Surface Area - {this.GetSurfaceArea():F2} \r\n" +
                        $"Lateral Surface Area - {this.GetLateralSurfaceArea():F2} \n\n" +
                        $"Volume - {this.GetVolume():F2}";
        return result;
    }
}
