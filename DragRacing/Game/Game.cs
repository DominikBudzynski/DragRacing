using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.Game
{
    class Game
    {
        private States.GameState currentState;
        private StageHandler hStage;

        public Game()
        {
            currentState = new States.GameStates.MenuState(this);
            hStage = new StageHandler();
        }

        public StageHandler HStage
        {
            get { return hStage; }
        }

        public void ChangeState(States.GameState state)
        {
            currentState = state;
        }

        public void UpdateGame()
        {
            currentState.UpdateGame();
        }
    }
}
