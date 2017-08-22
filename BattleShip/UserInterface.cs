using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class UserInterface
    {
        protected string userInput; 

        public string UserInput
        {
            get
            {
                return userInput;
            }
        }

        protected virtual void GetUserInput()
        {

        }
    }
}
