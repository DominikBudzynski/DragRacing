using DragRacing.States.ShopStates;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.GameStates
{
    internal class MainShopState : GameState
    {
        public MainShopState(Game.Game game) : base(game) { }

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
            if (parentApp.HStage.GetPlayer.CurrentVehicle != null)
            {
                parentApp.ChangeState(new EngineShop(parentApp));
            }
        }

        public override void DigitThree()
        {
            if (parentApp.HStage.GetPlayer.CurrentVehicle != null)
            {
                parentApp.ChangeState(new TireShop(parentApp));
            }
        }

        public override void DigitFour()
        {
            if (parentApp.HStage.GetPlayer.CurrentVehicle != null)
            {
                parentApp.ChangeState(new TurboShop(parentApp));
            }
        }

        public override void DigitFive()
        {
            if (parentApp.HStage.GetPlayer.CurrentVehicle != null)
            {
                parentApp.ChangeState(new AerodynamicsShop(parentApp));
            }
        }

        public override void DigitSix()
        {
            if (parentApp.HStage.GetPlayer.CurrentVehicle != null)
            {
                parentApp.ChangeState(new SuspensionShop(parentApp));
            }
        }

        public override void DigitSeven()
        {
            if (parentApp.HStage.GetPlayer.CurrentVehicle != null)
            {
                parentApp.ChangeState(new AirFilterShop(parentApp));
            }
        }
        public override void DigitSeven() { }

    }
}
