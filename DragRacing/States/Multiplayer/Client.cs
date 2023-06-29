using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.States.Multiplayer
{
    class Client
    {
        private TcpClient client;       
        private NetworkStream stream;
        private IPAddress addr;
        private byte[] transmitBuffer;
        private byte[] receiveBuffer;
        private int port;

        public Client()
        {
            client = new TcpClient();
            addr = IPAddress.Parse("127.0.0.1");
            port = 8888;
            transmitBuffer = new byte[100];
            receiveBuffer = new byte[100];
        }

        public void Connect()
        {
            client.Connect(addr, port);
            stream = client.GetStream();
        }

        public void SendDouble(double data)
        {
            transmitBuffer = BitConverter.GetBytes(data);
            stream.Write(transmitBuffer, 0, transmitBuffer.Length);            
        }

        public double ListenToRaceResult()
        {
            stream.Read(receiveBuffer, 0, receiveBuffer.Length);
            return BitConverter.ToDouble(receiveBuffer, 0);
        }

        public void CloseClient()
        {
            SendDouble(0.01);
            client.Close();
        }
    }
}
