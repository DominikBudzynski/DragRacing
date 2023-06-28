using DragRacing.Cars;
using DragRacing.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.ShopStates
{
    class SuspensionShop : GameState, IShop
    {
        private List<double> suspensionUpgrades;
        private int multiplier;
        private bool alreadyUpgraded;

        public SuspensionShop(Game.Game game) : base(game) { }

        public override void StatePrompt()
        {
            textInterface.SuspensionPrompt(parentApp.HStage.GetPlayer);
            suspensionUpgrades = new List<double>() { 0.75, 1.5, 2.25, 3 };
            multiplier = 1000;
            alreadyUpgraded = false;
        }

        public double SellTo(IRaceable car, int index)
        {
            OffRoadCar tempCar = car as OffRoadCar;
            if (tempCar != null)
            {
                if (parentApp.HStage.GetPlayer.Funds >= suspensionUpgrades[index] * multiplier && alreadyUpgraded == false)
                {
                    tempCar.suspensionBonus = suspensionUpgrades[index];
                    parentApp.HStage.GetPlayer.Funds -= (int)(suspensionUpgrades[index] * multiplier);
                    alreadyUpgraded = true;
                    return tempCar.suspensionBonus;
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
                    parentApp.HStage.GetPlayer.Funds += (int)((double)tempCar.suspensionBonus * 0.5 * (double)multiplier);
                    tempCar.suspensionBonus = 0;
                    alreadyUpgraded = false;
                    return tempCar.suspensionBonus;
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
