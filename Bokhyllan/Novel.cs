using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokhyllan
{
    internal class Novel : Book                              // Roman - Novel ärver bokens egenskaper och skapar en underklass av klassen Book - bok
    {
        internal Novel(string inputTitle, string inputAuthor, int inputYearOfPublication, int inputPages) :
               base(inputTitle, inputAuthor, inputYearOfPublication, inputPages)
        {
            Type = "Novel";
        }
        public override string ToString()                   // Novel ToString. Dess default utskrift
        {
            return "\n\t\tTitle: " + Title + " (" + YearOfPublication + ")"
            + "\n\t\tAuthor: " + Author
            + "\n\t\tBook type: " + Type
            + "\n\t\tPages: " + Pages;
            //  + "\n\t\t" + Available;                     // tänker om bokan är tillgänglig i ett bibiliotek, ej tillaggd än
        }
    }
}
