﻿using System;

public abstract class Animal
{
    private string name;
    private int age;
    private string gender;

    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    private string Name
    {
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
            {
                throw new ArgumentException("Invalid input!");
            }

            this.name = value;
        }
    }

    private int Age
    {
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid input!");
            }

            this.age = value;
        }
    }

    private string Gender
    {
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
            {
                throw new ArgumentException("Invalid input!");

            }

            this.gender = value;
        }
    }

    public abstract string ProduceSound();

    public override string ToString()
    {
        return string.Format("{0}{1}{2} {3} {4}{1}{5}",
            this.GetType().Name, 
            Environment.NewLine, 
            this.name, 
            this.age,  
            this.gender, 
            this.ProduceSound());
    }
}
