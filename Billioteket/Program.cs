using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billioteket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new FactBook("ABC", "NZ", 155, "Horror", "Very Hard"),
                new FactBook("COI", "YZ", 255, "HIB", "Hard"),
                new FactBook("CDC", "OZ", 555, "Science", "Very very Hard"),
                new ChildrensBook("TCH", "TC", 20, "Children Book", true),
                new ChildrensBook("YGH", "RCR", 50, "Teen Book", false),
                new EntertainmentBook("LOve", "PLC", 333, "Romance", "Novel"),
                new EntertainmentBook("Hate", "OLCF", 733, "All", "Anthology"),
                new EntertainmentBook("LOveOrHate", "GCG", 263, "World", "Novel")
            };

            Console.WriteLine($"There are toltal {books.Count} books in the Library right now.");
            Console.WriteLine("[1] for Fack Books\n[2] for Children Books\n[3] for Entertainmen Books\n");
            Console.WriteLine();

            int Menu = Convert.ToInt32(Console.ReadLine());
            switch (Menu) 
            {
                case 1:
                 

                    break;
                case 2:
                    var childrensBooks = books.Where(b => b is ChildrensBook).Select(b => (ChildrensBook)b).ToList();
                    foreach (var childrensBook in childrensBooks)
                    {
                        childrensBook.PrintBookInfo();
                    }
                    break;
                case 3:
                    foreach (Book book in books)
                    {

                        ((EntertainmentBook)book).PrintBookInfo();
                    }
                    break;

                default:
                    break;

            }
           
            Console.ReadKey();
        }
    }
}
