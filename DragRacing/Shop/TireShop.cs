using DragRacing.States;
using DragRacing.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.Shop
{
    class TireShop : ShopState
    {
        public TireShop(States.MainShopState parentShop, Game upperState) : base(parentShop, upperState) { }

        public override void EnterShop()
        {
            Console.Clear();
            shopInterface.TirePrompt();
        }

        public override void UpdateShop()
        {            
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            //MIEJSCE DO OSADZENIA LOGIKI
            if (keyInfo.Key == ConsoleKey.D1) ;
            else if (keyInfo.Key == ConsoleKey.D2) ;
            else if (keyInfo.Key == ConsoleKey.D3) ;
            else if (keyInfo.Key == ConsoleKey.D4) ;
            else if (keyInfo.Key == ConsoleKey.Escape) ESCButton();
            else if (keyInfo.Key == ConsoleKey.Enter) ;
        }

        public override double SellTo(Player player)
        {
            return 0;
        }

        public override double BuyFrom(Player player)
        {
            return 0;
        }

        
        public override void EnterButton() { }
        public override void ESCButton()
        {
            upperNestedState.ChangeState(new MainShopState(upperNestedState));          
        }
        public override void DigitOne() { }
        public override void DigitTwo() { }
        public override void DigitThree() { }
        public override void DigitFour() { }
    }
}
