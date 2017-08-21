using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class GameBoardSpace
    {
        private bool isOccupied;
        private bool isHit;
        private string display;
        private string name;

        public string Display
        {
            get
            {
                return display;
            }
        }


        public GameBoardSpace()
        {
            display = "|__|";
        }
    }
}
