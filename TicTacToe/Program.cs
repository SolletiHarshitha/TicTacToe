using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
           TicTacToeGame uc1=new TicTacToeGame();
            char [] printBoard=uc1.CreateBoard();
            uc1.ToStartGame();
            uc1.ChooseXorO();
        }
        
    }
}
