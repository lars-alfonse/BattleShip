using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class GameBoard
        {

        public List<List<GameBoardSpace>> Rows;
        private int gameSpaceCounter;


        public GameBoard()
        {
            gameSpaceCounter = 0;
            GenerateBoard();
        }

        private void GenerateBoard()
        {
            Rows = new List<List<GameBoardSpace>>();
            for (int i = 0; i < 10; i++)
            {
                List<GameBoardSpace> column = new List<GameBoardSpace>();
                for (int j = 0; j < 10; j++)
                {
                    gameSpaceCounter++;
                    GameBoardSpace space = new GameBoardSpace(gameSpaceCounter);
                    column.Add(space);
                    
                }
                Rows.Add(column);
            }
        }
        public void DisplayBoard()
        {
            Console.WriteLine("   1    2    3    4    5    6    7    8    9    10");
            string[] columnLabel = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            for (int i = 0; i < Rows.Count; i++)
            {
                Console.Write(string.Format("{0} ", columnLabel[i]));
                for (int j = 0; j < Rows[i].Count; j++)
                {
                    Console.Write(string.Format("{0} ", Rows[i][j].Display));

                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();

        }
    }
}
