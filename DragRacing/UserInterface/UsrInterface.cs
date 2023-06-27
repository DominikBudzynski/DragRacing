﻿using DragRacing.Cars;
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

        public void ProfilePrompt(Player player)
        {
            Console.Clear();
            Console.WriteLine("This is your profile\n");            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Funds: " + player.Funds);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nOwned cars\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (IRaceable raceable in player.PlayerVehicles)
            {
                Console.Write(raceable.ToString());
            }
            Console.ForegroundColor = ConsoleColor.White;

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
                "\n1.Better engine\n" + 
                "2.Race engine: 100$\n" +
                "3.Professional engine: 200$\n" +
                "4.Pro engine: 300$\n"
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
                "1.Better tires\n" +
                "2.Race tires\n" +
                "3.Professional tires\n" +
                "4.Pro tires\n"
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
                "1.Stock suspension\n" +
                "2.Race suspension\n" +
                "3.Professional suspension\n" +
                "4.Pro suspension\n"
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
                "\n1.Better turbo\n" +
                "2.Race turbo: 100$\n" +
                "3.Professional turbo: 200$\n" +
                "4.Pro turbo: 300$\n"
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
                "\n1.Better aerodynamics\n" +
                "2.Race aerodynamics: 100$\n" +
                "3.Professional aerodynamics: 200$\n" +
                "4.Pro aerodynamics: 300$\n"
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
                Console.WriteLine("\n" + i + "." + enemy.ToString());
            }
            Console.WriteLine("\nPress ESC to go back\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
