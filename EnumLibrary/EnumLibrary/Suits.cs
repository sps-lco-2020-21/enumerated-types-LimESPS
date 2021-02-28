using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumLibrary
{
    [Flags]
    public enum Suits
    {
        Spades = 1,
        Clubs = 2,
        Diamonds = 4,
        Hearts = 8, 

        Red = Diamonds | Hearts, //diamonds or hearts are red
        Black = Spades | Clubs 
           


    }

}
