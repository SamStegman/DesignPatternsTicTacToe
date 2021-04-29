using System.Linq;

namespace CrawfisSoftware.TicTacToeFramework
{
    public class PlayerDumb : IPlayer
    {
        private readonly IGameBoard<int, CellState> gameBoard;
        private readonly IQueryGameState<int, CellState> gameState;
        private readonly System.Random random;
        private readonly CellState cellMarker;

        public PlayerDumb(CellState cellMarker, IGameBoard<int, CellState> gameBoard, IQueryGameState<int, CellState> gameState)
            : this(cellMarker, gameBoard, gameState, new System.Random())
        {
        }

        public PlayerDumb(CellState cellMarker, IGameBoard<int, CellState> gameBoard, IQueryGameState<int, CellState> gameState, System.Random random)
        {
            this.cellMarker = cellMarker;
            this.gameBoard = gameBoard;
            this.gameState = gameState;
            this.random = random;
        }

        public void TakeTurn()
        {            
                int index = random.Next(8);
                gameBoard.ChangeCellAttempt(index, cellMarker);            
        }
    }
}
