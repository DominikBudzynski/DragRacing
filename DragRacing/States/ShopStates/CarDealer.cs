using DragRacing.States.GameStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.ShopStates
{
    class CarDealer : ShopState
    {
        public CarDealer(States.GameStates.MainShopState parentShop) : base(parentShop) { }

        public override void UpdateShop()
        {
            ;
        }

        public override void EnterButton()
        {
            ;
        }

        public override void ESCButton()
        {
            parentApp.ChangeState(new MainShopState(parentApp));
        }

        public override void DigitOne()
        {
            ;
        }

        public override void DigitTwo()
        {
            ;
        }

        public override void DigitThree()
        {
            ;
        }

        public override void DigitFour()
        {
            ;
        }

        public override void DigitFive()
        {
            ;
        }
    }
}
