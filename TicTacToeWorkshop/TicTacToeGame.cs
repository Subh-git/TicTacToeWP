using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWorkshop
{
    public class TicTacToeGame
    {
        //declaring a char data type array of size 10 to accomodate all the 9 places in the game these are set to be empty.
        char[] choice = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        
        public void DisplayBoardUC1()
        {
            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", choice[1], choice[2], choice[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", choice[4], choice[5], choice[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", choice[7], choice[8], choice[9]);

            Console.WriteLine("     |     |      ");
        }
    }
}
