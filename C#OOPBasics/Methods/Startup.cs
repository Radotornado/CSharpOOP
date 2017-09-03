public class Startup
{
    public static void Main()
    {
        var firstCat = new Cat("Ivan", "Black");
        var secondCat = new Cat("Pesho", "Orange");

        var firstDescription = firstCat.GetDescription();
        var secondDescription = secondCat.GetDescription();
        System.Console.WriteLine(firstDescription);
        System.Console.WriteLine(secondDescription);

        var catNumberOfLegs = Cat.NumberOfLegs();
        System.Console.WriteLine(catNumberOfLegs);

        firstCat.Move(2, 4);
        secondCat.Move(-5, 3);
        
        firstCat.Attack(20, secondCat, new Cat("Gosho", "Green"));
    }   
}
