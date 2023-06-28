﻿using System;
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
        }

        public void Connect()
        {
            client.Connect(addr, port);
            stream = client.GetStream();
        }

        public string SendData(double data)
        {
            transmitBuffer = BitConverter.GetBytes(data);
            stream.Write(transmitBuffer, 0, transmitBuffer.Length);
            return "Data sent correctly";
        }

        public void CloseClient()
        {
            SendData(0.01);
            client.Close();
        }
    }
}
