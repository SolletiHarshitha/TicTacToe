using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        public char [] board;
        public  char[] CreateBoard()
        {
            board = new char[10];
            for(int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
       
        public char ChooseXorO()
        {
            Console.WriteLine("Choose a letter either X or O for player input");
            char playerChoice = Convert.ToChar(Console.ReadLine());
            char computerChoice = ' ';
            if (playerChoice != 'X' || playerChoice != 'O')
            {
                Console.WriteLine("Choose a valid input");
            }
            else
            {
                computerChoice = (playerChoice == 'X') ? 'O' : 'X';
            }
            return computerChoice;
        }
    }
}
