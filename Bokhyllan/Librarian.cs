using System;
using System.Collections.Generic;
using BookShelf;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokhyllan
{

    class Librarian
    {
        static private List<Book> bookList = new List<Book>();

        // =============================================
        // metod för att hämta alla registrerade böcker
        // =============================================

        public static string GetBooks()
        {
            string output = " ";

            if (bookList.Count > 0)                                     //Om det ej finns någon data än, om boklistan är tom
            {
                Console.Clear();
                foreach (Book item in bookList)                         //En loop av typen foreach för att gå igenom hela boklistan och lägga till böckerna
                {
                    output = "\n\t" + item;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\t\tLibrary book register");
                    Console.WriteLine(output);
                }
                output = "\n\n\t\t + " + bookList.Count + " books currently in registered in this library.";
                Console.WriteLine(output);
                Console.ResetColor();
                Console.Write("\t");
                Console.ReadKey();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\t\tLibrary book register");
                Console.ForegroundColor = ConsoleColor.Red;
                output = "\n\n\t - No books available yet"                //meddelande om datan / listan är tom
                    + "\n\tPress any key to continue to menu";
                Console.WriteLine(output);
                Console.ResetColor();
                Console.ReadKey();
            }
            return output;

        }

        // ==================================
        // Metod för att lägga till en ny bok
        // ==================================

        public void AddBook()
        {
            string title;
            string author;
            int year;
            int pages;

            Console.WriteLine("\n\tWhat is the title of the book? ");                           //information till användaren
            Console.Write("\n\t");
            title = Console.ReadLine();                                                         //data = titel (anges av användaren)

            Console.WriteLine("\n\tWhat is the name of the author?");                           //information till användare
            Console.Write("\n\t");
            author = Console.ReadLine();                                                        //data = författare tas emot

            Console.WriteLine("\n\tWhat is the year of publication?");                        //information till användare
            Console.Write("\n\t");
            Int32.TryParse(Console.ReadLine(), out year);                                       //data = publiceringsår tas emot 

            Console.WriteLine("\n\tHow many pages does the book have?");                      //information till användare  
            Console.Write("\n\t");
            Int32.TryParse(Console.ReadLine(), out pages);                                      //data = antal sidor tas emot

            Console.WriteLine("\n\tWhat type of book is it? Choose a number 1-3"                    //här ger man 3 alternativ till boktyp
            + "\n\t\t[1] Novel"
            + "\n\t\t[2] ShortStory"
            + "\n\t\t[3] Journal");


            Console.Write("\t\t");
            if (Int32.TryParse(Console.ReadLine(), out int type))                                   //felhantering ser efter om boken är en int - siffra
            {
                switch (type)
                {
                    case 1:
                        Novel newNovel = new Novel(title, author, year, pages);                          //typ roman på engelska Novel
                        bookList.Add(newNovel);
                        break;

                    case 2:
                        ShortStory newShortStory = new ShortStory(title, author, year, pages);          //typ novellsamling på engelska ShortStory
                        bookList.Add(newShortStory);
                        break;

                    case 3:
                        Journal newJournal = new Journal(title, author, year, pages);                   //typ tidskrift på engelska Journal
                        bookList.Add(newJournal);
                        break;

                    default:
                        Console.WriteLine("\n\tPlease, choose between [1], [2] & [3]!");                    //om ej rätt alternativ anges
                        Console.ReadLine();
                        break;

                }
            }

        }

        // ========================================
        // Metod för att radera böcker, eller ångra
        // ========================================
       
        public void RemoveBooks()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\t !!! Remove booklist menu!!! ");

            Console.WriteLine("\n\tChoose");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t[1] to remove all books from library registration");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t[2] If you have a changed your mind ;D");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\t");
            Int32.TryParse(Console.ReadLine(), out int input);
            if (input == 1)
            {
                bookList.Clear();                                                       //radera regisrerade böcker från bibliotekets lista
            }
            else if (input == 2)

                Console.WriteLine("\n\tI see you changed your mind, back to the menu.");

            else
            {
                //om inte val har gjorts
                Console.WriteLine("\n\tYou have to choose option [1] & [2], make a choice!");
                Console.ReadLine();
            }
            Console.ResetColor();
        }

        //Sök funktion för att leat bland böcker
        public void SearhBooks()
        {

            string results = "";                                            // variabel för att spara resultat
           

            Console.WriteLine("\n\tSearch for books by title, author or year of publication:");
            Console.Write("\n\t");
            string search = Console.ReadLine();                             // skapar sök variabeln
            var isNumeric = int.TryParse(search, out int searchIsYear);     // kollar om variabeln search är ett nummer
            foreach (Book item in bookList)
            {
                if (item.Title == search)                                   // om titeln matchar
                {
                    results += "\n\t" + item;                   
                }
                else if (item.Author == search)                             // om skribenten matchar
                {
                    results += "\n\t" + item;
                }
                else if (item.YearOfPublication == searchIsYear )           // om året matchar
                {
                    results += "\n\t" + item;
                }
                else
                {
                    results += "";
                }                           
            }

            if (results != "")
            {
                Console.WriteLine("\n\tThese books are availble with the title you searched for: ");               
            }
            else
            {
                Console.WriteLine("\n\tSorry we don´t have the book you was looking for.)");
            }
            
            Console.WriteLine(results);
            Console.WriteLine("\n\tPress any key to continue");
            Console.Write("\n\t");
            Console.ReadKey();
        }


    }
}
    



// tried out a few different verions of how to get the flow in the program, not ready yet

// don´t know which is the best way so saving this

/*
 
        //public static string GetInfo(int index)                                     // method för att hämta bok information via index
        //{
        //    return "\n\n\tTitle:\t\t" + bookList[index].Title +
        //           "\n\tAuthor:\t\t" + bookList[index].Author +
        //           "\n\tYear of publication:\t" + bookList[index].YearOfPublication +
        //           "\n\tType:\t\t" + bookList[index].Type +
        //           "\n\tPages:\t\t" + bookList[index].Pages +
        //           "\n\t" + bookList[index].ToString();
        //}
     
     
*/

/*
 * 
 * //string data = "";
           //int currentIndex = 0;

           //if (bookList.Count != 0)                                //ifall arrayen inte är tom
           //{
           //    foreach (Book Bok in bookList)                      //En loop av typen foreach för att gå igenom hela boklistan och lägga till böckerna
           //    {
           //        data += GetBookInfo(currentIndex);
           //        currentIndex++;
           //    }
           //    data += "\n\n";
           //}
           //else
           //{
           //    data = "\n\tThere are no books currently in the library"                 //meddelande om datan / listan är tom
           //            +"\n\tYou can choose to add one in the main menu alternative 1";
           //}
           //return data;

*/
