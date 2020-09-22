using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Billioteket
{
    class FactBook:Book
    {

        public string Subject { get; set; }
        public string Difficulty { get; set; }

        public FactBook(string title, string author, int numberOfPages, string subject, string difficulty)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
            Subject = subject;
            Difficulty = difficulty;

        }
        public override void PrintBookInfo()
        {
            Console.WriteLine($"Titke of the book: {Title}, Author: {Author}, Number of Pages in the book: {NumberOfPages}, " +
                $"The book is about: {Subject}, Difficulty level: {Difficulty}");

        }

    }
}
