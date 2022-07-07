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
       
        internal string Type;                                   // type är en egenskap som kommer från underklasserna



        internal Book(string inputTitle, string inputAuthor, int inputYearOfPublication, int inputPages)
        {
            Title = inputTitle;
            Author = inputAuthor;
            YearOfPublication = inputYearOfPublication;
            Pages = inputPages;

    }
        

    }
}
