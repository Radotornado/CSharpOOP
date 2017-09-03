using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {

        var firstBook = new Book
        {
        name = "Pod Igoto",
        pages = 500,
        price = 20.00m,
        description = "Voina"
        };

        var secondBook = new Book();
        secondBook.name = "Stihotvoreniya na Hristo Botev";
        secondBook.pages = 150;
        secondBook.price = 10m;
        secondBook.description = "Stihotvo ...";

        var firstAuthor = new Author("Ivan", "Vasov")
        {
            yearOfBirth = 1850
        };

        firstBook.author = firstAuthor;

        firstAuthor.books = new List<Book>();
        firstAuthor.books.Add(firstBook);

        System.Console.WriteLine(firstAuthor.books.Count);

        var secondAuthor = new Author("Konstantin","Konstantinov");
        secondAuthor.books = new List<Book>();
        var anotherAuthor = new Author("Hristo","Botev")
        {
            yearOfBirth = 2000
        };
        System.Console.WriteLine(anotherAuthor.yearOfBirth);
    }
}

