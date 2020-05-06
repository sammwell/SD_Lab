using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using core;

namespace server
{
    public class Connection
    {
        private Socket _socket;

        public Connection(Socket socket)
        {
            _socket = socket;

            Console.WriteLine($"Connected to client: {_socket.RemoteEndPoint}");
            Task.Factory.StartNew(() => Execute(_socket));
        }

        private void Execute(Socket socket)
        {
            while (true)
            {
                var buffer = new byte[2048];
                var bytesCount = socket.Receive(buffer);

                if (bytesCount != 0)
                {
                    var msgReceived = (Message) Serializer.FromStream(new MemoryStream(buffer));
                    Console.WriteLine($"Received msg: {msgReceived.Content}");
                }

                Console.WriteLine("Trying again");
                Thread.Sleep(500);
            }
        }
    }
}
