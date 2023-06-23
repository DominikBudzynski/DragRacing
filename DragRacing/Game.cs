using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing
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
    }
}
