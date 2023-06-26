using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.ShopStates
{
    class TireShop : GameState
    {

        public TireShop(Game.Game game) : base(game) { }

        public override void StatePrompt()
        {
            textInterface.TirePrompt();
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
