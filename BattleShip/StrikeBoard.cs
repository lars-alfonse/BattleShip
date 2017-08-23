using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class StrikeBoard : GameBoard
    {
        CoordinateSelector coordinateSelector = new CoordinateSelector();
        GameBoard opponentBoard;
        public StrikeBoard(GameBoard gameboard)
        {
           opponentBoard = gameboard;
           for (int i = 0; i <  gameboard.Rows.Count; i++)
            {
                Rows[i] = new List<GameBoardSpace>();
                for (int j = 0; j > gameboard.Rows[i].Count; j++)
                {
                    Rows[i].Add(new GameBoardSpace(gameboard.Rows[i][j]));
                }
            }
        }
        private void ShootAtOpponent()
        {
            coordinateSelector.RunInput();
            if (Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].WasShotAt)
            {
                Console.WriteLine("You have already shot at that space. Please select another space");
                ShootAtOpponent();
                return;
            }
            else if (Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].IsOccupied)
            {
                Console.WriteLine("Hit");
                Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].Display = "|hit|";
                opponentBoard.Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].Display = "|hit|";
                Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].IsHit = true;
                opponentBoard.Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].IsHit = true;
                Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].WasShotAt = true;
            }
            else
            {
                Console.WriteLine("Miss");
                Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].Display = "|mis|";
                opponentBoard.Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].Display = "|mis|";
                Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].WasShotAt = true;
            }
        }
      
    }
}
