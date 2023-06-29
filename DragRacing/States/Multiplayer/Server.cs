using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DragRacing.States.Multiplayer
{
    class Server
    {        
        private TcpListener listener;
        private TcpClient client;
        private NetworkStream stream;
        private byte[] clientBuffer;
        private double clientResult;        
        private IPAddress addr;
        private int port;

        public Server()
        {
            clientBuffer = new byte[1024];
            listener = null;
            addr = IPAddress.Parse("127.0.0.1");
            port = 8888;
            clientBuffer = new byte[100];
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
                stream = client.GetStream();
                return true;
            }
            return false;
        }

        public double ListenToClient()
        {
            stream = client.GetStream();
            stream.Read(clientBuffer, 0, clientBuffer.Length);
            clientResult = BitConverter.ToDouble(clientBuffer);
            if (clientResult == 0.01){
                if (client != null)
                    client.Close();
                return 0;
            }
            return clientResult;
        }

        public void SendDouble(double data)
        {
            clientBuffer = BitConverter.GetBytes(data);
            stream.Write(clientBuffer);
        }

        public bool EvaluateMultiplayerRace(double myResult)
        {
            if (clientResult > myResult)
            {
                //byte byteValue = BitConverter.GetBytes(value)[0];
                clientBuffer = BitConverter.GetBytes(0.0);
                stream.Write(clientBuffer);
                return true;
            }
            clientBuffer = BitConverter.GetBytes(1.0);
            stream.Write(clientBuffer);
            return false;
        }

        public void CloseServer()
        {
            if (client != null) client.Close();
            if (stream != null) stream.Close();            
            if (listener != null) listener.Stop();            
        }
    }
}
