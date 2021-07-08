using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
            TicTacToeGame game = new TicTacToeGame();
            char[] printBoard = game.CreateBoard();
            char playerValue = game.GetPlayerInput();
            char computerValue = game.GetComputerInput(playerValue);
            Console.WriteLine("Computer value is :" + computerValue + "\n");
            game.DisplayBoard();
        }

    }
}
