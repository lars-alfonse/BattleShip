using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class ShipBoard : GameBoard
    {
        CoordinateSelector coordinateSelector = new CoordinateSelector();
        DirectionSelector directionSelector = new DirectionSelector();
        List<GameBoardSpace> shipPlacement;

        public void PlaceShip(Ship ship)
        {
            coordinateSelector.RunInput();
            directionSelector.RunInput();
            GetShipPlacement(ship);
            CheckForShipCollision(ship);

        }
        private void GetShipPlacement(Ship ship)
        {
            shipPlacement = new List<GameBoardSpace>();
            try
            {
                switch (directionSelector.direction)
                {
                    case "up":
                        for (int i = 0; i < ship.Length; i++)
                        {
                            shipPlacement.Add(Rows[coordinateSelector.ycoordinate - i][coordinateSelector.xcoordinate]);
                        }
                        break;
                    case "down":
                        for (int i = 0; i < ship.Length; i++)
                        {
                            shipPlacement.Add(Rows[coordinateSelector.ycoordinate + i][coordinateSelector.xcoordinate]);
                        }
                        break;
                    case "left":
                        for (int i = 0; i < ship.Length; i++)
                        {
                            shipPlacement.Add(Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate - i]);
                        }
                        break;
                    case "right":
                        for (int i = 0; i < ship.Length; i++)
                        {
                            shipPlacement.Add(Rows[coordinateSelector.ycoordinate][coordinateSelector.xcoordinate + i]);
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ship out of bounds please place ship elsewhere");
                PlaceShip(ship);
                return;
            }
        }

        private void CheckForShipCollision(Ship ship)
        {
            foreach (GameBoardSpace space in shipPlacement)
            {
                if (space.IsOccupied)
                {
                    Console.WriteLine($"Ship already in space {space.Name} please place your ship elsewhere");
                    PlaceShip(ship);

                }
            }
        }
    }
}
