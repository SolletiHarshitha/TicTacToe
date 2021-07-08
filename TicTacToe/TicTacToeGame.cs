using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        public char [] board;
        /// <summary>
        /// Use Case 1
        /// </summary>
        /// <returns></returns>
        public  char[] CreateBoard()
        {
            board = new char[10];
            for(int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        /// <summary>
        /// Use Case 2
        /// </summary>
        /// <returns></returns>
        public char GetPlayerInput()
        {
            Console.WriteLine("Choose a letter either X or O for player input");
            char playerChoice = Convert.ToChar(Console.ReadLine());
            return playerChoice;
        }

        public char GetComputerInput(char playerChoice)
        { 
            char computerChoice = ' ';
            if (playerChoice == 'X' || playerChoice == 'O')
            {
                computerChoice = (playerChoice == 'X') ? 'O' : 'X';
                
            }
            else
            {
                Console.WriteLine("Choose a valid input");
            }
            return computerChoice;
        }
        
    }
}
