using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumLibrary_Suits;
namespace Enuemerated_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            q2();
            q4();
            q5andq6();
            Console.ReadKey();
                
        }
        static void q2()
        {
            List<Cards> input = new List<Cards> { Cards.Ace, Cards.Two, Cards.Two,Cards.Three, Cards.Eleven, Cards.Ace,Cards.Eleven };
            bool Ace_is_high = true; //change to false if you want Ace to be one, leave as true for ace to be 11.
            List<Cards> input2 = new List<Cards>();
            foreach(Cards item in input) //my answer to 2a
            {
                if (item == Cards.Ace && Ace_is_high)
                    input2.Add(Cards.Eleven);
                else if (item == Cards.Ace && !Ace_is_high)
                    input2.Add(Cards.One);
                else
                    input2.Add(item);


            }
            int result = Suits_Utilities.Card_run(input2);
            Console.WriteLine("Longest run is: {0}", result);

        }
        static void q4()
        {
            Cards my = Cards.One;
            Cards_C card = new Cards_C(Cards.Two,Suits.Spades);
            List<string> attempts = new List<string> { "OH", "TH", "5d", "5D", "OS" }; //number then type
            foreach(string item in attempts)
            {
                List<string> letter = (from x in item.ToCharArray() select x.ToString()).ToList();
                int num = Suits_Utilities.Cardnum_convert(letter[0]);
                int suit = Suits_Utilities.CardType_convert(letter[1]);
                if(num < 20 && suit < 20)
                {
                    Cards cardnum = (Cards)num;
                    Suits cardsuit = (Suits)suit;
                    Console.WriteLine($"{cardnum} of {cardsuit}");
                }
                else
                {
                    Console.WriteLine($"{item} is an invalid entry");
                }
            }
        }
        static void q5andq6()
        {
            List<Cards_C> Deck = new List<Cards_C>();
           
            for(int i = 1; i <= 13; ++i)
            {
                for(int x = 1;x<=8 ;x = x+x)
                {
                    Cards_C card = new Cards_C((Cards)i, (Suits)x);
                    Deck.Add(card);
                }
            }
            
            int n = 10;
            List<Cards_C> hand = Deck.shuffle(n);
            Console.WriteLine($"Your shuffled hand of {n} cards is: ");
            foreach(Cards_C item in hand)
            {
                item.print();
            }
        }
    }
}
