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
        private List<int> turboUpgrades;

        public TurboShop(Game.Game game) : base(game)
        {
            turboUpgrades = new List<int>() { 10, 20, 30, 40 };
        }

        public override void StatePrompt()
        {
            textInterface.TurboPrompt();
        }
        public double SellTo(IRaceable car, int index)
        {
            OffRoadCar tempCar = car as OffRoadCar;
            if (tempCar != null)
            {
                if (parentApp.HStage.GetPlayer.Funds >= turboUpgrades[index] * 100)
                    tempCar.turboBonus = turboUpgrades[index];
                parentApp.HStage.GetPlayer.Funds -= (turboUpgrades[index] * 100);
                return tempCar.engineBonus;
            }
            else return 0;
        }
    }
}
