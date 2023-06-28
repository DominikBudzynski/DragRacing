using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.Multiplayer
{
    class Server
    {        
        private TcpListener listener;
        private TcpClient client;
        private NetworkStream stream;
        private byte[] clientReceiveBuffer;
        private double clientResult;
        private double serverResult;
        private IPAddress addr;
        private int port;

        public Server()
        {
            clientReceiveBuffer = new byte[1024];
            listener = null;
            addr = IPAddress.Parse("127.0.0.1");
            port = 8888;
        }

        public string StartServer()
        {
            listener = new TcpListener(addr, port);
            listener.Start();
            return "\nServer successfully started.";
        }

        public bool ListenForClient()
        {
            client = listener.AcceptTcpClient();            
            if (client != null)
            {
                return true;
            }
            return false;
        }

        public void ListenToClient()
        {
            stream = client.GetStream();
            int bytesRead = stream.Read(clientReceiveBuffer, 0, clientReceiveBuffer.Length);
            clientResult = BitConverter.ToDouble(clientReceiveBuffer);
            if (clientResult == 0.01){
                client.Close();
            }
        }

        public bool EvaluateMultiplayerRace(double myResult)
        {
            if (clientResult > myResult)
            {
                return true;
            }
            return false;
        }

        public void AnnounceWinner()
        {

        }

        public void CloseServer()
        {
            if (client != null) client.Close();
            if (stream != null) stream.Close();            
            if (listener != null) listener.Stop();            
        }
    }
}
