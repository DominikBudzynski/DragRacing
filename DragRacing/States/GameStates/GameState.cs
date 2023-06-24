using DragRacing.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragRacing.Game;

namespace DragRacing.States.GameStates
{
    abstract class GameState
    {
        protected Game.Game parentApp;
        protected MenuInterface textInterface;

        public GameState(Game.Game parentApp)
        {
            this.parentApp = parentApp;
            textInterface = new MenuInterface();
        }

        public abstract void UpdateGame();
        public abstract void EnterButton();
        public abstract void ESCButton();
        public abstract void DigitOne();
        public abstract void DigitTwo();
        public abstract void DigitThree();
        public abstract void DigitFour();

    }
}
