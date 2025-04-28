using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Chess;

    internal class NewChess
    {

   public static void ChessMenu()
    {
        bool flag = true;
        do
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The new game has started!");
            Console.WriteLine("Enter coordinates (X and Y) from 1 to 8:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("X: ");
            bool x = int.TryParse(Console.ReadLine(), out int cX);
            Console.Write("Y: ");
            bool y = int.TryParse(Console.ReadLine(), out int cY);
            Console.Write("Z: ");
            bool z = int.TryParse(Console.ReadLine(), out int cZ);
            Console.Write("W: ");
            bool w = int.TryParse(Console.ReadLine(), out int cW);
            Console.ResetColor();
            if (cX <= 0 || cY <= 0 || cX > 8 || cY > 8 || cZ <= 0 || cW <= 0 || cZ > 8 || cW > 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect coordinates!!! Please, enter correct coordinates (X and Y) from 1 to 8:");
                Console.ResetColor();
                return;
            }
            ChessBoardBuilder(cX, cY, cZ, cW);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("If you want to exit the menu, type <<Exit>> or type <<Start>> to continue");
            string? button = Console.ReadLine();
            Console.ResetColor();

            if (button.Equals("Exit") || button == null || !button.Equals("Start"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Game Over!");
                flag = false;
                Console.ResetColor();
            }
        } while (flag);
    }
    /// <summary>
    ///  if (i == x && j == y || i == w && j == z) In a logical construction, i == x && j == y || i == w && j == z to preserve the logic of the chessboard coordinates. For example: A1 - C3
    /// </summary>
    /// <param name="x">coordinate x</param>
    /// <param name="y">coordinate y</param>
    /// <param name="z">coordinate z</param>
    /// <param name="w">coordinate w</param>

    public static void ChessBoardBuilder(int x, int y, int w, int z)
    {
        string[,] chessTable = new string[8, 8];
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.ResetColor();
        ChessLettersPrinter();
        for (int i = 1; i <= chessTable.GetLength(0); i++)
        {
            Console.Write($" {i} ");
            for (int j = 1; j <= chessTable.GetLength(1); j++)
            {
                if ((i + j) % 2 == 0)
                    Console.BackgroundColor = ConsoleColor.White;
                else
                    Console.BackgroundColor = ConsoleColor.Black;

                /// ValidatorRookFigureCoordinates(int x, int y, int w, int z) insert here
                bool isRookFigure = x != z && y == w || x == z && y != w && y != w || i == x && j == y || i == w && j == z;
                if (isRookFigure)
                {
                
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" H");                
                }
                else
                {
                    Console.Write("  ");
                }
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.ResetColor();
            Console.WriteLine();
        }
        ChessLettersPrinter();
    }
    public static void ChessLettersPrinter()
    {
        Console.Write("   ");
        for (char c = 'A'; c <= 'H'; c++)
        {
            Console.Write($" {c}");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// This method checks the validity of the entered data so that two coordinate points are equal and two are not equal cX != cZ && y == cW || x == cZ && y != cW
    /// </summary>
    /// <param name="x">coordinate x</param>
    /// <param name="y">coordinate y</param>
    /// <param name="z">coordinate z</param>
    /// <param name="w">coordinate w</param>
    /// <returns>if the entered data is valid, return true</returns>
    //static bool ValidatorRookFigureCoordinates(int x, int y, int w, int z)
    //{

    //    return x!= z && y == w || x == z && y != w;


    // }

    // ----------------------OLD Version----------------------------------

    //static void ChessMenu()
    //{
    //    bool flag = true;
    //    do
    //    {
    //        Console.ForegroundColor = ConsoleColor.Blue;
    //        Console.WriteLine("The new game has started!");
    //        Console.WriteLine("Enter coordinates (X and Y) from 1 to 8:");
    //        Console.ResetColor();
    //        Console.ForegroundColor = ConsoleColor.Yellow;
    //        Console.Write("X: ");
    //        bool x = int.TryParse(Console.ReadLine(), out int cX);
    //        Console.Write("Y: ");
    //        bool y = int.TryParse(Console.ReadLine(), out int cY);
    //        Console.ResetColor();

    //        if (cX <= 0 || cY <= 0 || cX > 8 || cY > 8)
    //        {
    //            Console.ForegroundColor = ConsoleColor.Red;
    //            Console.WriteLine("Incorrect coordinates!!! Please, enter correct coordinates (X and Y) from 1 to 8:");
    //            Console.ResetColor();
    //            return;
    //        }
    //        ChessBoardBuilder(cX, cY);
    //        Console.ForegroundColor = ConsoleColor.Green;
    //        Console.WriteLine("If you want to exit the menu, type <<Exit>> or type <<Start>> to continue");
    //        string? button = Console.ReadLine();
    //        Console.ResetColor();

    //        if (button.Equals("Exit") || button == null || !button.Equals("Start"))
    //        {
    //            Console.ForegroundColor = ConsoleColor.Red;
    //            Console.WriteLine("Game Over!");
    //            flag = false;
    //            Console.ResetColor();
    //        }
    //    } while (flag);
    //}
    //static void ChessBoardBuilder(int x, int y)
    //{
    //    string[,] chessTable = new string[8, 8];
    //    Console.ForegroundColor = ConsoleColor.Blue;
    //    Console.ResetColor();
    //    ChessLettersPrinter();
    //    for (int i = 1; i <= chessTable.GetLength(0); i++)
    //    {
    //        Console.Write($" {i} ");
    //        for (int j = 1; j <= chessTable.GetLength(1); j++)
    //        {
    //            if ((i + j) % 2 == 0)
    //                Console.BackgroundColor = ConsoleColor.White;
    //            else
    //                Console.BackgroundColor = ConsoleColor.Black;
    //            if (i == x && j == y)
    //            {
    //                Console.ForegroundColor = ConsoleColor.Red;
    //                Console.Write(" F");
    //            }
    //            else
    //            {
    //                Console.Write("  ");
    //            }

    //            Console.ForegroundColor = ConsoleColor.Gray;
    //        }
    //        Console.ResetColor();
    //        Console.WriteLine();
    //    }
    //    ChessLettersPrinter();
    //}
    //static void ChessLettersPrinter()
    //{
    //    Console.Write("   ");
    //    for (char c = 'A'; c <= 'H'; c++)
    //    {
    //        Console.Write($" {c}");
    //    }
    //    Console.WriteLine();
    //}
}

