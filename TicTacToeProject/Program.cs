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

    }
}
