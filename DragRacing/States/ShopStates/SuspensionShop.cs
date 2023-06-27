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
        private List<int> suspensionUpgrades;
        public SuspensionShop(Game.Game game) : base(game) { }

        public override void StatePrompt()
        {
            textInterface.SuspensionPrompt(parentApp.HStage.GetPlayer);
            suspensionUpgrades = new List<int>() { 20, 30, 40, 50 };
        }

        public double SellTo(IRaceable car, int index)
        {
            OffRoadCar tempCar = car as OffRoadCar;
            if (tempCar != null)
            {
                if (parentApp.HStage.GetPlayer.Funds >= suspensionUpgrades[index] * 100)
                    tempCar.suspensionBonus = suspensionUpgrades[index];
                parentApp.HStage.GetPlayer.Funds -= (suspensionUpgrades[index] * 100);
                return tempCar.engineBonus;
            }
            else return 0;
        }
        
        public double BuyFrom(IRaceable car)
        {
            return 0;
        }
        public override void EnterButton()
        {
            ;
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
    }
}
