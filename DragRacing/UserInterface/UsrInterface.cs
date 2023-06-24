using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.UserInterface
{
    class UsrInterface
    {
        public void MenuPrompt()
        {
            Console.Clear();
            Console.WriteLine(
                "Main menu\n" +
                "Options to choose:\n" +
                "1.See player profile\n" +
                "2.Race stage choice\n" +
                "3.Shop\n"
                );
        }

        public void ProfilePrompt()
        {
            Console.Clear();
            Console.WriteLine(
                "This is your profile\n" +
                "Press ESC to back to main menu\n"
                );
        }

        public void StagePrompt()
        {
            Console.Clear();
            Console.WriteLine(
                "Here you can choose racing stage\n" +
                "Press ESC to back to main menu\n"
                );
        }
    }
}
