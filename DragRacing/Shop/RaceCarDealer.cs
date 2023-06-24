using DragRacing.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.Shop
{
    class RaceCarDealer : IShop
    {
        private readonly List<RaceCar> storedCars;
        private readonly List<int> carsPrize;

        public RaceCarDealer()
        {
            storedCars = new List<RaceCar>();
            carsPrize = new List<int>();
            storedCars.Add(new RaceCar(70, 10, 30, 20, "AUTO1"));
            carsPrize.Add(7000);
            storedCars.Add(new RaceCar(90, 14, 34, 28, "AUTO2"));            
            storedCars.Add(new RaceCar(110, 18, 38, 36, "AUTO3"));
            storedCars.Add(new RaceCar(130, 22, 42, 44, "AUTO4"));            
        }

        public double SellTo(Player player)
        {
            if (player == null)
                return 0;
            else
            {
                player.AddCar(storedCars[0]);
                player.Funds -= carsPrize[0];
                return player.Funds;
            }                            
        }

        public double BuyFrom(Player player)
        {
            if (player == null) return 0;
            else
            {
                player.DeleteCar(storedCars[0]);
                player.Funds += (int)(0.7 * (double)carsPrize[0]);
            }
            return 0;
        }
    }
}
