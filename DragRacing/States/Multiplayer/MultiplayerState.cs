using System;
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

        private enum raceRequest
        {
            RACE_AGAIN = 50,
            RACE_FINISH = 51
        }

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

        public void ServerRace()
        {
            if (server.EvaluateMultiplayerRace(parentApp.HStage.GetPlayer.CurrentVehicle.Accelerate(500)))
            {
                ifWon = true;
            }
            afterRace = true;
        }

        public void ClientRace()
        {
            client.SendDouble(parentApp.HStage.GetPlayer.CurrentVehicle.Accelerate(500));
            if (1.0 == client.ListenToRaceResult())
            {
                ifWon = true;
            }
            afterRace = true;
        }

        public override void DigitOne()
        {
            if (!clientOn)
            {                
                serverOn = true;
                try
                {
                    if (!afterRace)
                    {                        
                        textInterface.ServerPrompt();
                        server.StartServer();
                        textInterface.ServerResposnePrompt("Waiting for client to connect.\n");

                        if (server.ListenForClient())
                        {
                            server.ListenToClient();
                            ServerRace();
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
                clientOn = true;
                client.Connect();
                ClientRace();
            }
        }
        public override void DigitThree() { }
        public override void DigitFour() { }
        public override void DigitFive() { }
        public override void DigitSix() { }
        public override void DigitSeven() { }
        public override void EnterButton()
        {
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