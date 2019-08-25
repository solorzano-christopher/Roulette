using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class RouletteGame
    {
        public static int PlayRoulette(int Wallet)
        {
            Console.Clear();
            Console.WriteLine("\nWhat would you like to play?\n \nNumbers,  Evens/Odds,  Reds/Blacks, " +
                              " Lows/Highs,  Dozens,  Columns,  Street,  6 Numbers,  Split,  or Corner.\n");
            string StrGameType = Console.ReadLine(); string result = "";
            string GameType = CheckRespone.GameType(StrGameType);
            Console.WriteLine($"How much would you like to bet? You have {Wallet}");
            string StrBet = Console.ReadLine(); int bet = Bets.StringtoInt(StrBet);
            while (bet < 0)
            {
                Console.WriteLine("That is not a valid number! Try again!");
                StrBet = Console.ReadLine(); bet = Bets.StringtoInt(StrBet);
            }
            while (Wallet < bet)
            {
                Console.WriteLine("You do not have that much money! Enter a amount you have!");
                StrBet = Console.ReadLine(); bet = Bets.StringtoInt(StrBet);
            }
            Wallet -= bet; Console.Clear();
            Console.WriteLine($"\nPlaying {GameType}");
            if (GameType == "Numbers") 
            {
               result = Bets.Numbers(); //Pay 35 to 1 
                if (result == "You won!")
                {
                    Wallet += (bet * 36);
                }
            }
            if (GameType == "Evens/Odds")
            {
               result = Bets.EvenOrOdds(); //Pays 1 to 1
                if (result == "You won!")
                {
                    Wallet += (bet * 2);
                }
            }
            if (GameType == "Reds/Blacks") 
            {
               result = Bets.RedOrBlack(); //Pays 1 to 1
                if (result == "You won!")
                {
                    Wallet += (bet * 2);
                }
            }
            if (GameType == "Lows/Highs")
            {
                result = Bets.LowsOrHighs();//Pays 1 to 1
                if (result == "You won!")
                {
                    Wallet += (bet * 2);
                }
            }
            if (GameType == "Dozens")
            {
                result = Bets.Dozens(); //Pays 2 to 1
                if (result == "You won!")
                {
                    Wallet += (bet * 3);
                }
            }
            if (GameType == "Columns")
            {
                result = Bets.Columns(); //Pays 2 to 1
                if (result == "You won!")
                {
                    Wallet += (bet * 3);
                }
            }
            if (GameType == "Street") 
            {
                result = Bets.Street(); //Pays 11 to 1
                if (result == "You won!")
                {
                    Wallet += (bet * 12);
                }
            }
            if (GameType == "6 Numbers")  
            {
                result = Bets.SixNumbers();//Pays 5 to 1 
                if (result == "You won!")
                {
                    Wallet += (bet * 6);
                }
            }
            if (GameType == "Split")
            {
                result = Bets.Split(); // Pays 17 to 1 
                if (result == "You won!")
                {
                    Wallet += (bet * 18);
                }
            }
            if (GameType == "Corner") 
            {
                result = Bets.Corner(); //Pays 8 to 1
                if (result == "You won!")
                {
                    Wallet += (bet * 9);
                }
            }
            Console.WriteLine(result);
            return Wallet;
        }
    }
}
