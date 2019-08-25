using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class CheckRespone
    {
        public static string GameType (string input)
        {
            string strGameType = input;
            if (!input.Equals("Numbers") && !input.Equals("Evens/Odds") && !input.Equals ("Reds/Blacks") && !input.Equals ("Lows/Highs") 
                && !input.Equals ("Dozens") && !input.Equals("Columns") &&  !input.Equals("Street") && !input.Equals ("6 Numbers")
                && !input.Equals ("Split") && !input.Equals ("Corner"))
            {
                Console.Clear();
                Console.WriteLine("Not a valid entry! Try again!");
                Console.WriteLine("\nWhat would you like to play?\n \nNumbers,  Evens/Odds,  Reds/Blacks, " +
                              " Lows/Highs,  Dozens,  Columns,  Street,  6 Numbers,  Split,  or Corner.\n");
                strGameType = Console.ReadLine();
                GameType(strGameType);
            }
            return strGameType;
        }
    }
}
