public class Bunny : Animal
{
    public Bunny()
    {
        this.Color = "White";
    }
    public string SayHello()
    {
        return $"{this.Name}: What's up doc?!";
    }
}
