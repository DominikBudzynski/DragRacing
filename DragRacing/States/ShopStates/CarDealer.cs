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
            cars.Add(new RaceCar(70, 10, 30, 20, "FSO Polonez", 3500));
            cars.Add(new RaceCar(80, 10, 30, 20, "Daewoo Lanos", 4300));
            cars.Add(new RaceCar(95, 15, 33, 30, "Renault Clio", 4800));
            cars.Add(new RaceCar(110, 17, 36, 36, "Volkswagen Passat", 5000));
            cars.Add(new RaceCar(125, 19, 41, 42, "Honda Civic", 5500));
            cars.Add(new RaceCar(140, 24, 44, 50, "BMW M3", 6200));
            cars.Add(new RaceCar(155, 29, 49, 54, "Renault Clio V6", 6500));
            cars.Add(new OffRoadCar(150, 25, 48, 53, "Jeep Wagoneer", 5300));
            cars.Add(new OffRoadCar(170, 28, 48, 61, "Jeep Grand Cherokee", 5800));
            cars.Add(new OffRoadCar(190, 32, 54, 67, "Suzuki Jimny 4x4", 6200));
            cars.Add(new OffRoadCar(200, 34, 55, 73, "Toyota Land Cruiser", 6500));
            cars.Add(new RaceCar(215, 38, 58, 80, "Lamborghini Aventador SV", 7500));
            cars.Add(new RaceCar(230, 41, 60, 84, "Maserati Quattroporte", 8200));
            cars.Add(new RaceCar(245, 43, 59, 88, "Koenigsegg CCXR", 9000));
            cars.Add(new RaceCar(270, 49, 62, 102, "Bugatti Veyron", 11000));
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
            textInterface.DealerPrompt(parentApp.HStage.GetPlayer, cars, highlightElement);           
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
        public override void DigitSeven() { }
    }
}
