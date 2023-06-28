using DragRacing.Cars;
using DragRacing.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.ShopStates
{
    class AirFilterShop : GameState, IShop
    {
        private List<int> airFilterUpgrades;
        private int multiplier;
        private bool alreadyUpgraded;

        public AirFilterShop(Game.Game game) : base(game) { }

        public override void StatePrompt()
        {
            textInterface.SuspensionPrompt(parentApp.HStage.GetPlayer);
            airFilterUpgrades = new List<int>() { 20, 30, 40, 50 };
            multiplier = 200;
            alreadyUpgraded = false;
        }

        public double SellTo(IRaceable car, int index)
        {
            OffRoadCar tempCar = car as OffRoadCar;
            if (tempCar != null)
            {
                if (parentApp.HStage.GetPlayer.Funds >= airFilterUpgrades[index] * multiplier && alreadyUpgraded == false)
                {
                    tempCar.airFilterBonus = airFilterUpgrades[index];
                    parentApp.HStage.GetPlayer.Funds -= (airFilterUpgrades[index] * multiplier);
                    alreadyUpgraded = true;
                    return tempCar.airFilterBonus;
                }
                return 0;
            }
            else return 0;
        }

        public double BuyFrom(IRaceable car)
        {
            if (car is OffRoadCar)
            {
                OffRoadCar tempCar = car as OffRoadCar;
                if (tempCar != null)
                {
                    parentApp.HStage.GetPlayer.Funds += (int)((double)tempCar.airFilterBonus * 0.5 * (double)multiplier);
                    tempCar.airFilterBonus = 0;
                    alreadyUpgraded = false;
                    return tempCar.airFilterBonus;
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
