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

            Book firstBook = new Book("Boken om mitt liv", "R J W", "1000-0000-avcd-123", 2022, true);

            Book secondBook = new Book("Programmring 2", "Magnus Lilja", "2222-0930-2342-rtg", 2017, true);

            bookList.Add(firstBook);
            bookList.Add(secondBook);

            AppInfo();
            Console.WriteLine("\n\n\tName: \t\t\t{0}, \n\tAuthor: \t\t{1}, \n\tCategory: \t\t{2}, \n\tYear of publication: \t{3} ", firstBook.Title, firstBook.Author, firstBook.ISBN, firstBook.YearOfPublication);
           

            Console.WriteLine("\n\t Böcker i listan: ");
            foreach (Book book in bookList)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n\t " + book + "\n ");
                Console.ResetColor();
            }
            Console.WriteLine("\n\t\t Tryck på valfri knapp för att fortsätta");
            Console.Write("\t  ");
            Console.WriteLine("\tPress any key to exit");
            Console.ReadKey();

        }

        private static void AppInfo()
        {
            // Setting up app vars
            string appName = "Bookshelf (Bokhyllan";
            string appVersion = "1.0.0";
            string appAuthor = "Robert Wägar";

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\t {0} \n\t Version {1} \n\t By {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

    }

    public class Book
    {
        internal string Title;
        internal string Author;
        internal string ISBN;
        internal int YearOfPublication;
        internal bool Available;
       // internal string Type;

        internal Book(string inputTitle, string inputAuthor, string inputISBN, int inputYearOfPublication, bool inputAvailable)
        {
            Title = inputTitle;
            Author = inputAuthor;
            ISBN = inputISBN;
            YearOfPublication = inputYearOfPublication;
            Available = inputAvailable;
        }

        public override string ToString() // Här börjar bokens ToString. Dess standardiserade utskrift
        {


            return "\n\t\t" + Title + " (" + YearOfPublication + ")"
            + "\n\t\t" + ISBN
                + "\n\t\t" + Available;

           
        }
    }
}

    


