using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.UserInterface
{
    class MenuInterface
    {
        public static ConsoleKeyInfo ReadKey()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.Clear();
            return keyInfo;
        }

        public void MenuPrompt()
        {
            Console.Clear();
            Console.WriteLine(
                "\nMain menu\n" +
                "Options to choose:\n" +
                "1.See player profile\n" +
                "2.Race stage choice\n" +
                "3.Shop\n" +
                "\nESC to exit\n"
                );
        }

        public void ProfilePrompt()
        {
            Console.Clear();
            Console.WriteLine(
                "This is your profile\n" +
                "Press ESC to back to main menu"
                );
        }

        public void StagePrompt()
        {
            Console.Clear();
            Console.WriteLine(
                "Here you can choose racing stage\n" +
                "Press ESC to back to main menu"
                );
        }

        public void ShopPrompt()
        {
            Console.Clear();
            Console.WriteLine(
                "You have entered shop.\n" +
                "1.Car dealer\n" + 
                "2.Engine upgrade\n" +
                "3.Tire upgrade\n" +
                "4.Turbocharger upgrade\n" +
                "5.Suspension upgrade\n" +
                "Press ESC to back to main menu"
                );
        }
        
    }
}
