using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.GameStates
{
    class MenuState : GameState
    {

        public MenuState(Game.Game game) : base(game) { }

        public override void UpdateGame()
        {
            textInterface.MenuPrompt();
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.D1) DigitOne();
            else if (keyInfo.Key == ConsoleKey.D2) DigitTwo();
            else if (keyInfo.Key == ConsoleKey.D3) DigitThree();
            else if (keyInfo.Key == ConsoleKey.D4) DigitFour();
            else if (keyInfo.Key == ConsoleKey.Escape) ESCButton();
            else if (keyInfo.Key == ConsoleKey.Enter) EnterButton();
        }


        public override void DigitOne()
        {
            parentApp.ChangeState(new SeeProfileState(parentApp));
        }

        public override void DigitTwo()
        {
            parentApp.ChangeState(new StageChoiceState(parentApp));
        }

        public override void DigitThree()
        {
            parentApp.ChangeState(new MainShopState(parentApp));
        }

        public override void DigitFour()
        {
            ;
        }

        public override void EnterButton()
        {
            ;
        }

        public override void ESCButton()
        {
            Environment.Exit(1);
        }
    }
}
