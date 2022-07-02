using Bokhyllan;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookShelf

{

    class Program
    {

        // app information 
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

        public static void Menu()                                               // Huvudmeny
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;                       // Ändrar textfärgen
            Console.WriteLine("\n\n\t = = = = = = = = = = = = = = ="            // Skriver ut huvudmenyn
            + "\n\t\t - Library - "
            + "\n "
            + "\n\tI´m Your librarian how can I be of service? "
            + "\n\t = = = = = = = = = = = = = = ="
            + "\n\n\t[1] Add a book to the library"
            + "\n\t[2] See the list of all books in the libarary"
            + "\n\t[3] Searh for a book in the library"                         // Metoden är ej klar
            + "\n\t[4] Remove all books from list in the library"
            + "\n\t[5] Quit");
            Console.ResetColor();

        }

        static void Main(string[] args)                                                         // main här körs programmet, får bara finns en main
        {
            Console.Clear();                                                                    // Rensar konsollen

            AppInfo();                                                                         // App information hämtar metoden 
            Task.Delay(2300).Wait();
                                                                                                // Huvudmeny hämtar metoden 

            Librarian Rob = new Librarian();
            bool isActive = true;                                                               // Deklarerar variabeln som styr programmets huvudloop av typen boolean
            while (isActive)                                                                    // Här startar programmet - while-loop
            {
                Menu();                                                                         // Menu

                Console.Write("\t");                                                            // Lägger till ett mellan rum så text markören är på samma linje med menyn
                if (Int32.TryParse(Console.ReadLine(), out int val))                            // Kontrollerar att en siffra slagits in
                {


                    switch (val)                                                                // Selektion med switch
                    {
                        case 1:                                                                 // Menyval 1
                            Rob.AddBook();

                            break;

                        case 2:
                            Librarian.GetBooks();
                                                        
                            break;

                        case 3:
                            Rob.SearhBooks();                                                   // not done yet

                            break;

                        case 4:
                            Rob.RemoveBooks();                                                  // done but not implemented on this one

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
