using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billioteket
{
    class ChildrensBook:Book
    {
        public string ChildOrTeen { get; set; }
        public bool PictureBook { get; set; }


        public ChildrensBook(string title, string author, int numberOfPages, string childOrTeen, bool pictureBook)
        {
            this.Title = title;
            this.Author = author;
            this.NumberOfPages = numberOfPages;
            this.ChildOrTeen = childOrTeen;
            this.PictureBook = pictureBook;


        }

        public override void PrintBookInfo()
        {
            Console.WriteLine($"Titke of the book:{Title}, Author: {Author}, Number of Pages in the book: {NumberOfPages}, " +
                $"The book is for: {ChildOrTeen}, Contents picture: {PictureBook}");

        }

    }
}
