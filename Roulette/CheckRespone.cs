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
            if (!strGameType.Equals("Numbers") && !strGameType.Equals("Evens/Odds") && !strGameType.Equals ("Reds/Blacks") && !strGameType.Equals ("Lows/Highs") 
                && !strGameType.Equals ("Dozens") && !strGameType.Equals("Columns") &&  !strGameType.Equals("Street") && !strGameType.Equals ("6 Numbers")
                && !strGameType.Equals ("Split") && !strGameType.Equals ("Corner"))
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
