using DragRacing.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.ShopStates
{
    class TireShop : GameState, IShop
    {
        private List<int> tireUpgrades;
        private int multiplier;
        private bool alreadyUpgraded;

        public TireShop(Game.Game game) : base(game)
        {
            tireUpgrades = new List<int>() { 10, 20, 30, 40 };
            multiplier = 200;
            alreadyUpgraded = false;
        }

        public override void StatePrompt()
        {
            textInterface.TirePrompt(parentApp.HStage.GetPlayer);
        }

        public double SellTo(IRaceable car, int index)
        {
            Car tempCar = car as Car;
            if (tempCar != null)
            {
                if (parentApp.HStage.GetPlayer.Funds >= tireUpgrades[index] * multiplier && alreadyUpgraded == false)
                {
                    tempCar.tireBonus = tireUpgrades[index];
                    parentApp.HStage.GetPlayer.Funds -= (tireUpgrades[index] * multiplier);
                    alreadyUpgraded = true;
                    return tempCar.tireBonus;
                }
                return 0;
            }
            else return 0;
        }

        public double BuyFrom(IRaceable car)
        {
            if (car is Car)
            {
                RaceCar tempCar = car as RaceCar;
                if (tempCar != null)
                {
                    parentApp.HStage.GetPlayer.Funds += (int)((double)tempCar.tireBonus * 0.5 * (double)multiplier);
                    tempCar.tireBonus = 0;
                    alreadyUpgraded = false;
                    return tempCar.tireBonus;
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
            ; SellTo(parentApp.HStage.GetPlayer.CurrentVehicle, 3);
        }
        public override void DigitFive() { }
        public override void DigitSix() { }
    }
}
