using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    public class The_Board
    {
        public static string[] ColorsOnBoard()
        {
            string[] ColorsOnBoard = new string[38]
            {
                "Green", "Green", "Black", "Red", "Black", "Red", "Black", "Red",
                "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black",
                "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red",
                "Black", "Red", "Black", "Red",
            };
            return ColorsOnBoard;
        }
        public static int[] NumbersOnBoard()
        {
            int[] Numbers = new int[38]
            {
                0, 00, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18,
               19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36
            };
            return Numbers;
        }
        public static int[] Lows()
        {
            int[] Lows = new int[18]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18,
            };
            return Lows;
        }
        public static int[] Highs()
        {
            int[] Highs = new int[18]
            {
                19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36
            };
            return Highs;
        }
        public static int[] DozensRowOne()
        {
            int[] One = new int[12]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            };
            return One;
        }
        public static int[] DozensRowTwo()
        {
            int[] Two = new int[12]
            {
                13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24
            };
            return Two;
        }
        public static int[] DozensRowThree()
        {
            int[] Three = new int[12]
            {
                25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36
            };
            return Three;
        }
        public static int[] ColumnOne()
        {
            int[] One = new int[12]
            {
                1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34
            };
            return One;
        }
        public static int[] ColumnTwo()
        {
            int[] Two = new int[12]
            {
                2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35
            };
            return Two;
        }
        public static int[] ColumnThree()
        {
            int[] Three = new int[12]
            {
                3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36
            };
            return Three;
        }
    }
}
