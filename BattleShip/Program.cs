using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Submarine submarine = new Submarine();
            ShipBoard gameboard = new ShipBoard();
           
            gameboard.DisplayBoard();
            gameboard.PlaceShip(submarine);
            gameboard.DisplayBoard();
            StrikeBoard strikeboard = new StrikeBoard(gameboard);
            strikeboard.DisplayBoard();
            strikeboard.ShootAtOpponent();
            strikeboard.ShootAtOpponent();
            strikeboard.DisplayBoard();
            gameboard.DisplayBoard();
            Console.ReadLine();



        }
    }
}
