using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookShelf

{

    class Program
    {
        static void Main(string[] args)
        {

            List<Book> bookList = new List<Book>();
            bool isActive = true;                                                   // Deklarerar variabeln som styr programmets huvudloop av typen boolean
            while (isActive)                                                        // Här startar programmet - while-loop
            {
                Console.Clear();                                                    // Tömmer konsol fönstret
                AppInfo();
                Console.ForegroundColor = ConsoleColor.White;                       // Ändrar textfärgen
                Console.WriteLine("\n\n\t = = = = = = = = = = = = = = ="            // Skriver ut huvudmenyn
                + "\n\t\t - Bookshelf - "
                + "\n\t = = = = = = = = = = = = = = ="
                + "\n\n\t [1] Add a book to the bookshelf"
                + "\n\t [2] See the list of all books in bookshelf"
                 + "\n\t [3] Remove all books from list / bookshelf"
                + "\n\t [4] Quit");
                Console.ResetColor();                                               
                if (Int32.TryParse(Console.ReadLine(), out int val))                            // Kontrollerar att en siffra slagits in
                {
                    switch (val)                                                                // Selektion med switch
                    {
                        case 1:                                                                 // Menyval 1

                         
                            string title = "";                       
                            string author = "";
                            int year = 0;
                          

                                Console.Clear();                                   
                                Console.ForegroundColor = ConsoleColor.White;       
                                Console.WriteLine("\n\n\t - Write the title of the book");      // Instruktion till användaren
                                Console.ResetColor();                              
                                Console.Write("\t   ");                             
                                title = Console.ReadLine().ToUpper(); 
                            

                                Console.ForegroundColor = ConsoleColor.White;          
                                Console.WriteLine("\n\n\t - Who is the Author of the book?");   // Instruktion till användaren
                                Console.ResetColor();                                  
                                Console.Write("\t   ");                                 
                                author = Console.ReadLine().ToUpper();             

                                Console.ForegroundColor = ConsoleColor.White;          
                                Console.WriteLine("\n\n\t - What year was the book published?"); // Instruktion till användaren
                                Console.ResetColor();                                 
                                Console.Write("\t   ");                                 
                                year = int.Parse(Console.ReadLine().ToUpper());                 // lägger till publicerings år



                            
                            Console.WriteLine("\n\t Choose the type of your book"               // skriver ut de 3 alternavtiv av boktyp
                                                + "\n\n\t [1] Novel"
                                                + "\n\t [2] ShortBook"
                                                + "\n\t [3] Journal");
                            if (Int32.TryParse(Console.ReadLine(), out int result))             // Kontrollerar att det är en siffra som valts av användaren
                            {
                                switch (result)                                                 //Typ av bok är en del av underklassens särskilada egenskap
                                    {                                                           // Här väljs ett av 3 alternativ                   
                                        case 1:
                                            bookList.Add(new Novel(title, author, year));
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\n\tA novel(book) was added to bookshelf!");
                                        Console.ResetColor();
                                            break;
                                        case 2:
                                            bookList.Add(new ShortStory(title, author, year));
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("\n\tA shortstory (book) was added to bookshelf!");
                                            Console.ResetColor();
                                        break;
                                        case 3:
                                            bookList.Add(new Journal(title, author, year));
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\n\tA journal (book) was added to bookshelf!");
                                        Console.ResetColor();
                                        break;
                                        default:                                                    // Om fel nummer slagits in så får man börja om
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n\tError, Please add all information and select type 1-3 before\n\t" +
                                            "adding the book"
                                            + "\n\tPlease return to main menu and try again");
                                        Console.ResetColor();

                                        break;
                                    }
                                 } 

                            Console.WriteLine("\n\n\t"
                                            + "\n\tPress any key to continue to menu");
                            Console.ReadKey();

                            //Novel newNovel = new Novel(title, author, year);                  // testade lägga till bok i listan
                            //   // lägger till en bok
                            //    bookList.Add(newNovel);                                       // Lägger till boken i arrayen av böcker

                            // Console.WriteLine("\n\n\tName: \t\t\t{0}, \n\tAuthor: \t\t{1}, \n\tType: \t\t{2}, \n\tYear of publication: \t{3} ", firstBook.Title, firstBook.Author, firstBook.ISBN, firstBook.YearOfPublication);


                            break;





                        case 2:                                                                 // Menyval 2
                            if (bookList.Count > 0)                                  
                            {
                                Console.Clear();                                    
                                Console.ForegroundColor = ConsoleColor.Yellow;       
                                foreach (Book item in bookList)                      
                                {
                                    Console.WriteLine(item);                     
                                }
                                Console.WriteLine("\n\n\t\t + " + bookList.Count + " books in booklist / bookshelf."); 
                                Console.ResetColor();
                                Console.Write("\t");
                                Console.ReadLine();                                 
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n\n\t - No books available yet"
                                    +"\n\tPress any key to continue to menu");
                                Console.ResetColor();
                                Console.ReadKey();
                            }
                            break;

                        case 3:                                                                 // Menyval 3 Radera lista av böcker
                            bookList.Clear();
                            break;


                        case 4:                                                                 // Menyval 4 - Avsluta program
                            isActive = false;
                            break;

                        default:
                                                      
                            break;

                    }                   

                }

            }
        }

        private static void AppInfo()
        {
            // Setting up app vars
            string appName = "Bookshelf (Bokhyllan";
            string appVersion = "1.0.0";
            string appAuthor = "Robert Wägar";

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\t{0} \t " 
                + "\n\tVersion: {1} \t\t "
                + "\n\tBy {2} \t ", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

    }
    


    public class Book
    {
         internal string Title;
         internal string Author;
         internal int YearOfPublication;
       //  internal bool Available;

        internal string Type;

        // type är en egenskap som kommer från underklasserna
        // string Type;

        public Book(string inputTitle, string inputAuthor, int inputYearOfPublication)
        {
            Title = inputTitle;
            Author = inputAuthor;
            YearOfPublication = inputYearOfPublication;
          //  Available = inputAvailable;

            
        }

        public override string ToString() // Här börjar bokens ToString. Dess standardiserade utskrift
        {
            return "\n\t\tTitle: " + Title + " (" + YearOfPublication + ")"
            + "\n\t\tAuthor: " + Author
            + "\n\t\tBook type: " + Type;
            //  + "\n\t\t" + Available;
        }


    }


    //Underklasserna av klassen Bok (Book) Ärver Bok klassens egenskaper.
    //Typen av bok (Type) är en enskild egenskap för varje underklass av bok, beroende på vilken typ av bok man skapar så får underklasserna en unik egenskap

    internal class Novel : Book
            {
        internal Novel(string inputTitle, string inputAuthor, int inputYearOfPublication) :
               base(inputTitle, inputAuthor, inputYearOfPublication)
        {
            Type = "Novel";
        }
    }

    
    internal class ShortStory : Book
    {
        internal ShortStory(string inputTitle, string inputAuthor, int inputYearOfPublication) :
             base(inputTitle, inputAuthor, inputYearOfPublication)

        {
            Type = "ShortStory";
        }

    }

    internal class Journal : Book
    {
        internal Journal(string inputTitle, string inputAuthor, int inputYearOfPublication) :
             base(inputTitle, inputAuthor, inputYearOfPublication)

        {
            Type = "Journal";
        }

        // Man skulle kunna ändra texten på något sätt i varje typ om man ville, kanske ändrar detta sen 

        //public override string ToString() // Här börjar book typens ToString.
        //{

        //    return "\n\t\t" + Title + " (" + YearOfPublication + ")"
        //    + "\n\t\t By:" + Author
        //    + "\n\t\t Type: " + Type;
        //    //  + "\n\t\t" + Available;


        //}

    }

    
}





