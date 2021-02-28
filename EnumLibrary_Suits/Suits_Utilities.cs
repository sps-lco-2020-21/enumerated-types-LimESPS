using System;
using System.Collections.Generic;
using System.Text;

namespace EnumLibrary_Suits
{
    public static class Suits_Utilities
    {
        public static int Card_run(List<Cards> run)
        {
            int count = run.Count();
            int max = 1;
            Cards previous = run[0];
            int consec = 1;
            for (int i = 1; i+1< run.Count(); ++i)
            {
                
                if(run[i] == previous+1 || run[i] == previous)
                {
                    ++consec;
                    previous = run[i];
                }
                else
                {
                    previous = run[i];
                    if (consec > max)
                        max = consec;
                    consec = 1;
                }

            }
            return max;
        }
        
        static int Count(this List<Cards> run)
        {
            int count = 0;
            foreach(Cards item in run)
            {
                ++count;
            }
            return count;
        }
        public static int Cardnum_convert(string m)
        {
            bool success = Enum.TryParse(m, out Card_S val) ;
            

            if (success)
            {
               
                return (int)val;
            }

            else
            {
                
                return 1000;
            }
            

        }
        public static int CardType_convert(string m)
        {
            bool success = Enum.TryParse(m, out Suits2 val);


            if (success)
            {
                
                return (int)val;
            }

            else
            {
                
                return 1000;
            }
        }
        public static List<Cards_C> shuffle(this List<Cards_C> deck,int n)
        {
            List<Cards_C> hand = new List<Cards_C>();
            while (hand.Count < n)
            {
                Random r = new Random();
                int c = r.Next(1, 52);
                Cards_C add = deck[c];
                if (!hand.Contains(add))
                    hand.Add(add);
            }
            return hand;
        }

    }
}
