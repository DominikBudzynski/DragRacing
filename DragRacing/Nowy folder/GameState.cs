using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing
{
    abstract class GameState
    {
        protected Game parentApp;

        public GameState(Game parentApp)
        {
            this.parentApp = parentApp;
        }

        public abstract void EnterButton();
        public abstract void ESCButton();
        public abstract void DigitOne();
        public abstract void DigitTwo();
        public abstract void DigitThree();
        public abstract void DigitFour();

    }
}
