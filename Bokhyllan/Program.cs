using Bokhyllan;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookShelf

{

    class Program
    {

        // Delen av programmet med app information (extra för träning) 
        public static void AppInfo()    
        {
            // Setting up app vars
            string appName = "Bookshelf (Bokhyllan/ Bibliotekarien)";
            string appVersion = "1.1.0";
            string appAuthor = "Robert Wägar";

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\t{0} \t "
                + "\n\tVersion: {1} \t\t "
                + "\n\tBy {2} \t ", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        // Här skapas huvudvmenyn 
        public static void Menu()                                               // Huvudmeny
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;                       // Ändrar textfärgen
            Console.WriteLine("\n\n\t = = = = = = = = = = = = = = ="            // Skriver ut huvudmenyn
            + "\n\t\t - Library - "                                             // Här ges användaren olika alternativ
            + "\n "
            + "\n\tI´m Your librarian how can I be of service? "
            + "\n\t = = = = = = = = = = = = = = ="
            + "\n\n\t[1] Add a book to the library"
            + "\n\t[2] See the list of all books in the libarary"
            + "\n\t[3] Searh for a book in the library"                         
            + "\n\t[4] Remove all books from list in the library"
            + "\n\t[5] Quit");
            Console.ResetColor();

        }

        // Här körs huvudprogrammet
        static void Main(string[] args)                                                         // Main programmets startpunkt, får bara finns en Main
        {
            Console.Clear();                                                                    // Rensar konsollen

            AppInfo();                                                                          // App information visas här
            Task.Delay(2000).Wait();                                                            // Styrs av en timeout som körs i 2 sek
                                                                                                

            Librarian Rob = new Librarian();                                                    // Skapar instans av klassen bibliotekarie
            bool isActive = true;                                                               // Deklarerar variabeln som styr programmets huvudloop av typen boolean
            while (isActive)                                                                    // Här startar programmet - styrs av while-loop
            {
                Menu();                                                                         // Hämtar,/ Kör huvudmenyn

                Console.Write("\t");                                                            // Lägger till ett mellan rum så text markören är på samma linje med menyn
                if (Int32.TryParse(Console.ReadLine(), out int val))                            // Kontrollerar att en siffra slagits in
                {

                    switch (val)                                                                // Selektion med switch 5 val
                    {
                        case 1:                                                                 // Menyval 1
                            Rob.AddBook();

                            break;

                        case 2:
                            Librarian.GetBooks();                                               // Hämta lista av all böcker
                                                        
                            break;

                        case 3:
                           Rob.SearhBooks();                                                    // Sök metod för att söka böcker via titel eller skribent

                            break;

                        case 4:
                            Rob.RemoveBooks();                                                  // Radera böcker med alternativ att ångra sig

                            break;

                        case 5:                                                                 // Menyval 5 - Avsluta program
                            isActive = false;
                            break;

                        default:

                            break;

                    }
                }
            }
        }


        //Underklasserna av klassen Bok (Book) Ärver Bok klassens egenskaper.
        //Typen av bok (Type) är en enskild egenskap för varje underklass av bok, beroende på vilken typ av bok man skapar så får underklasserna en unik egenskap

        //internal class Novel : Book
        //{
        //    internal Novel(string inputTitle, string inputAuthor, int inputYearOfPublication, int inputPages) :
        //           base(inputTitle, inputAuthor, inputYearOfPublication, inputPages)
        //    {
        //        Type = "Novel";
        //    }
        //    public override string ToString()                   // Här börjar bokens ToString. Dess standardiserade utskrift
        //    {
        //        return "\n\t\tTitle: " + Title + " (" + YearOfPublication + ")"
        //        + "\n\t\tAuthor: " + Author
        //        + "\n\t\tBook type: " + Type
        //        + "\n\t\tPages: " + Pages;
        //        //  + "\n\t\t" + Available;                     // tänker om bokan är tillgänglig i ett bibiliotek, 
        //    }
        //}


        //internal class ShortStory : Book
        //{
        //    internal ShortStory(string inputTitle, string inputAuthor, int inputYearOfPublication, int inputPages) :
        //         base(inputTitle, inputAuthor, inputYearOfPublication, inputPages)

        //    {
        //        Type = "ShortStory";
        //    }
        //    public override string ToString()                   // Här börjar bokens ToString. Dess standardiserade utskrift
        //    {
        //        return "\n\t\tTitle: " + Title + " (" + YearOfPublication + ")"
        //        + "\n\t\tAuthor: " + Author
        //        + "\n\t\tBook type: " + Type
        //        + "\n\t\tPages: " + Pages;

        //    }

        //}

        //internal class Journal : Book
        //{
        //    internal Journal(string inputTitle, string inputAuthor, int inputYearOfPublication, int inputPages) :
        //         base(inputTitle, inputAuthor, inputYearOfPublication, inputPages)

        //    {
        //        Type = "Journal";
        //    }


        //    public override string ToString()                   // Här börjar bokens ToString. Dess standardiserade utskrift
        //    {
        //        return "\n\t\tTitle: " + Title + " (" + YearOfPublication + ")"
        //        + "\n\t\tAuthor: " + Author
        //        + "\n\t\tBook type: " + Type
        //        + "\n\t\tPages: " + Pages;

        //    }

        //}
    }
}
