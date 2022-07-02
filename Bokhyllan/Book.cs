using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokhyllan
{
    internal abstract class Book
    {
        internal string Title;
        internal string Author;
        internal int YearOfPublication;
        internal int Pages;
        //  internal bool Available;                            // ej tillagd än tänker om man gör en boolean som visar om boken finns inne eller ej

        internal string Type;                                   // type är en egenskap som kommer från underklasserna



        public Book(string inputTitle, string inputAuthor, int inputYearOfPublication, int inputPages)
        {
            Title = inputTitle;
            Author = inputAuthor;
            YearOfPublication = inputYearOfPublication;
            Pages = inputPages;
            //  Available = inputAvailable;                     // ej tillagd än


        }

    }
}
