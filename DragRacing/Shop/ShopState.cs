﻿using DragRacing.UserInterface;
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
        protected ShopInterface shopInterface;
        protected Game upperNestedState;
        
        public ShopState(States.MainShopState parentShop, Game upperState)
        {

            this.parentShop = parentShop;
            shopInterface = new ShopInterface();
            upperNestedState = upperState;
        }

        public abstract double SellTo(Player player);
        public abstract double BuyFrom(Player player);
        
        public abstract void EnterShop();
        public abstract void UpdateShop();



        //Wybor sklepu w MainShopState
        //Wybor czesci/auta w kazdej poszczegolnej klasie 
        //EnterShop -> wyswietalanie prompta i wczytywanie klawisza


        //zadeklarowac metody odpowiadajace za zmiane stanu np. DigitOne()
        //public abstract void UpdateGame();
        public abstract void EnterButton();
        public abstract void ESCButton();
        public abstract void DigitOne();
        public abstract void DigitTwo();
        public abstract void DigitThree();
        public abstract void DigitFour();
    }
}
