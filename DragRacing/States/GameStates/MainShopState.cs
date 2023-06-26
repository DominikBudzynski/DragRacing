using DragRacing.States.ShopStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.GameStates
{
    internal class MainShopState : GameState
    {
        public MainShopState(Game game) : base(game) { }

        public override void StatePrompt()
        {
            textInterface.ShopPrompt();
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
            parentApp.ChangeState(new CarDealer(parentApp));
        }

        public override void DigitTwo()
        {
            parentApp.ChangeState(new EngineShop(parentApp));
        }

        public override void DigitThree()
        {
            parentApp.ChangeState(new TireShop(parentApp));
        }

        public override void DigitFour()
        {
            parentApp.ChangeState(new SuspensionShop(parentApp));
        }
    }
}
