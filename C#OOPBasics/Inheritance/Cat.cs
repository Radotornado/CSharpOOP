public class Cat : Animal
{
    public Cat()
    {
        this.Color = "Red";
    }
    public string SayHello()
    {
        return $"{this.Name}: Meow!";
    }
}
