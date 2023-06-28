using DragRacing.Cars;
using DragRacing.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.UserInterface
{
    class TextInterface
    {
        //MENU

        public ConsoleKeyInfo ReadKey()
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

        public void ProfilePrompt(Player player, int highlightedElement)
        {
            int i = 1;
            Console.Clear();
            Console.WriteLine("This is your profile\n");            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Funds: " + player.Funds);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nOwned cars\n");            
            foreach (IRaceable raceable in player.PlayerVehicles)
            {
                if (i == highlightedElement)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(i.ToString() + " ");
                    Console.Write(raceable.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Write(i.ToString() + " ");
                    Console.Write(raceable.ToString());
                }

                i++;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nS - sell selected car\nReturn - set selectes car as current\n");
            Console.WriteLine("\nPress ESC to back to main menu\n");
        }

        public void StagePrompt()
        {
            Console.Clear();
            Console.WriteLine(
                "Here you can choose racing stage\n" +
                "1.Stage 1\n" +
                "2.Stage 2\n" +
                "3.Stage 3\n" +
                "4.Stage 4\n" +
                "5.Multiplayer\n" +
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
                "4.Turbo upgrade\n" +
                "5.Aerodynamics upgrade\n" +
                "6.Suspension upgrade\n" +
                "7.Air filter upgrade\n" +
                "Press ESC to back to main menu"
                );
        }

        public void DealerPrompt(List<IRaceable> args, int highlightedElement)
        {
            int i = 1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "Welcome to Car Dealer\n" +
                "Which one do You want to buy?\n" +
                "Press ESC to leave\n"
                );
            Console.ForegroundColor = ConsoleColor.White;
            foreach (IRaceable raceable in args)
            {
                if (i == highlightedElement)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(i.ToString() + " ");
                    Console.Write(raceable.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Write(i.ToString() + " ");
                    Console.Write(raceable.ToString());
                }
                
                i++;
            }
        }

        //SHOPS
        //ZROBIC COS Z CENAMI

        public void EnginePrompt(Player player)
         {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "Welcome to engine upgrade\n" +
                "Your car: " + player.CurrentVehicle.ToString() + 
                "Your funds: " + player.Funds.ToString() + "$" +
                "\n1.Better engine: 2000$\n" + 
                "2.Race engine: 4000$\n" +
                "3.Professional engine: 6000$\n" +
                "4.Pro engine: 8000$\n"
                );
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void TirePrompt(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "Welcome to tires upgrade\n" +
                "Your car: " + player.CurrentVehicle.ToString() +
                "Your funds: " + player.Funds.ToString() + "$" +
                "\n1.Better tires: 500$\n" +
                "2.Race tires: 1000$\n" +
                "3.Professional tires: 1500$ \n" +
                "4.Pro tires: 2000$\n"
                );
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void SuspensionPrompt(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "Welcome to suspension upgrade\n" +
                "Your car: " + player.CurrentVehicle.ToString() +
                "Your funds: " + player.Funds.ToString() + "$" +
                "\n1.Better suspension: 750$\n" +
                "2.Race suspension: 1500$\n" +
                "3.Professional suspension: 2250$\n" +
                "4.Pro suspension: 3000$\n"
                );
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void TurboPrompt(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "Welcome to engine upgrade\n" +
                "Your car: " + player.CurrentVehicle.ToString() +
                "Your funds: " + player.Funds.ToString() + "$" +
                "\n1.Better turbo: 750$\n" +
                "2.Race turbo: 1500$\n" +
                "3.Professional turbo: 2250$\n" +
                "4.Pro turbo: 3000$\n"
                );
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void AeroPrompt(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "Welcome to engine upgrade\n" +
                "Your car: " + player.CurrentVehicle.ToString() +
                "Your funds: " + player.Funds.ToString() + "$" +
                "\n1.Better aerodynamics: 1000$\n" +
                "2.Race aerodynamics: 2000$\n" +
                "3.Professional aerodynamics: 3000$\n" +
                "4.Pro aerodynamics: 4000$\n"
                );
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void AirFilterPrompt(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "Welcome to air filter upgrade\n" +
                "Your car: " + player.CurrentVehicle.ToString() +
                "Your funds: " + player.Funds.ToString() + "$" +
                "\n1.Better air filter: 1000$\n" +
                "2.Race air filter: 2000$\n" +
                "3.Professional air filter: 3000$\n" +
                "4.Pro air filter: 4000$\n"
                );
            Console.ForegroundColor = ConsoleColor.White;
        }

        //RACING STAGES

        public void DuringRacePrompt(List<Stage> enemies, int stage)
        {
            int i = 1;
            Console.ForegroundColor = ConsoleColor.Red;
            foreach(IRaceable enemy in enemies[stage - 1].StageEnemies)
            {
                Console.Write("" + i + "." + enemy.ToString());
                i++;
            }
            Console.WriteLine("\nPress ESC to go back\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void RaceResults(bool ifWon, Stage stage, int enemy)
        {
            if (ifWon)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("You has won!\n" +
                    "\nGained cash: " +
                    stage.TrackPrizes[enemy - 1][0].ToString() +
                    "$\nPress Return to back to the stage choice.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose!\n" +
                    "Gained Experience: 0 Gained cash: 0$ \nPress Return to back to the stage choice.");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        //MULTIPLAYER

        public void MultiplayerPrompt()
        {
            Console.WriteLine(
                "Welcome to multiplayer mode.\n" +
                "1.Host new game\n" +
                "2.Connect to existing game\n" + 
                "Press ESC to go back\n");
        }

        public void ServerPrompt()
        {
            Console.Clear();
            Console.WriteLine(
                "You are hosting a server right now.\n" +
                "Waiting for the opponent."
                );            
        }

        public void ServerResposnePrompt(string arg)
        {
            Console.WriteLine(arg);
        }

        public void MultiplayerRaceResult(bool ifWon)
        {
            if (ifWon)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You has won!\n" +
                    "\nGained cash: DO ZROBIENIA" +                    
                    "$\nPress Return to back to the stage choice.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose!\n" +
                    "Gained cash: 0$ \nPress Return to back to the stage choice.");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
