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
        bool clientOn, serverOn, afterRace;

        public MultiplayerState(Game.Game game) : base(game) { }

        public override void StatePrompt()
        {
            textInterface.MultiplayerPrompt();
            server = new Server();
            client = new Client();
            serverOn = false;
            clientOn = false;
            afterRace = false;
        }

        public override void DigitOne()
        {
            //CZY TO EXCEPTION NA PEWNO POTRZEBNE??
            serverOn = true;
            try
            {
                //postawic serwer
                textInterface.ServerPrompt();
                textInterface.ServerResposnePrompt(server.StartServer());
                if (server.ListenForClient())
                {
                    textInterface.ServerResposnePrompt("Opponent connected\n");
                }                
                server.ListenToClient();
                if (server.EvaluateMultiplayerRace(parentApp.HStage.GetPlayer.CurrentVehicle.Accelerate(500)))
                {
                    textInterface.MultiplayerRaceResult(true);
                    afterRace = true;
                }
            }
            catch (Exception e)
            {
                textInterface.ServerResposnePrompt("An error occurred: " + e.Message);                
            }
            
        }
        public override void DigitTwo()
        {
            //WYSWIETLIC PROMPTA ZE NP OCZEKIWANIE NA INNEGO GRACZA
            //WYSWIETLENIE WYNIKU
            clientOn = true;
            client.Connect();
            client.SendData(parentApp.HStage.GetPlayer.CurrentVehicle.Accelerate(500));
            Console.ReadKey();
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
