using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billioteket
{
    class EntertainmentBook:Book
    {
        public string Type { get; set; }
        public string NovelOrAnthology { get; set; }

        public EntertainmentBook(string title, string author, int numberOfPages, string type  , string novelOrAnthology)
        {
            this.Title = title;
            this.Author = author;
            this.NumberOfPages = numberOfPages;
            this.Type = type;
            this.NovelOrAnthology = novelOrAnthology;

        }

        public override void PrintBookInfo()
        {
            Console.WriteLine($"Titke of the book:{Title}, Author: {Author}, Number of Pages in the book: {NumberOfPages}, " +
                $"The book is about: {Type}, This book is: {NovelOrAnthology}");

        }

    }
}
