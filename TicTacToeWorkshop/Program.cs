using System;

namespace TicTacToeWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Welcome to The tic tac toe board game!-------");
            TicTacToeGame game = new TicTacToeGame();
            game.DisplayBoardUC1();
        }
    }
}
