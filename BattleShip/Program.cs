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
            GameBoard gameboard = new GameBoard();
            gameboard.DisplayBoard();
            CoordinateSelector selector = new CoordinateSelector();
            selector.RunInput();
        }
    }
}
