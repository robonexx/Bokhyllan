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
                    
            bool isActive = true;                                    // Deklarerar variabeln som styr programmets huvudloop av typen boolean

            List<Book> bookList = new List<Book>();
            while (isActive)                                        // Här startar vårt program - while-loop
            {
                Console.Clear();                                                    // Tömmer konsol fönstret
                AppInfo();
                Console.ForegroundColor = ConsoleColor.White;                       // Ändrar textfärgen
                Console.WriteLine("\n\n\t = = = = = = = = = = = = = = = = = = = ="          // Skriver ut huvudmenyn
                + "\n\t\t - Bookshelf - "
                + "\n\t = = = = = = = = = = = = = = = = = = = ="
                + "\n\n\t [1] Add a book to the bookshelf"
                + "\n\t [2] See the list of all books in bookshelf"
                + "\n\t [3] Quit");
                Console.ResetColor();                                               
                if (Int32.TryParse(Console.ReadLine(), out int resultat))           
                {
                    switch (resultat)                                               // Selektion med switch
                    {
                        case 1:                                                     // Menyval 1
                            string title = "";                       
                            string author = "";
                            int year = 0;
                          //  bool available = false;

                                Console.Clear();                                   
                                Console.ForegroundColor = ConsoleColor.White;       
                                Console.WriteLine("\n\n\t - Write the title of the book you want to add to the bookshelf"); 
                                Console.ResetColor();                              
                                Console.Write("\t   ");                             
                                title = Console.ReadLine().ToUpper(); 
                            

                                Console.ForegroundColor = ConsoleColor.White;          
                                Console.WriteLine("\n\n\t - Who is the Author of the book?"); 
                                Console.ResetColor();                                  
                                Console.Write("\t   ");                                 
                                author = Console.ReadLine().ToUpper();             

                                Console.ForegroundColor = ConsoleColor.White;          
                                Console.WriteLine("\n\n\t - What year was the book published?"); // Instruktion till användaren
                                Console.ResetColor();                                 
                                Console.Write("\t   ");                                 
                                year = int.Parse(Console.ReadLine().ToUpper());             // lägger till publicerings år


                                Novel newNovel = new Novel(title, author, year);
                               // lägger till en bok
                                bookList.Add(newNovel);                                    // Lägger till boken i listan av böcker (Arrayen)


                                break;





                        case 2:                                                    
                            if (bookList.Count > 0)                                  
                            {
                                Console.Clear();                                    
                                Console.ForegroundColor = ConsoleColor.White;       
                                foreach (Book item in bookList)                      
                                {
                                    Console.WriteLine(item);                     
                                }
                                Console.WriteLine("\n\n\t * " + bookList.Count + " book registered. * "); 
                                Console.ResetColor();                               
                                Console.ReadLine();                                 
                            }
                            else
                            {                                                      
                                Console.WriteLine("Now books available yet"); 
                            }
                            break;

                        case 3:                                                     // Menyval 2
                            isActive = false;
                            break;



                    }                   

                    // Console.WriteLine("\n\n\tName: \t\t\t{0}, \n\tAuthor: \t\t{1}, \n\tCategory: \t\t{2}, \n\tYear of publication: \t{3} ", firstBook.Title, firstBook.Author, firstBook.ISBN, firstBook.YearOfPublication);


                    //Console.WriteLine("\n\t Böcker i listan: ");
                    //foreach (Book book in bookList)
                    //{
                    //    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    //    Console.WriteLine("\n\t " + book + "\n ");
                    //    Console.ResetColor();
                    //}
                    //Console.WriteLine("\n\t\t Tryck på valfri knapp för att fortsätta");
                    //Console.Write("\t  ");
                    //Console.WriteLine("\tPress any key to exit");
                    //Console.ReadKey();



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
            Console.WriteLine("\n\t {0} \n\t Version {1} \n\t By {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

    }


    // going to change the program to this set up when all sub cats are done
    /*
    public static string AddBook(string title, string author, int yearOfPublicaion, string type)
    {
        
            switch (type)//Typ av bok är en del av underklassens särskilada egenskap
            {
                case "Novel":
                    bookList.Add(new Novel(title, author, yearOfPublicaion, available));
                    return "\n\tBook added to bookshelf!";
                    break;
                case "ShortStory":
                    bookList.Add(new ShortStory(title, author, yearOfPublicaion, available));
                    return "\n\tBook added to bookshelf!";
                    break;
                case "Journal":
                    bookList.Add(new Journal(title, author, yearOfPublicaion, available));
                    return "\n\tBook added to bookshelf!";
                    break;
                default:
                    return "\n\tPlease add all information before\n\t" +
                        "adding the book to the book shelf...";
                    break;
            }
        }
    */


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

       
    }


    //Underklasserna av klassen Bok (Book) Ärver Bok klassens egenskaper.
    //Type är en enskild egenskap för varje underklass av bok, beroende på vilken typ av bok man skapar så får underklasserna en unik egenskap

    internal class Novel : Book
            {
        internal Novel(string inputTitle, string inputAuthor, int inputYearOfPublication) :
               base(inputTitle, inputAuthor, inputYearOfPublication)
        {
            Type = "Novel";
        }

        public override string ToString() // Här börjar bokens ToString. Dess standardiserade utskrift
        {


            return "\n\t\t" + Title + " (" + YearOfPublication + ")"
            + "\n\t\t By:" + Author;
              //  + "\n\t\t" + Available;


        }
    }

    /*
    internal class ShortStory : Book
    {
        //internal ShortStory(string inputTitle, string inputAuthor, int inputYearOfPublication, bool inputAvailable)

        {
            Type = "ShortStory";
        }

        public override string ToString()
        {
            string available = "Book is in stock";
            if (!Available)
            {
                available = "Book is out of stock";
            }
            return  available;
        }
    }

    internal class Journal : Book
    {
        internal Jounal(string inputTitle, string inputAuthor, int inputYearOfPublication, bool inputAvailable)

        {
            Type = "Journal";
        }

        public override string ToString()
        {
            string available = "Book is in stock";
            if (!Available)
            {
                available = "Book is out of stock";
            }
            return available;
        }
    }

    */
}





