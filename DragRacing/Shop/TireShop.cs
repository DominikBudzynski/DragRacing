using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.Shop
{
    class TireShop : ShopState
    {
        public TireShop(States.MainShopState parentShop) : base(parentShop) { }


        public override double SellTo(Player player)
        {
            return 0;
        }

        public override double BuyFrom(Player player)
        {
            return 0;
        }
    }
}
