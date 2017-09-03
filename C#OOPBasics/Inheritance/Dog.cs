public class Dog : Animal
{
    public Dog()
    {
        this.Color = "Black";
    }
    public string SayHello()
    {
        return $"{this.Name}: Bark!";
    }
}
