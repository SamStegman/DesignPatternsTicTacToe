using System;
using System.Collections.Generic;

namespace CrawfisSoftware.TicTacToeFramework
{
    public interface IGameBoard<TCellID, TCellStateEnum> where TCellStateEnum : System.Enum
    {
        event Action<TCellID, TCellStateEnum, TCellStateEnum> ChangeCellRequested;
        event Action<TCellID, TCellStateEnum, TCellStateEnum> CellChanged;
        IEnumerable<string> Instructions { get; }
        void ChangeCellAttempt(TCellID cellID, TCellStateEnum newCellState);
    }
}