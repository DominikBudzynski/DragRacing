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
        public EngineShop (States.MainShopState parentShop) : base (parentShop) { }

        public override void UpdateGame()
        {
            textInterface.ShopPrompt();
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.D1) DigitOne();
            else if (keyInfo.Key == ConsoleKey.D2) DigitTwo();
            else if (keyInfo.Key == ConsoleKey.D3) DigitThree();
            else if (keyInfo.Key == ConsoleKey.D4) DigitFour();
            else if (keyInfo.Key == ConsoleKey.Escape) ESCButton();
            else if (keyInfo.Key == ConsoleKey.Enter) EnterButton();
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
