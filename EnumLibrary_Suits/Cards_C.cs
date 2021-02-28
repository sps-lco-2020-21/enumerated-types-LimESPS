using System;
using System.Collections.Generic;
using System.Text;

namespace EnumLibrary_Suits
{
    public class Cards_C
    {
        Cards card;
        Suits suit;
        public Cards_C(Cards c, Suits s)
        {
            card = c;
            suit = s;
        }
        public void print()
        {
            Console.WriteLine($"{card.ToString()} of {suit.ToString()}");
        }
            
               
    }
    

}
