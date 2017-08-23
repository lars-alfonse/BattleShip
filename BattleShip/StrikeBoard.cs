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
            GenerateBoard(gameboard);
        }
        public void ShootAtOpponent()
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
                Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].Display = "|HT|";
                opponentBoard.Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].Display = "|HT|";
                Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].IsHit = true;
                opponentBoard.Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].IsHit = true;
                Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].WasShotAt = true;
            }
            else
            {
                Console.WriteLine("Miss");
                Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].Display = "|MS|";
                opponentBoard.Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].Display = "|MS|";
                Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate].WasShotAt = true;
            }
        }
      
    }
}
