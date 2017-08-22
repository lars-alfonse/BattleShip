using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class CoordinateSelector : UserInterface
    {
        public int ycoordinate;
        public int xcoordinate;
        protected override void GetUserInput()
        {
            Console.WriteLine("Enter Coordinate");
            userInput = Console.ReadLine().ToLower();
        }
        private void TranslateCoordinate()
        {
            ycoordinate = (int)userInput[0] - 97;
            userInput = userInput.Remove(0, 1);
            xcoordinate = int.Parse(userInput)-1;
            Console.WriteLine(ycoordinate);
            Console.WriteLine(xcoordinate);
            Console.ReadLine();
        }
        public void RunInput()
        {
            GetUserInput();
            TranslateCoordinate();
        }
    }
}
