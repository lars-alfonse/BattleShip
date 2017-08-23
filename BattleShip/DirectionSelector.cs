using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class DirectionSelector : UserInterface
    {
        protected override void GetUserInput()
        {
            Console.WriteLine("Enter Direction You Would Like to Place Your Ship \n(up, down, left, right");
            userInput = Console.ReadLine().ToLower();
        }
        private void TranslateInput()
        {
            if (userInput == "up" || userInput == "u")
            {
                userInput = "up";
            }
            else if (userInput == "down" || userInput == "d")
            {
                userInput = "down";
            }
            else if (userInput == "left" || userInput == "l")
            {
                userInput = "left";
            }
            else if (userInput == "right" || userInput == "r")
            {
                userInput = "right";
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"{userInput} is not a valid entry please enter up, down, left, right (or u, d, l, r)");
                GetUserInput();
                return;
            }
        }
        public void RunInput()
        {
            GetUserInput();
            TranslateInput();
        }

    }
}
