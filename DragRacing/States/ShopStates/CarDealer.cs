using DragRacing.Cars;
using DragRacing.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.ShopStates
{
    class CarDealer : GameState
    {
        private int highlightElement = 1;
        private List<IRaceable> cars;        

        public CarDealer(Game.Game game) : base(game)
        {
            cars = new List<IRaceable>();            
            cars.Add(new RaceCar(70, 10, 4, 30, 20, "Lanos", 6500));
            cars.Add(new RaceCar(80, 10, 3, 30, 20, "Nubira", 8300));
        }

        public override void UpdateGame()
        {
            StatePrompt();
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.DownArrow) UpArrow();
            else if (keyInfo.Key == ConsoleKey.UpArrow) DownArrow();
            else if (keyInfo.Key == ConsoleKey.Escape) ESCButton();
            else if (keyInfo.Key == ConsoleKey.Enter) EnterButton();            
        }

        public override void StatePrompt()
        {
            textInterface.DealerPrompt(cars, highlightElement);           
        }

        public bool SellTo(Game.Player customer, IRaceable car)
        {
            if (customer != null)
            {
                if (customer.Funds > car.ShopPrize())
                {
                    customer.AddCar(car);
                    customer.Funds -= car.ShopPrize();
                    customer.CurrentVehicle = car;
                    return true;
                    //return "You successfully bought the car:";
                }
                else return false;
                //else return "You can't afford this car.";
            }
            else return false;
        }

        public void UpArrow()
        {
            if (highlightElement < cars.Count) highlightElement++;
        }

        public void DownArrow()
        {
            if (highlightElement == 1) ;
            else highlightElement--;
        }

        public override void EnterButton()
        {
            SellTo(parentApp.HStage.GetPlayer, cars[highlightElement - 1]);
        }     
        public override void ESCButton()
        {
            parentApp.ChangeState(new GameStates.MainShopState(parentApp));
        }        

        public override void DigitOne() { }
        public override void DigitTwo() { }
        public override void DigitThree() { }
        public override void DigitFour() { }
        public override void DigitFive() { }
        public override void DigitSix() { }
    }
}
