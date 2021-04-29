using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawfisSoftware.TicTacToeFramework
{
    public class PlayerConsoleUnsafe : IPlayer
    {
        private readonly CellState playerMark;
        private readonly IGameBoard<int, CellState> gameBoard;

        public PlayerConsoleUnsafe(CellState playerMark, IGameBoard<int,CellState> gameBoard)
        {
            this.playerMark = playerMark;
            this.gameBoard = gameBoard;
        }

        public void TakeTurn()
        {
            Console.Write("Player {0}'s turn. Enter cellID (1-9):  ", playerMark);
            var input = Console.ReadLine();
            int cellID = 0;
            bool valid = false;
            while (!valid)
            {
                valid = verifyInput(input, out cellID);
                if(!valid)
                {
                    Console.Write("input {0} was invalid. Please enter a number (1-9): ", input);
                    input = Console.ReadLine();
                }
            }
            gameBoard.ChangeCellAttempt(cellID - 1, playerMark);
            
        }

        private bool verifyInput(string input, out int cellID)
        {
            bool converted = int.TryParse(input, out cellID);
            if (converted && cellID >= 1 && cellID <= 9)
            {
                return true;
            }
            return false;
        }
    }
}
