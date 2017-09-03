public abstract class Animal
{
    string name;
    string favouriteFood;
    int age;
    public Animal(string name, string favouriteFood, int age)
    {
        this.name = name;
        this.favouriteFood = favouriteFood;
        this.age = age;
    }

    public virtual void StateFavFood()
    {
        System.Console.WriteLine($"My favourite food is {this.favouriteFood}");
    }

    public abstract void MakeNoise();

}