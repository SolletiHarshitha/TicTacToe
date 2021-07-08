using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
           TicTacToeGame game=new TicTacToeGame();
            char [] printBoard=game.CreateBoard();
            
            char computerValue=game.ChooseXorO();
            Console.WriteLine("Computer value is :"+computerValue);
            
        }
        
    }
}
