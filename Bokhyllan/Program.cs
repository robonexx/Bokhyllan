using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShelf

{
    class Program
    {
        static void Main(string[] args)
        {

            List<Book> bookList = new List<Book>();

        }
    }

    public abstract class Book
    {
        string Title;
        string Author;
        int YearOfPublication;
        string Type;
        bool InStock;

        internal Book(string inputTitle, string inputAuthor, int inputYearOfPublication, bool inputInStock)
        {
            Title = inputTitle;
            Author = inputAuthor;
            YearOfPublication = inputYearOfPublication;
            InStock = inputInStock;
        }
    }

}
