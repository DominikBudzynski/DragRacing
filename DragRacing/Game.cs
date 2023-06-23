using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing
{
    class Game
    {
        private States.GameState currentState;

        public Game()
        {
            currentState = new States.MenuState(this);
        }

        public void ChangeState(States.GameState state)
        {
            currentState = state;
        }

        public void UpdateGame(ConsoleKey key)
        {
            currentState.UpdateGame(key);
        }
    }
}
