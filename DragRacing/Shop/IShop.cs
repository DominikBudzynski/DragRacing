using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.Shop
{
    interface IShop
    {
        public double SellTo(Player player);
        public double BuyFrom(Player player);
    }
}
