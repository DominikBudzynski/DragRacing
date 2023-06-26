using DragRacing.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.Shop
{
    abstract class ShopState
    {
        //parentShop musi byc typu MainShopState
        protected States.MainShopState parentShop;
        protected TextInterface textInterface;

        public ShopState(States.MainShopState parentShop)
        {
            this.parentShop = parentShop;
            textInterface = new TextInterface();
        }

        public abstract double SellTo(Player player);
        public abstract double BuyFrom(Player player);

        //zadeklarowac metody odpowiadajace za zmiane stanu np. DigitOne()
        public abstract void UpdateGame();
        public abstract void EnterButton();
        public abstract void ESCButton();
        public abstract void DigitOne();
        public abstract void DigitTwo();
        public abstract void DigitThree();
        public abstract void DigitFour();
    }
}
