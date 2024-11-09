using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraray_Management_System
{
    class Library
    {
        // List of books in the library
        private List<Book> books;

        // Constructor
        public Library()
        {
            books = new List<Book>();
        }

        // Method to add a book to the library
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to the library.");
        }

        // Method to display all books in the library
        public void ListBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the library.");
                return;
            }

            Console.WriteLine("Books in the library:");
            foreach (var book in books)
            {
                book.DisplayInfo();
            }
        }

        // Method to search for a book by title
        public void SearchBook(string title)
        {
            var foundBooks = books.FindAll(b => b.Title.ToLower().Contains(title.ToLower()));

            if (foundBooks.Count == 0)
            {
                Console.WriteLine($"No books found with title '{title}'.");
            }
            else
            {
                Console.WriteLine($"Books found with title '{title}':");
                foreach (var book in foundBooks)
                {
                    book.DisplayInfo();
                }
            }
        }
    }
}
