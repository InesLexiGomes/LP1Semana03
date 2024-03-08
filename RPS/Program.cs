using System;
using GameItem;
using GameStatus;

namespace RPS
{
    class Program
    {
        private static void Main(string[] args)
        {
            int result = RockPaperScissors(args[0], args[1]);
            switch (result)
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static int RockPaperScissors(string player1, string player2)
        {
            player1 = player1.ToLower();
            player2 = player2.ToLower();
            int tempRes = 0;
            if (player1 == player2)
            {
                tempRes = (int)Status.Draw; // Draw
            }
            else if (((player1 == Items.Rock.ToString().ToLower())
                && (player2 == Items.Scissors.ToString().ToLower())) ||

                ((player1 == Items.Scissors.ToString().ToLower())
                && (player2 == Items.Paper.ToString().ToLower())) ||

                ((player1 == Items.Paper.ToString().ToLower())
                && (player2 == Items.Rock.ToString().ToLower())))
            {
                tempRes = (int)Status.Player1Wins; // Player 1 wins
            }
            else
            {
                tempRes = (int)Status.Player2Wins; // Player 2 wins
            }
            return tempRes;
        }
    }
}
