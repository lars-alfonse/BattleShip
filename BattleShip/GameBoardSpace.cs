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
        private bool wasShotAt;
        private string display;
        private string name;
        public ShipPiece shipPiece;

        public string Display
        {
            get
            {
                return display;
            }
            set
            {
                display = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public bool IsOccupied
        {
            get
            {
                return isOccupied;
            }
            set
            {
                isOccupied = value;
            }
        }
        public bool IsHit
        {
            get
            {
                return isHit;
            }
            set
            {
                isHit = value;
            }
        }
        public bool WasShotAt
        {
            get
            {
                return wasShotAt;
            }
            set
            {
                wasShotAt = value;
            }
        }
        public GameBoardSpace()
        {
            display = "|__|";
            isHit = false;
            isOccupied = false;
            wasShotAt = false;
        }
        public GameBoardSpace(int counter)
        {
            GetName(counter);
            display = $"|__|";
            isHit = false;
            isOccupied = false;
            wasShotAt = false;
        }
        public GameBoardSpace(GameBoardSpace space)
        {
            name = space.name;
            display = $"|__|";
            isHit = false;
            isOccupied = space.IsOccupied;
            wasShotAt = false;
        }
        private void GetName(int counter)
        {
            if(counter%10 == 0)
            {
                switch (counter)
                {
                    case 10:
                        name = "A10";
                        break;
                    case 20:
                        name = "B10";
                        break;
                    case 30:
                        name = "C10";
                        break;
                    case 40:
                        name = "D10";
                        break;
                    case 50:
                        name = "E10";
                        break;
                    case 60:
                        name = "F10";
                        break;
                    case 70:
                        name = "G10";
                        break;
                    case 80:
                        name = "H10";
                        break;
                    case 90:
                        name = "I10";
                        break;
                    case 100:
                        name = "J10";
                        break;
                    default:
                        break;
                }
            }
            else if (counter - 90 > 0)
            {
                name = $"J{counter % 10}";
            }
            else if (counter - 80 > 0)
            {
                name = $"I{counter % 10}";
            }
            else if (counter - 70 > 0)
            {
                name = $"H{counter % 10}";
            }
            else if (counter - 60 > 0)
            {
                name = $"G{counter % 10}";
            }
            else if (counter - 50 > 0)
            {
                name = $"F{counter % 10}";
            }
            else if (counter - 40 > 0)
            {
                name = $"E{counter % 10}";
            }
            else if (counter - 30 > 0)
            {
                name = $"D{counter % 10}";
            }
            else if (counter - 20 > 0)
            {
                name = $"C{counter % 10}";
            }
            else if (counter - 10 > 0)
            {
                name = $"B{counter % 10}";
            }
            else
            {
                name = $"A{counter % 10}";
            }
        }
    }
}
