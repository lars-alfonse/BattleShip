using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    abstract class Ship
    {
        protected int length;
        public List<ShipPiece> parts;
        public bool isSunk;
        public int Length
        {
            get
            {
                return length;
            }
        }
    }
}
