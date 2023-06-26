using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.GameStates
{
    internal class SeeProfileState : GameState
    {
        public SeeProfileState(Game game) : base(game) { }

        public override void StatePrompt()
        {
            textInterface.ProfilePrompt();
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
            ;
        }

        public override void DigitTwo()
        {
            ;
        }

        public override void DigitThree()
        {
            ;
        }

        public override void DigitFour()
        {
            ;
        }
    }
}
