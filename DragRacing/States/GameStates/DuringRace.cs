using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.GameStates
{
    class DuringRace : GameState
    {
        int currentStage;

        public DuringRace(Game.Game game, int stage) : base(game)
        {
            currentStage = stage;
        }

        public override void StatePrompt()
        {
            textInterface.DuringRacePrompt(parentApp.HStage.GetStages, currentStage);            
        }

        public override void DigitOne()
        {
            //wyscig z 1 se stage
        }
        public override void DigitTwo()
        {
            //wyscig z 2 se stage
        }
        public override void DigitThree()
        {
            //wyscig z 3 se stage
        }
        public override void DigitFour()
        {
            //wyscig z 4 se stage
        }
        public override void DigitFive() { }
        public override void DigitSix() { }
        public override void ESCButton()
        {
            parentApp.ChangeState(new StageChoiceState(parentApp));
        }
        public override void EnterButton()
        {
            //jesli po wyscigu to ma kasowac ekran konca wyscigu
        }

    }
}
