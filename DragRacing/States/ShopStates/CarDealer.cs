using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.ShopStates
{
    class CarDealer : GameState
    {
        public CarDealer(Game game) : base(game) { }

        public override void UpdateGame()
        {
            textInterface.TirePrompt();
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
            parentApp.ChangeState(new GameStates.MainShopState(parentApp));
        }

        public override void DigitOne()
        {
        }

        public override void DigitTwo()
        {
        }

        public override void DigitThree()
        {
        }

        public override void DigitFour()
        {
            ;
        }
    }
}
