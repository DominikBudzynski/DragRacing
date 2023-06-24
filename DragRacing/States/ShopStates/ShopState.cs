using DragRacing.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.ShopStates
{
    abstract class ShopState
    {
        protected Game.Game parentApp;
        protected TextInterface textInterface;

        public ShopState(Game.Game parentApp)
        {
            this.parentApp = parentApp;
            textInterface = new TextInterface();
        }

        public abstract void UpdateShop();
        public abstract void EnterButton();
        public abstract void ESCButton();
        public abstract void DigitOne();
        public abstract void DigitTwo();
        public abstract void DigitThree();
        public abstract void DigitFour();

    }
}
