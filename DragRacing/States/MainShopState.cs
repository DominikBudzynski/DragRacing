using DragRacing.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States
{
    internal class MainShopState : GameState
    {
        private Shop.ShopState currentShop;

        public MainShopState(Game game) : base(game) { }        

        //part responsible for shop state

        public void ChangeShop(Shop.ShopState shop)
        {
            currentShop = shop;
        }

        public void EnterShop()
        {
            /*zmienia stan na wyswietlanie sklepu*/
            //currentShop.EnterShop();
        }


        //part resposnible for game state

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

        public override void EnterButton()
        {
            ;
        }

        public override void ESCButton()
        {
            parentApp.ChangeState(new MenuState(parentApp));
        }

        public override void DigitOne()
        {

            //ChangeShop(new CarDealer(parentApp));
            //parentApp.ChangeShop(new RaceCarDealer());
            //shop.EnterShop();            
        }

        public override void DigitTwo()
        {
            /*
             * Wejscie do sklepu
             * Wyswietlenie czesci
             * Zbieranie inputu
             * Upgrade - logika
             * Wyswietlanie dalej/ESC to wyjscie
             */
        }

        public override void DigitThree()
        {
            Console.Clear();
            Console.Write("DUPA");
            ChangeShop(new TireShop(this));
            currentShop.EnterShop();
        }

        public override void DigitFour()
        {
            ;
        }
    }
}
