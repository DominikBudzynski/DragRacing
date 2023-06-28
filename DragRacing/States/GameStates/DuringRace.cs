using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.GameStates
{
    class DuringRace : GameState
    {
        int currentStage, currentEnemy;
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
                textInterface.RaceResults(ifWon, parentApp.HStage.GetStages[currentStage - 1], currentEnemy);
            }
            
        }        
        /// /////////////////////////////////////////////////        
        //COS ZROBIC Z DYSTANSEM
        public override void DigitOne()
        {           
            currentEnemy = 1;
            ifWon = parentApp.HStage.EvaluateRace(currentStage, currentEnemy);
            parentApp.HStage.UpdatePlayer(currentStage, currentEnemy);         
            afterRace = true;

        }
        public override void DigitTwo()
        {
            currentEnemy = 2;
            ifWon = parentApp.HStage.EvaluateRace(currentStage, currentEnemy);
            parentApp.HStage.UpdatePlayer(currentStage, currentEnemy);           
            afterRace = true;
        }
        public override void DigitThree()
        {
            currentEnemy = 3;
            ifWon = parentApp.HStage.EvaluateRace(currentStage, currentEnemy);
            parentApp.HStage.UpdatePlayer(currentStage, currentEnemy);         
            afterRace = true;
        }
        public override void DigitFour()
        {
            currentEnemy = 4;
            ifWon = parentApp.HStage.EvaluateRace(currentStage, currentEnemy);
            parentApp.HStage.UpdatePlayer(currentStage, currentEnemy);      
            afterRace = true;
        }
        public override void DigitFive() { }
        public override void DigitSix() { }
        public override void ESCButton()
        {
            if (!afterRace)
                parentApp.ChangeState(new StageChoiceState(parentApp));
        }
        public override void EnterButton()
        {
            afterRace = false;
        }

    }
}
