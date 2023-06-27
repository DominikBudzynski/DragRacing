using DragRacing.Cars;
using DragRacing.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.GameStates
{
    internal class SeeProfileState : GameState
    {
        private int highlightedElement;
        public SeeProfileState(Game.Game game) : base(game)
        {
            highlightedElement = 1;
        }

        public override void StatePrompt()
        {
            textInterface.ProfilePrompt(parentApp.HStage.GetPlayer, highlightedElement);
        }

        public override void UpdateGame()
        {
            StatePrompt();
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.DownArrow) UpArrow();
            else if (keyInfo.Key == ConsoleKey.UpArrow) DownArrow();
            else if (keyInfo.Key == ConsoleKey.Escape) ESCButton();
            else if (keyInfo.Key == ConsoleKey.Enter) EnterButton();
            else if (keyInfo.Key == ConsoleKey.S) SLetter();
        }

        public void UpArrow()
        {
            if (highlightedElement < parentApp.HStage.GetPlayer.PlayerVehicles.Count) 
                highlightedElement++;
        }

        
        public void DownArrow()
        {
            if (highlightedElement == 1) ;
            else highlightedElement--;
        }

        public override void ESCButton()
        {
            parentApp.ChangeState(new MenuState(parentApp));
        }
        
        public void SLetter()
        {
            if (parentApp.HStage.GetPlayer.PlayerVehicles.Count > 0)
            {
                parentApp.HStage.GetPlayer.Funds += (int)(0.6 * (double)parentApp.HStage.GetPlayer.PlayerVehicles[highlightedElement - 1].ShopPrize());
                parentApp.HStage.GetPlayer.PlayerVehicles.RemoveAt(highlightedElement - 1);                
            }
                
        }
        public override void EnterButton()
        {
            parentApp.HStage.GetPlayer.CurrentVehicle = parentApp.HStage.GetPlayer.PlayerVehicles[highlightedElement - 1];
        }
        public override void DigitOne() { }
        public override void DigitTwo() { }
        public override void DigitThree() { }
        public override void DigitFour() { }
        public override void DigitFive() { }
        public override void DigitSix() { }
    }
}
