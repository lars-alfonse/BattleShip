using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class ShipBoard : GameBoard
    {
        CoordinateSelector selector = new CoordinateSelector();

        public void PlaceShip(Ship ship)
        {
            selector.RunInput();

        }
    }
}
