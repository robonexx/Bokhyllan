using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokhyllan
{
    internal class Journal : Book                            // Tidskrift - Journal ärver bokens egenskaper och skapar en underklass av klassen Book - bok
    {
        internal Journal(string inputTitle, string inputAuthor, int inputYearOfPublication, int inputPages) :
             base(inputTitle, inputAuthor, inputYearOfPublication, inputPages)

        {
            Type = "Journal";
        }


        public override string ToString()                   // Journal ToString. Dess default utskrift
        {
            return "\n\t\tTitle: " + Title + " (" + YearOfPublication + ")"
            + "\n\t\tAuthor: " + Author
            + "\n\t\tBook type: " + Type
            + "\n\t\tPages: " + Pages;

        }

    }
}
