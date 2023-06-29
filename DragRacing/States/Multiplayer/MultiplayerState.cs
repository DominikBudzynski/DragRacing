﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using DragRacing.Game;
using DragRacing.States.GameStates;

namespace DragRacing.States.Multiplayer
{
    class MultiplayerState : GameState
    {
        private Server server;
        private Client client;
        bool clientOn, serverOn, afterRace, ifWon, connected;

        public MultiplayerState(Game.Game game) : base(game)
        {
            server = new Server();
            client = new Client();
            serverOn = false;
            clientOn = false;
            afterRace = false;
            ifWon = false;
            connected = false;
        }

        public override void StatePrompt()
        {
            if (connected)
                textInterface.MultiplayerRacePrompt();
            else if (!afterRace)
                textInterface.MultiplayerPrompt();
            else if (afterRace)
                textInterface.MultiplayerRaceResult(ifWon);            
                
        }

        public override void DigitOne()
        {
            if (!clientOn)
            {
                //CZY TO EXCEPTION NA PEWNO POTRZEBNE??
                serverOn = true;
                try
                {
                    if (!afterRace)
                    {
                        //postawic serwer
                        textInterface.ServerPrompt();
                        server.StartServer();
                        textInterface.ServerResposnePrompt("Waiting for client to connect.\n");

                        if (server.ListenForClient())
                        {
                            //connected = true;
                            //odbieranie wyniku wyscigu
                            server.ListenToClient();
                            if (server.EvaluateMultiplayerRace(parentApp.HStage.GetPlayer.CurrentVehicle.Accelerate(500)))
                            {
                                ifWon = true;
                            }
                            afterRace = true;
                        }
                    }
                }
                catch (Exception e)
                {
                    textInterface.ServerResposnePrompt("An error occurred: " + e.Message);
                }
            }            
        }

        public override void DigitTwo()
        {
            if (!serverOn)
            {
                //WYSWIETLIC PROMPTA ZE NP OCZEKIWANIE NA INNEGO GRACZA
                //WYSWIETLENIE WYNIKU
                clientOn = true;
                client.Connect();
                client.SendDouble(parentApp.HStage.GetPlayer.CurrentVehicle.Accelerate(500));
                if (client.ListenToRaceResult())
                {
                    ifWon = true;
                }
                afterRace = true;
                //client.SendData(parentApp.HStage.GetPlayer.CurrentVehicle.Accelerate(500));
                //Console.ReadKey();
            }

        }
        public override void DigitThree()
        {
/*            if (clientOn)
            {                
                client.SendDouble(parentApp.HStage.GetPlayer.CurrentVehicle.Accelerate(500));
                //oblusyzc dane jako wynik
                client.ListenToData();
                textInterface.MultiplayerRaceResult(ifWon);
            }
            else if (serverOn)
            {
                server.ListenToClient();
                if (server.EvaluateMultiplayerRace(parentApp.HStage.GetPlayer.CurrentVehicle.Accelerate(500)))
                {
                    ifWon = true;
                }
                afterRace = true;
            }*/
        }
        public override void DigitFour() { }
        public override void DigitFive() { }
        public override void DigitSix() { }
        public override void DigitSeven() { }
        public override void EnterButton()
        {
            /*if (afterRace)
            {
                if (clientOn)
                    client.SendDouble(parentApp.HStage.GetPlayer.CurrentVehicle.Accelerate(500));
            }
            */
            afterRace = false;
        }
        public override void ESCButton()
        {
            if (serverOn)
                server.CloseServer();
            else if (clientOn)
                client.CloseClient();
            parentApp.ChangeState(new StageChoiceState(parentApp));
        }
    }
}
