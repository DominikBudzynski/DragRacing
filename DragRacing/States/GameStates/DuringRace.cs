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
        bool afterRace, ifWon;

        public DuringRace(Game.Game game, int stage) : base(game)
        {
            currentStage = stage;
            ifWon = false;
            afterRace = false;
        }

        public override void StatePrompt()
        {
            if (!afterRace)
            {
                textInterface.DuringRacePrompt(parentApp.HStage.GetStages, currentStage);
            }
            else
            {
                textInterface.RaceResults(ifWon);
            }
            
        }

        public override void DigitOne()
        {
            //wyscig z 1 se stage
            parentApp.HStage.EvaluateRace(parentApp.HStage.GetPlayer.CurrentVehicle, 
                                          parentApp.HStage.GetStages[currentStage - 1].StageEnemies[0]);
            afterRace = true;

        }
        public override void DigitTwo()
        {
            //wyscig z 2 se stage
            parentApp.HStage.EvaluateRace(parentApp.HStage.GetPlayer.CurrentVehicle, 
                                          parentApp.HStage.GetStages[currentStage - 1].StageEnemies[1]);
            afterRace = true;
        }
        public override void DigitThree()
        {
            //wyscig z 3 se stage
            parentApp.HStage.EvaluateRace(parentApp.HStage.GetPlayer.CurrentVehicle, 
                                          parentApp.HStage.GetStages[currentStage - 1].StageEnemies[2]);
            afterRace = true;
        }
        public override void DigitFour()
        {
            //wyscig z 4 se stage
            parentApp.HStage.EvaluateRace(parentApp.HStage.GetPlayer.CurrentVehicle, 
                                          parentApp.HStage.GetStages[currentStage - 1].StageEnemies[3]);
            afterRace = true;
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
            afterRace = false;
        }

    }
}
