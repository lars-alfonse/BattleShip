using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class testGameboard
    {
        protected string[,] gameBoard = new string[10, 10] { { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" },
            { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" },
            { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" },
            { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" },
            { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" },
            { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" },
            { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" },
            { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" },
            { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" },
            { "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|", "|__|" } };
        protected int boardLength;
        protected int boardHeight;
        public testGameboard()
        {
            boardLength = gameBoard.GetLength(0);
            boardHeight = gameBoard.GetLength(1);
        }
        public void DisplayBoard()
        {
            Console.WriteLine("   1    2    3    4    5    6    7    8    9    10");
            string[] columnLabel = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            for (int i = 0; i < boardLength; i++)
            {
                Console.Write(string.Format("{0} ", columnLabel[i]));
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
