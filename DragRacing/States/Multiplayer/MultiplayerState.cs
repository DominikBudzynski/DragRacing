using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using DragRacing.States.GameStates;

namespace DragRacing.States.Multiplayer
{
    class MultiplayerState : GameState
    {
        private Server server;
        private Client client;

        public MultiplayerState(Game.Game game) : base(game) { }

        public override void StatePrompt()
        {
            textInterface.MultiplayerPrompt();
            server = new Server();
            client = new Client();
        }

        public override void DigitOne()
        {
            //postawic serwer
            textInterface.ServerPrompt();
            textInterface.ServerResposnePrompt(server.StartServer());            
            if (server.ListenForClient())
            {
                textInterface.ServerResposnePrompt("Opponent connected\n");
            }

            server.ListenToClient();
            
        }
        public override void DigitTwo()
        {
            client.Connect();
            Console.ReadKey();
        }
        public override void DigitThree() { }
        public override void DigitFour() { }
        public override void DigitFive() { }
        public override void DigitSix() { }
        public override void DigitSeven() { }
        public override void EnterButton() { }
        public override void ESCButton()
        {
            parentApp.ChangeState(new StageChoiceState(parentApp));
        }
    }
}
