using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.UserInterface
{
    class ShopInterface
    {
        public void DealerPrompt()
        {
            Console.WriteLine(
                "Welcome to Car Dealer\n" +
                "Which one do You want to buy?\n" +
                "1.LANOS\n" +
                "2.NUBIRA\n" +
                "3.Press ESC to leave\n"
                );
        }

        public void TirePrompt()
        {
            Console.WriteLine(
                "Welcome to tires upgrade\n" +
                "1.Stock tires\n" +
                "2.Race tires\n" +
                "3.Professional tires\n" +
                "4.Pro tires\n"
                );
        }
    }
}
