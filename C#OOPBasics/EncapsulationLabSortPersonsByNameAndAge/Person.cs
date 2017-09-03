public class Person
{
    private string firtsName;
    private string lastName;
    private int age;

    public Person(string firtsName, string lastName, int age)
    {
        this.firtsName = firtsName;
        this.lastName = lastName;
        this.age = age;
    }

    public string FirstName { get { return this.firtsName; } }

    public int Age { get { return this.age; } }

    public override string ToString()
    {
        return $"{this.firtsName} {this.lastName} is a {this.age} years old.";
    }
}