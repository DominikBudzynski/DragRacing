using DragRacing.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.ShopStates
{
    class CarDealer : GameState
    {
        private List<IRaceable> cars;
        public CarDealer(Game.Game game) : base(game)
        {
            cars = new List<IRaceable>();
            cars.Add(new RaceCar(70, 10, 4, 30, 20, "Lanos"));
            cars.Add(new RaceCar(80, 10, 3, 30, 20, "Nubira"));
        }

        public override void StatePrompt()
        {
            textInterface.DealerPrompt(cars);           
        }

        public void SellTo(Game.Player customer, IRaceable car)
        {

        }

        //public void BuyFrom

        public override void EnterButton() { }       
        public override void ESCButton()
        {
            parentApp.ChangeState(new GameStates.MainShopState(parentApp));
        }
        public override void DigitOne() { }
        public override void DigitTwo() { }
        public override void DigitThree() { }
        public override void DigitFour() { }
    }
}
