using System;
using System.Collections.Generic;

public class Author
{
    public Author(string firstName)
    {
        if (firstName == null)
        {
            throw new ArgumentException("Author first name cannot be null!");
        }
        this.firstName = firstName;
        this.books = new List<Book>();
    }
    public Author(string firstName, string lastName)
        : this(firstName)
    {
        if (lastName == null)
        {
            throw new ArgumentException("Author first or last name cannot be null!");
        }
        this.lastName = lastName;
    }
    
    public Author(string firstName, string lastName, int yearOfBirth)
        :this(firstName, lastName)
    {
        this.yearOfBirth = yearOfBirth;
    }
    public string firstName;
    public string lastName;
    public int yearOfBirth;
    public List<Book> books;
}

