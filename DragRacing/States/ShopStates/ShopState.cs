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
        protected States.GameStates.MainShopState parentApp;
        protected ShopInterface textInterface;

        public ShopState(States.GameStates.MainShopState parentApp)
        {
            this.parentApp = parentApp;
            textInterface = new ShopInterface();
        }

        public abstract void UpdateShop();
        public abstract void EnterButton();
        public abstract void ESCButton();
        public abstract void DigitOne();
        public abstract void DigitTwo();
        public abstract void DigitThree();
        public abstract void DigitFour();
        public abstract void DigitFive();

    }
}
