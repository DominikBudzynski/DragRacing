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
            parentApp.ChangeState(new DuringRace(parentApp, 1));
        }

        public override void DigitTwo()
        {
            parentApp.ChangeState(new DuringRace(parentApp, 2));
        }

        public override void DigitThree()
        {
            parentApp.ChangeState(new DuringRace(parentApp, 3));
        }

        public override void DigitFour()
        {
            parentApp.ChangeState(new DuringRace(parentApp, 4));
        }
        public override void DigitFive() { }
        public override void DigitSix() { }
        public override void DigitSeven() { }
    }
}
