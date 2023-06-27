using DragRacing.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.ShopStates
{
    class AerodynamicsShop : GameState, IShop
    {
        private List<int> aeroUpgrades;

        public AerodynamicsShop(Game.Game game) : base(game)
        {
            aeroUpgrades = new List<int>() { 10, 20, 30, 40 };
        }

        public override void StatePrompt()
        {
            textInterface.AeroPrompt(parentApp.HStage.GetPlayer);
        }
        
        public double SellTo(IRaceable car, int index)
        {
            RaceCar tempCar = car as RaceCar;
            if (tempCar != null)
            {
                if (parentApp.HStage.GetPlayer.Funds >= aeroUpgrades[index] * 100)
                {
                    tempCar.aeroBonus = aeroUpgrades[index];
                    parentApp.HStage.GetPlayer.Funds -= (aeroUpgrades[index] * 100);
                    return tempCar.aeroBonus;
                }
                return 0;
            }
            return 0;
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

        public override void DigitFive() { }

        public override void DigitSix() { }
    }
}
