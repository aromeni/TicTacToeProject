using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeProject
{
    public class Program
    {
        // Array to represent the game board
        public static char[] spaces = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static int player = 1; // to reepresent the current player
        static int choice; // to represent the chosen position on the game board
        static int flag; //  game state (win, draw, or continue)

        static void Main(string[] args)
        {
            DrawGameBoard();

            Console.ReadKey();
        }
        // Method to draw the game board
        static void DrawGameBoard()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ", spaces[0], spaces[1], spaces[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ", spaces[3], spaces[4], spaces[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ", spaces[6], spaces[7], spaces[8]);
            Console.WriteLine("     |     |     ");
        }

        /// <summary>
        /// Method to check if a player has won or  game has ended in a draw
        /// </summary>
        /// <returns></returns>
        static int CheckWin()
        {
            if (spaces[0] == spaces[1] && spaces[1] == spaces[2] ||    // horizontal
                spaces[3] == spaces[4] && spaces[4] == spaces[5] ||    // horizontal
                spaces[6] == spaces[7] && spaces[7] == spaces[8] ||    // horizontal
                spaces[0] == spaces[3] && spaces[3] == spaces[6] ||    // vertical
                spaces[1] == spaces[4] && spaces[4] == spaces[7] ||    // vertical
                spaces[2] == spaces[5] && spaces[5] == spaces[8] ||    // vertical
                spaces[0] == spaces[4] && spaces[4] == spaces[8] ||    // diagonal
                spaces[2] == spaces[4] && spaces[4] == spaces[6])       // diagonal
            {
                return 1; // Return 1 if a player has won
            }
            else if (spaces[0] != '1' &&
                     spaces[1] != '2' &&
                     spaces[2] != '3' &&
                     spaces[3] != '4' &&
                     spaces[4] != '5' &&
                     spaces[5] != '6' &&
                     spaces[6] != '7' &&
                     spaces[7] != '8' &&
                     spaces[8] != '9')
            {
                return -1; // Return -1 if the game has ended in a draw
            }
            else
            {
                return 0; // Return 0 to continue the game
            }
        }
        // Method to mark the selected position with 'X'
        static void DrawsX(int pos)
        {
            spaces[pos] = 'X';
        }

        // Method to mark the selected position with 'O'
        static void DrawsO(int pos)
        {
            spaces[pos] = 'O';
        }



    }
}
