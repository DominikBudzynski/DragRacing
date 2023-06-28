using DragRacing.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.ShopStates
{
    class TurboShop : GameState, IShop
    {
        private List<double> turboUpgrades;
        private int multiplier;
        private bool alreadyUpgraded;

        public TurboShop(Game.Game game) : base(game)
        {
            turboUpgrades = new List<double>() { 0.75,1.5 ,2.25 , 3 };
            multiplier = 1000;
            alreadyUpgraded = false;
        }

        public override void StatePrompt()
        {
            textInterface.TurboPrompt(parentApp.HStage.GetPlayer);
        }

        public double SellTo(IRaceable car, int index)
        {
            RaceCar tempCar = car as RaceCar;
            if (tempCar != null)
            {
                if (parentApp.HStage.GetPlayer.Funds >= turboUpgrades[index] * multiplier && alreadyUpgraded == false)
                {
                    tempCar.turboBonus = turboUpgrades[index];
                    parentApp.HStage.GetPlayer.Funds -= (int)(turboUpgrades[index] * multiplier);
                    alreadyUpgraded = true;
                    return tempCar.turboBonus;
                }
                return 0;
            }
            return 0;
        }

        public double BuyFrom(IRaceable car)
        {
            if (car is RaceCar)
            {
                RaceCar tempCar = car as RaceCar;
                if (tempCar != null)
                {
                    parentApp.HStage.GetPlayer.Funds += (int)((double)tempCar.turboBonus * 0.5 * (double)multiplier);
                    tempCar.turboBonus = 0;
                    alreadyUpgraded = false;
                    return tempCar.turboBonus;
                }
                return -1;
            }
            return -1;
        }

        public override void EnterButton()
        {            
            BuyFrom(parentApp.HStage.GetPlayer.CurrentVehicle);
        }

        public override void ESCButton()
        {
            parentApp.ChangeState(new GameStates.MainShopState(parentApp));
        }

        public override void DigitOne()
        {
            SellTo(parentApp.HStage.GetPlayer.CurrentVehicle, 0);
        }

        public override void DigitTwo()
        {
            SellTo(parentApp.HStage.GetPlayer.CurrentVehicle, 1);
        }

        public override void DigitThree()
        {
            SellTo(parentApp.HStage.GetPlayer.CurrentVehicle, 2);
        }

        public override void DigitFour()
        {
            SellTo(parentApp.HStage.GetPlayer.CurrentVehicle, 3);
        }

        public override void DigitFive() { }
        public override void DigitSix() { }
        public override void DigitSeven() { }
    }
}
