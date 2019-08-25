using System;

namespace Roulette
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\tProgram.Main()");
            Console.WriteLine("\nHello, welcome to Roulette! \n Please enter the amount of money you have.");
            string StrWallet = Console.ReadLine(); int Wallet = Bets.StringtoInt(StrWallet);
            while (Wallet <= 0)
            {
                Console.WriteLine("That is not a valid input! Try again!");
                StrWallet = Console.ReadLine(); Wallet = Bets.StringtoInt(StrWallet);
            }
            StartGame(Wallet);
        }
        public static void StartGame(int Wallet)
        {
            if (Wallet <= 0)
            {
                Console.WriteLine("You do no have enough Money to play. :( Thanks for comming by come back soon!");
                Environment.Exit(-1); //Will terminate the application. 
            }
            if (Wallet > 0)
            {
                Wallet = RouletteGame.PlayRoulette(Wallet);
            }
            Console.WriteLine($"You now have ${Wallet}. Would you like to go again? \n\nEnter yes or no");
            string response = Console.ReadLine();
            if (response == "yes" || response == "Yes")
            {
                StartGame(Wallet);
            }
            if (response == "no" || response == "No")
            {
                Console.Clear();
                Console.WriteLine($"You are leaving with ${Wallet}! Hope you had fun come back soon!");
            }
        }
    }
}
