using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragRacing.States.GameStates;
using DragRacing.States.ShopStates;

namespace DragRacing.Game
{
    class Game
    {
        private GameState currentState;        

        public Game()
        {
            currentState = new MenuState(this);
        }

        public void ChangeState(GameState state)
        {
            currentState = state;
        }

        /*
        public void ChangeShop(ShopState newShop)
        {
            shopState = newShop;
        }
        */

        public void UpdateGame()
        {
            currentState.UpdateGame();
        }


    }
}
