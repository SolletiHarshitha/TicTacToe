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
            for(int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        public void ToStartGame()
        {
            Random random = new Random();
            int player = random.Next(0, 2);
            if(player==1)
            {
                Console.WriteLine("Player starts a game");

            }
            else
            {
                Console.WriteLine("Computer starts a game");
            }
        }
        public void ChooseXorO()
        {
            Console.WriteLine("Choose a letter either X or O");
            char playerLetter = Convert.ToChar(Console.ReadLine());
            char computerLetter=' ';
            if (playerLetter.Equals('X'))
            {
                computerLetter = 'O';
            }
            else
            {
                computerLetter = 'X';
            }
            Console.WriteLine("Player has choosen : "+playerLetter);
            Console.WriteLine("Computer has choosen: "+computerLetter);
            
        }
    }
}
