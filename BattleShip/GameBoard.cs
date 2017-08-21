using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class GameBoard
    {
        protected string[,] gameBoard = new string[10, 10] { { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" }, { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" }, { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" }, { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" }, { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" }, { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" }, { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" }, { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" }, { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" }, { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" } };
        protected int boardLength;
        protected int boardHeight;
        public GameBoard()
        {
            boardLength = gameBoard.GetLength(0);
            boardHeight = gameBoard.GetLength(1);
        }
        public void DisplayBoard()
        {
            for (int i = 0; i < boardLength; i++)
            { 
                for (int j = 0; j < boardHeight; j++)
                {
                    Console.Write(string.Format("{0} ", gameBoard[i, j]));

                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();

        }

    }
}
