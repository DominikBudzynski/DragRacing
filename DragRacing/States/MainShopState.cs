using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States
{
    internal class MainShopState : GameState
    {
        public MainShopState(Game game) : base(game) { }

        public override void UpdateGame(ConsoleKey key)
        {
            
        }

        public override void EnterButton()
        {
            ;
        }

        public override void ESCButton()
        {
            ;
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
    }
}
