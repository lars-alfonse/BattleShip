using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Submarine : Ship 
    {
        public Submarine()
        {
            length = 3;
            parts = new List<ShipPiece>();
            for (int i = 0; i < length; i++)
            {
                ShipPiece piece = new ShipPiece();
                piece.display = "|sb|";
                parts.Add(piece);
            }
        }
    }
}
