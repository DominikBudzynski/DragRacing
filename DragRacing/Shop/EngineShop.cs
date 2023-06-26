using DragRacing.States;
using DragRacing.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.Shop
{
    class EngineShop : ShopState
    {       
        public EngineShop (States.MainShopState parentShop, Game upperState) : base (parentShop, upperState) { }

        public override void EnterShop() { }
        public override void UpdateShop()
        {
            ;
        }

        public override double SellTo(Player player)
        {
            return 0;
        }

        public override double BuyFrom(Player player)
        {
            return 0;
        }

        public override void EnterButton() { /*narazie pusto*/ }
        public override void ESCButton()
        {
            //powrót do stanu MainShop
        }
        public override void DigitOne() { /*kupno ulepszenia silnika*/ }
        public override void DigitTwo() { /*kupno ulepszenia silnika*/ }
        public override void DigitThree() { /*kupno ulepszenia silnika*/ }
        public override void DigitFour() { /*kupno ulepszenia silnika*/ }
    }
}
