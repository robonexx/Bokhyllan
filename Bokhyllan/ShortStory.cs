using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokhyllan
{
    internal class ShortStory : Book                        // Novellsamling - Short story ärver bokens egenskaper och skapar en underklass av klassen Book - bok
    {
        internal ShortStory(string inputTitle, string inputAuthor, int inputYearOfPublication, int inputPages) :
             base(inputTitle, inputAuthor, inputYearOfPublication, inputPages)

        {
            Type = "ShortStory";
        }
        public override string ToString()                   // Shortstory ToString. Dess default utskrift
        {
            return "\n\t\tTitle: " + Title + " (" + YearOfPublication + ")"
            + "\n\t\tAuthor: " + Author
            + "\n\t\tBook type: " + Type
            + "\n\t\tPages: " + Pages;

        }

    }
}
