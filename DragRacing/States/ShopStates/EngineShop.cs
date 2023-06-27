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
        public EngineShop(Game.Game game) : base(game)
        {
            engineUpgrades = new List<int>() { 10, 20, 30, 40 };
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
                if (parentApp.HStage.GetPlayer.Funds >= engineUpgrades[index] * 100)
                tempCar.engineBonus = engineUpgrades[index];
                parentApp.HStage.GetPlayer.Funds -= (engineUpgrades[index] * 100);
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
