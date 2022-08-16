using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        private static int turnCounter = 0;
        private static char currentTurn = 'X';

        private static void Main(string[] args)
        {
            InitBoard();
            while (true)
            {
                Console.Clear();
                DisplayBoard();
                UpdateBoard();

                if (turnCounter > 8 || IsWinner())
                {
                    Console.Clear();
                    DisplayBoard();
                    Console.WriteLine("\n Game Over!!");
                    break;
                }

                ChangeTurn();
            }

            if (IsWinner())
            {
                Console.WriteLine($" >>  {currentTurn} has won!!");
            }
            else 
            { 
                Console.WriteLine($" >>  It's a draw!!");
            }

            Console.ReadKey();
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                {
                    board[r, c] = ' ';
                }
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("        0   1   2");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("  0 ||  " + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2] + "  ||");
            Console.WriteLine("    || ---+---+--- ||");
            Console.WriteLine("  1 ||  " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2] + "  ||");
            Console.WriteLine("    || ---+---+--- ||");
            Console.WriteLine("  2 ||  " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2] + "  ||");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-");
        }

        private static void UpdateBoard() 
        {
            int chosenRow;
            int chosenColumn;

            while (true)
            {
                Console.WriteLine($"|| Current turn :: {currentTurn}");

                chosenRow = GetChosenCoordinates("row");
                chosenColumn = GetChosenCoordinates("column");

                if (board[chosenRow, chosenColumn] == ' ')
                {
                    break;
                }

                Console.WriteLine("\n\n >> Can't make that move!!\n");
            }

            board[chosenRow, chosenColumn] = currentTurn;
            turnCounter++;
        }

        private static int GetChosenCoordinates( string rowOrColumn)
        {
            Console.Write($"\nPlease input {rowOrColumn} :  ");
            while (true)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                int inputNumericValue = (int)char.GetNumericValue(userInput.KeyChar);

                if (char.IsDigit(userInput.KeyChar) && inputNumericValue > -1 && inputNumericValue < 3)
                {
                    return (int)char.GetNumericValue(userInput.KeyChar);
                }
            }
        }

        private static void ChangeTurn() 
        {
            if (turnCounter % 2 == 0)
            {
                currentTurn = 'X';
            }
            else
            {
                currentTurn = '0';
            }
        }

        private static bool IsWinner() 
        {
            // row check
            if (board[0, 0] == currentTurn && board[0,1] == currentTurn && board[0,2] == currentTurn) 
            {
                return true;
            }
            if (board[1, 0] == currentTurn && board[1, 1] == currentTurn && board[1, 2] == currentTurn)
            {
                return true;
            }
            if (board[2, 0] == currentTurn && board[2, 1] == currentTurn && board[2, 2] == currentTurn)
            {
                return true;
            }
            // column check
            if (board[0, 0] == currentTurn && board[1, 0] == currentTurn && board[2, 0] == currentTurn)
            {
                return true;
            }
            if (board[0, 1] == currentTurn && board[1, 1] == currentTurn && board[2, 1] == currentTurn)
            {
                return true;
            }
            if (board[0, 2] == currentTurn && board[1, 2] == currentTurn && board[2, 2] == currentTurn)
            {
                return true;
            }
            // diag check
            if (board[0, 0] == currentTurn && board[1, 1] == currentTurn && board[2, 2] == currentTurn)
            {
                return true;
            }
            if (board[0, 2] == currentTurn && board[1, 1] == currentTurn && board[2, 0] == currentTurn)
            {
                return true;
            }

            return false;
        }
    }
}
