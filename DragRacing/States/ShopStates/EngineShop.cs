using DragRacing.Cars;
using DragRacing.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace DragRacing.States.ShopStates
{
    class EngineShop : GameState, IShop
    {        
        private List<int> engineUpgrades;
        private int multiplier;
        private bool alreadyUpgraded;

        public EngineShop(Game.Game game) : base(game)
        {
            engineUpgrades = new List<int>() { 5, 10, 15, 20 };
            multiplier = 200;
            alreadyUpgraded = false;
        }

        public override void StatePrompt()
        {
            textInterface.EnginePrompt(parentApp.HStage.GetPlayer);
        }

        public double SellTo(IRaceable car, int index)
        {            
            Car tempCar = car as Car;
            if (tempCar != null)
            {
                if (parentApp.HStage.GetPlayer.Funds >= engineUpgrades[index] * multiplier && alreadyUpgraded == false)
                {
                    tempCar.engineBonus = engineUpgrades[index];
                    parentApp.HStage.GetPlayer.Funds -= (engineUpgrades[index] * multiplier);
                    alreadyUpgraded = true;
                    return tempCar.engineBonus;
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
                    parentApp.HStage.GetPlayer.Funds += (int)((double)tempCar.engineBonus * 0.5 * (double)multiplier);
                    tempCar.engineBonus = 0;
                    alreadyUpgraded = false;
                    return tempCar.engineBonus;
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
    }
}
