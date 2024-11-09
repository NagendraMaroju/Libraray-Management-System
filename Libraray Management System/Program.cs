using Libraray_Management_System;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new library
        Library myLibrary = new Library();

        // Add some books to the library
        myLibrary.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
        myLibrary.AddBook(new Book("1984", "George Orwell", "9780451524935"));
        myLibrary.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));

        // List all books in the library
        myLibrary.ListBooks();

        // Search for a book by title
        Console.WriteLine("\nSearch for books with '1984' in the title:");
        myLibrary.SearchBook("1984");

        Console.WriteLine("\nSearch for books with 'The' in the title:");
        myLibrary.SearchBook("The");

        Console.WriteLine("\nSearch for books with 'Unknown' in the title:");
        myLibrary.SearchBook("Unknown");
    }
}
