using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    public class Bets : The_Board 
    {
        public static int StringtoInt(string input) //Created Method to convert User's string number to int.
        {
            int number;
            bool x = int.TryParse(input, out number);
            return number;
        }
        public static int RandomNumberGen() //Method to create a random number from the board.
        {
            int[] Numbers = NumbersOnBoard();
            Random random = new Random();
            int randomNumber = Numbers[random.Next(Numbers.Length)];
            return randomNumber;
        }
        public static string RandomColorGen() //Method to create a random color from the board.
        {
            string[] Colors = ColorsOnBoard();
            Random random = new Random();
            string randomColor = Colors[random.Next(Colors.Length)];
            return randomColor;
        }
        public static int[] GetStreet(int input) //Method to create the street according to the first street number. 
        {
            int StreetNumTwo = input + 1;
            int streetNumThree = input + 2;
            int[] Street = new int[3] {input, StreetNumTwo, streetNumThree};
            return Street;
        }
        public static int[] GetSixNumbers(int input) //Method to create 6 Numbers according to the first number. 
        {
            int[] Arr = new int[6];
            for (int x = 0; x < Arr.Length; x++)
            {
                Arr[x] = input + x;
            }
            return Arr;
        }
        public static string Numbers()
        {
            Console.WriteLine("What number would you like to bet?");
            string NumBet = Console.ReadLine();
            int Bet = StringtoInt(NumBet);
            int result = 1;
            string GameResult = "You lost!";
            Console.WriteLine($"\nBall laned on {result}");
            if (Bet == result)
            {
                GameResult = "You won!";
            }
            return GameResult;
        }
        public static string EvenOrOdds()
        {
            Console.WriteLine("Are you betting on evens or odds?");
            string EvensOrOdds = Console.ReadLine(); string GameResult = "You lost!";
            if (EvensOrOdds == "evens")
            {
                int result = RandomNumberGen();
                Console.WriteLine($"\nBall laned on {result}");
                if (result % 2 == 0)
                {
                    GameResult= "You won!";
                }
            }
            if (EvensOrOdds == "odds")
            {
                int result = RandomNumberGen();
                Console.WriteLine($"\nBall laned on {result}");
                if (result % 2 == 1)
                {
                    GameResult = "You won!";
                }
            }
            return GameResult;
        }
        public static string RedOrBlack()
        {
            Console.WriteLine("Are you betting on red or black?");
            string RedOrBlack = Console.ReadLine(); string GameResult = "You lost!";
            string result = RandomColorGen();
            Console.WriteLine($"Ball landed on {result}");
            if (RedOrBlack == "red" && result == "Red")
            {
                GameResult = "You won!";
            }
            if (RedOrBlack == "black" && result == "Black")
            {
                GameResult = "You won!";
            }
            return GameResult;
        }
        public static string LowsOrHighs()
        {
            Console.WriteLine("Are you betting on lows or highs?");
            string LowOrHigh = Console.ReadLine(); string GameResult = "You lost!";
            int[] lows = The_Board.Lows(); int[] highs = The_Board.Highs();
            int result = 5;
            Console.WriteLine($"Ball landed on {result}");
            if (LowOrHigh == "lows")
            {
                for (int x = 0; x < lows.Length; x++)
                {
                    if (result == lows[x])
                    {
                        GameResult = "You won!";
                    }
                }
            }
            else if (LowOrHigh == "highs")
            {
                for (int x = 0; x < highs.Length; x++)
                {
                    if (result == highs[x])
                    {
                        GameResult = "You won!";
                    }
                }
            }
            return GameResult;
        }
        public static string Dozens()
        {
            Console.WriteLine("Enter which set of dozens you'll be betting on. \n 1-12 \t 13-24 \t 25-36\n");
            string UserDoz = Console.ReadLine(); string GameResult = "You lost!";
            int[] FirstDoz = The_Board.DozensRowOne(); int[] SecoundDoz = The_Board.DozensRowTwo(); int[] ThirdDoz = The_Board.DozensRowThree();
            int spin = RandomNumberGen();
            Console.WriteLine($"Ball landed on {spin}");
            if(UserDoz == "1-12")
            {
                for (int x = 0; x < FirstDoz.Length; x++)
                {
                    if (spin == FirstDoz[x])
                    {
                        GameResult = "You won!";
                    }
                }
            }
            if(UserDoz == "13-24")
            {
                for (int x = 0; x < SecoundDoz.Length; x++)
                {
                    if (spin == SecoundDoz[x])
                    {
                        GameResult = "You won!";
                    }
                }
            }
            if(UserDoz == "25-36")
            {
                for (int x = 0; x < ThirdDoz.Length; x++)
                {
                    if (spin == ThirdDoz[x])
                    {
                        GameResult = "You won!";
                    }
                }
            }
            return GameResult;
        }
        public static string Columns()
        {
            Console.WriteLine("Enter the column you will be playing on. Column One, Column Two, Column Three.");
            string UserCol = Console.ReadLine(); string GameResult = "You lost!";
            int[] ColOne = ColumnOne(); int[] ColTwo = ColumnTwo(); int[] ColThree = ColumnThree();
            int spin = RandomNumberGen(); Console.WriteLine($"Ball landed on {spin}");
            if (UserCol == "Column One")
            {
                for(int x = 0; x < ColOne.Length; x++)
                {
                    if(spin == ColOne[x])
                    {
                        GameResult = "You won!";
                    }
                }
            }
            if (UserCol == "Column Two")
            {
                for (int x =0; x < ColTwo.Length; x++)
                {
                    if (spin == ColTwo[x])
                    {
                        GameResult = "You won!";
                    }
                }
            }
            if(UserCol == "Column Three")
            {
                for(int x = 0; x < ColThree.Length; x++)
                {
                    if(spin == ColThree[x])
                    {
                        GameResult = "You won!";
                    }
                }
            }
            return GameResult;
        }
        public static string Street()
        {
            Console.WriteLine("Enter the first number of the street youll be playing on: " +
                "\n\t 1,  4,  7,  10,  13,  16,  19,  22,  25,  28,  31,  or 34.");
            string UserStreet = Console.ReadLine(); string GameResult = "You lost!";
            int intUserStreet = StringtoInt(UserStreet); int[] ArryUserStreet = GetStreet(intUserStreet);
            int spin = RandomNumberGen(); Console.WriteLine($"Ball landed on {spin}.");
            for (int x = 0; x < ArryUserStreet.Length; x++)
            {
                if (spin == ArryUserStreet[x])
                {
                    GameResult = "You won!";
                }
            }
            return GameResult;
        }
        public static string SixNumbers()
        {
            Console.WriteLine("Enter the first number of the 6 Numbers you will be betting on :" +
                "\n\t 1,  7,  13,  19,  25, or 31 ");
            string UserSix = Console.ReadLine(); string GameResult = "You lost!";
            int intUserSix = StringtoInt(UserSix); int[] ArryUserSix = GetSixNumbers(intUserSix);
            int spin = RandomNumberGen(); Console.WriteLine($"Ball landed on {spin}");
            for (int element = 0; element < ArryUserSix.Length; element++ )
            {
                if (spin == ArryUserSix[element])
                {
                    GameResult = "You won!";
                }
            }
            return GameResult;
        }
        public static string Split()
        {
            Console.WriteLine("Enter the two Split Numbers (Press enter after typeing the number)");
            string One = Console.ReadLine(); string Two = Console.ReadLine();
            int NumOne = StringtoInt(One); int NumTwo = StringtoInt(Two);
            int spin = RandomNumberGen(); Console.WriteLine($"Ball landed on {spin}");
            string GameResult = "You lost!";
            if (spin == NumOne || spin == NumTwo)
            {
                GameResult = "You won!";
            }
            return GameResult;
        }
        public static string Corner()
        {
            Console.WriteLine("Enter the number to the bottom left corner you would like to bet");
            string StrUserCorner = Console.ReadLine(); string gameresult = "You lost!";
            int Num = StringtoInt(StrUserCorner);
            int spin = RandomNumberGen(); Console.WriteLine($"Ball landed on {spin}");
            if (spin == Num || spin == Num + 1 || spin == Num + 3 || spin == Num + 4)
            {
                gameresult = "You won";
            }
            return gameresult;
        }
    }
}
