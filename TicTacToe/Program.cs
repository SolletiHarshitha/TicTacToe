using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
           TicTacToeGame uc1=new TicTacToeGame();
            uc1.CreateBoard();
            uc1.ToStartGame();
            uc1.ChooseXorO();
        }
        
    }
}
