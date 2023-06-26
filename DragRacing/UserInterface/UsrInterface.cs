using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.UserInterface
{
    class TextInterface
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
                "You have entered shop\n" +
                "1.Car Dealer\n" +
                "2.Engine upgrade\n" +
                "3.Tire upgrade\n" +
                "4.Suspension upgrade\n" +
                "Press ESC to back to main menu"
                );
        }

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

        public void EnginePrompt()
                {
                    Console.WriteLine(
                        "Welcome to engine upgrade\n" +
                        "1.Stock engine\n" +
                        "2.Race engine\n" +
                        "3.Professional engine\n" +
                        "4.Pro engine\n"
                        );
                }

        public void TirePrompt()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "Welcome to tires upgrade\n" +
                "1.Stock tires\n" +
                "2.Race tires\n" +
                "3.Professional tires\n" +
                "4.Pro tires\n"
                );
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void SuspensionPrompt()
        {
            Console.WriteLine(
                "Welcome to suspension upgrade\n" +
                "1.Stock suspension\n" +
                "2.Race suspension\n" +
                "3.Professional suspension\n" +
                "4.Pro suspension\n"
                );
        }
    }
}
