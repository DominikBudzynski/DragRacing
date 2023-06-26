using DragRacing.Cars;
using DragRacing.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.ShopStates
{
    interface IShop
    {
        public double SellTo(Player customer);
        public double BuyFrom(Player customer);
    }
}
