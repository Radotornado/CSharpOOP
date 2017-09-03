using System;

public class Employee
{
    private string name;
    private int age;
    private decimal monthlySalary;

    public Employee(string name, int age)
    {
        this.Name = name;
        this.Age = age; 
    }
    

    public string Name
    {
        get
        {
            return this.name;
        }
        private set
        {
            if (value == null || value.Length < 3)
            {
                throw new ArgumentException($"{nameof(Name)} cannot be null or less than 3 symbols!");
            }
            this.name = value;
        }
    } 

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 18)
            {
                throw new ArgumentException($"{nameof(Age)} cannot be less than 18!");
            }
            this.age = value;
        }
    } 

    public decimal MonthlySalary
    {
        get
        {
            return this.monthlySalary;
        }
        set
        {
            if (value < 0)
            {

            }

            if (value < 300)
            {

            }
            this.monthlySalary = value;
        }
    }
    
    public bool IsHired { get; set; }

    public string GetInfo()
    {
        return $"{this.name} - {this.age} - {this.monthlySalary}";
    }
}

