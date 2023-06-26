using DragRacing.Cars;
using DragRacing.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace DragRacing.States.ShopStates
{
    class EngineShop : GameState, IShop
    {
        private int highlightElement = 1;
        private List<int> engineUpgrades;
        public EngineShop(Game.Game game) : base(game)
        {
            engineUpgrades = new List<int>();
            engineUpgrades.Add(10);
            engineUpgrades.Add(20);
            engineUpgrades.Add(30);
            engineUpgrades.Add(40);
        }

        public override void StatePrompt()
        {
            textInterface.EnginePrompt(parentApp.HStage.GetPlayer);
        }
      
        public double SellTo(Player player, int value)
        {
            player.
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
            
        }

        public override void DigitTwo()
        {
        }

        public override void DigitThree()
        {
        }

        public override void DigitFour()
        {
            ;
        }
    }
}
