using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.GameStates
{
    class StageChoiceState : GameState
    {
        public StageChoiceState(Game.Game game) : base(game) { }

        public override void StatePrompt()
        {
            textInterface.StagePrompt();
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
