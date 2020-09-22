using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billioteket
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }

        public Book() { }
        public Book(string title, string author, int numberOfPages) 
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }
        public virtual void PrintBookInfo()
        {
            Console.WriteLine($"Titke of the book:{Title}, Author: {Author}, Number of Pages in the book: {NumberOfPages}");

        }
       
    }
}
