using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraray_Management_System
{
    class Book
    {
        // Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        // Constructor
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        // Method to display book details
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
    }
}