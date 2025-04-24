using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChessMenu();
        }



        static void ChessMenu()
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

                int x = int.Parse(Console.ReadLine());

                Console.Write("Y: ");
                int y = int.Parse(Console.ReadLine());
                Console.ResetColor();

                if (x <= 0 || y <= 0 || x > 8 || y > 8)
                {
                   
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect coordinates!!! Please, enter correct coordinates (X and Y) from 1 to 8:");

                    Console.ResetColor();
                    return;
                }
                ChessBoardBuilder(y, x);


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



        static void ChessBoardBuilder(int x, int y)
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

                    Console.Write(FigurePrinter(x, y, i, j));


                    Console.ForegroundColor = ConsoleColor.Gray;
                }


                Console.ResetColor();
                Console.WriteLine();
            }

            ChessLettersPrinter();

        }


        static string FigurePrinter(int x, int y, int i, int j)
        {

            if (i == x && j == y)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return " F";
            }

            return "  ";

        }



        static void ChessLettersPrinter()
        {
            Console.Write("   ");
            for (char c = 'A'; c <= 'H'; c++)
            {
                Console.Write($" {c}");
            }
            Console.WriteLine();


        }









    }
}
